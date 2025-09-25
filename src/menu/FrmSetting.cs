using K3DAsyncEngineLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using VLeague.src.helper;
using VLeague.src.menu;
using VLeague.src.model;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;

/*
 * Author Phong Phung
 * version CG Karisma 2.8.1.0
 * KAEngine interface use connect to CG server
 * KAScenePlayer interface use to get scene
 * KAObject interface use to get property of object
 * KAScene interface use to get variable of scene and use "set"  to change value 
*/
namespace VLeague
{
    public partial class FrmSetting : Form
    {
        private MyEventHandler MyEventHandler;

        public int m_SceneIndex = -1;

        public int m_LogIndex = 0;

        public KAEngine KAEngine;

        public KAScenePlayer KAScenePlayer;

        public KAObject KAObject;

        public KAScene KAScene;

        public static int layerTSN;

        public static int layerTSL;

        public static int layerPreMatch;

        public static int layerBackground;

        public static int layerPostMatch;

        public static int layerTheDo;

        public static int layerBuGio;

        public static int layerGoalItem;

        public static int layerPenalty;

        public static string SmatchID, Sweather, SmatchOff, SvarOff, SgroupStanding, Stactical, Sbackground, Stransition, Sthongke;

        public static string SpermClock, SpermClockOut, SaddTime, SredClock, SkickoffTime, SkickoffTimeOut, SkickOff, SkickOff2;

        public static string Stitle, SBar, SGhiBan, SGoalClock, SYellowCard, SSecondYellowCard, SRedCard, SThongke1, SThongke2, SThongke3;

        public static string SSub1, SSub2, SSub3, SVarGrid, SBarVar, SUpdateVar, SDecisionVar, SPenalty;



        private static string key = "CONNECT";

        private static string ip = "IPADDRESS";

        private static string port = "PORT";

        private static string workingPath = "WORKINGFOLDER";

        private static string dataFilePath = "DATA";


        public static string timeHomeGoalScore = "";
        public static string timeAwayGoalScore = "";

        public FrmSetting()
        {
            InitializeComponent();
        }

        private void FrmSetting_Load(object sender, EventArgs e)
        {
            try
            {
                AppConfig.envFileConfig();
                txtIpAddress.Text = AppConfig.ConfigReader.ReadString(key, ip);
                txtPort.Text = AppConfig.ConfigReader.ReadString(key, port);
                txtWorkingFolder.Text = AppConfig.ConfigReader.ReadString(key, workingPath);
                txtData.Text = AppConfig.ConfigReader.ReadString(key, dataFilePath);
                MyEventHandler = new MyEventHandler(this);
                DBConfig.Connection(txtData.Text);

                connectCG();

                LoadLayerScene("VLEAGUE1");

                loadMatchIDandThoiTiet();
                loadTrongTai();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi load dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadLayerScene(string keyCG)
        {
            //Layer VL1
            layerTSN = AppConfig.ConfigReader.ReadInteger(keyCG, "layerTSN");
            layerTSL = AppConfig.ConfigReader.ReadInteger(keyCG, "layerTSL");
            layerPenalty = AppConfig.ConfigReader.ReadInteger(keyCG, "layerPenalty");
            layerPreMatch = AppConfig.ConfigReader.ReadInteger(keyCG, "layerPreMatch");
            layerPostMatch = AppConfig.ConfigReader.ReadInteger(keyCG, "layerPostMatch");
            layerBackground = AppConfig.ConfigReader.ReadInteger(keyCG, "layerBackground");
            layerTheDo = AppConfig.ConfigReader.ReadInteger(keyCG, "layerTheDo");
            layerBuGio = AppConfig.ConfigReader.ReadInteger(keyCG, "layerBuGio");
            layerGoalItem = AppConfig.ConfigReader.ReadInteger(keyCG, "layerGoalItem");

            //Scene VL1
            SmatchID = AppConfig.ConfigReader.ReadString(keyCG, "matchID");
            Sweather = AppConfig.ConfigReader.ReadString(keyCG, "weather");
            SmatchOff = AppConfig.ConfigReader.ReadString(keyCG, "matchOff");
            SvarOff = AppConfig.ConfigReader.ReadString(keyCG, "varOff");
            SgroupStanding = AppConfig.ConfigReader.ReadString(keyCG, "groupStanding");
            Stactical = AppConfig.ConfigReader.ReadString(keyCG, "tactical");
            Sbackground = AppConfig.ConfigReader.ReadString(keyCG, "background");
            Stransition = AppConfig.ConfigReader.ReadString(keyCG, "transition");
            Sthongke = AppConfig.ConfigReader.ReadString(keyCG, "thongke");
            SpermClock = AppConfig.ConfigReader.ReadString(keyCG, "permClock");
            SpermClockOut = AppConfig.ConfigReader.ReadString(keyCG, "permClockOut");
            SaddTime = AppConfig.ConfigReader.ReadString(keyCG, "addTime");
            SredClock = AppConfig.ConfigReader.ReadString(keyCG, "redClock");
            SkickoffTime = AppConfig.ConfigReader.ReadString(keyCG, "kickoffTime");
            SkickoffTimeOut = AppConfig.ConfigReader.ReadString(keyCG, "kickoffTimeOut");
            SkickOff = AppConfig.ConfigReader.ReadString(keyCG, "kickOff");
            SkickOff2 = AppConfig.ConfigReader.ReadString(keyCG, "kickOff2");
            Stitle = AppConfig.ConfigReader.ReadString(keyCG, "title");
            SBar = AppConfig.ConfigReader.ReadString(keyCG, "Bar");
            SGhiBan = AppConfig.ConfigReader.ReadString(keyCG, "GhiBan");
            SGoalClock = AppConfig.ConfigReader.ReadString(keyCG, "GoalClock");
            SYellowCard = AppConfig.ConfigReader.ReadString(keyCG, "YellowCard");
            SSecondYellowCard = AppConfig.ConfigReader.ReadString(keyCG, "SecondYellowCard");
            SRedCard = AppConfig.ConfigReader.ReadString(keyCG, "RedCard");
            SThongke1 = AppConfig.ConfigReader.ReadString(keyCG, "Thongke1");
            SThongke2 = AppConfig.ConfigReader.ReadString(keyCG, "Thongke2");
            SThongke3 = AppConfig.ConfigReader.ReadString(keyCG, "Thongke3");
            SSub1 = AppConfig.ConfigReader.ReadString(keyCG, "Sub1");
            SSub2 = AppConfig.ConfigReader.ReadString(keyCG, "Sub2");
            SSub3 = AppConfig.ConfigReader.ReadString(keyCG, "Sub3");
            SVarGrid = AppConfig.ConfigReader.ReadString(keyCG, "VarGrid");
            SBarVar = AppConfig.ConfigReader.ReadString(keyCG, "BarVar");
            SUpdateVar = AppConfig.ConfigReader.ReadString(keyCG, "UpdateVar");
            SDecisionVar = AppConfig.ConfigReader.ReadString(keyCG, "DecisionVar");
            SPenalty = AppConfig.ConfigReader.ReadString(keyCG, "Penalty");
        }


        public void OnLogMessage(string LogMessage)
        {
            try
            {
                logBoxKarisma.Items.Add(LogMessage);
                logBoxKarisma.SetSelected(m_LogIndex, value: true);
                m_LogIndex++;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void loadMatchIDandThoiTiet()
        {
            DBConfig.doGetInfoTournaments();
            txtVongDau.Text = DBConfig.tournaments.Tables[0].Rows[1]["Name"].ToString();
            txtDiaDiem.Text = DBConfig.tournaments.Tables[0].Rows[2]["Name"].ToString();
            txtThoiGian.Text = DBConfig.tournaments.Tables[0].Rows[3]["Name"].ToString();

            DBConfig.doGetInfoWeather();
            txtIcon.Text = DBConfig.weather.Tables[0].Rows[0]["Name"].ToString();
            txtThoiTiet.Text = DBConfig.weather.Tables[0].Rows[1]["Name"].ToString();
            txtNhietDo.Text = DBConfig.weather.Tables[0].Rows[2]["Name"].ToString();
            txtDoAm.Text = DBConfig.weather.Tables[0].Rows[3]["Name"].ToString();
            txtSucGio.Text = DBConfig.weather.Tables[0].Rows[4]["Name"].ToString();
        }
        private void loadTrongTai()
        {
            DBConfig.doGetInforeferee();
            txtTT1.Text = DBConfig.referee.Tables[0].Rows[0]["Name"].ToString();
            txtTT2.Text = DBConfig.referee.Tables[0].Rows[1]["Name"].ToString();
            txtTT3.Text = DBConfig.referee.Tables[0].Rows[2]["Name"].ToString();
            txtTT4.Text = DBConfig.referee.Tables[0].Rows[3]["Name"].ToString();
            txtVAR1.Text = DBConfig.referee.Tables[0].Rows[4]["Name"].ToString();
            txtVAR2.Text = DBConfig.referee.Tables[0].Rows[5]["Name"].ToString();
        }
            private void btnIconBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtIcon.Text = openFileDialog.FileName;
            }
        }

        #region Play, Pause, Stop, StopEff, StopAll, Resume, DeletePause
        public void Play(int layer)
        {
            if (KAEngine != null && KAScenePlayer != null)
            {
                KAScenePlayer.Play(layer);
            }
        }
        public void Pause(int layer)
        {
            if (KAEngine != null && KAScenePlayer != null)
            {
                KAScenePlayer.Pause(layer);
            }
        }
        public void Stop(int layer)
        {
            if (KAEngine != null && KAScenePlayer != null)
            {
                KAScenePlayer.Stop(layer);
            }
        }
        public void StopEff(int layer)
        {
            if (KAEngine != null && KAScenePlayer != null)
            {
                KAScenePlayer.PlayOut(layer);
            }
        }
        public void StopAll()
        {
            if (KAEngine != null && KAScenePlayer != null)
            {
                KAScenePlayer.StopAll();
            }
        }
        public void Resume(int layer)
        {
            if (KAEngine != null && KAScenePlayer != null)
            {
                KAScenePlayer.Resume(layer);
            }
        }
        public void DeletePause(int AnimationType, int FrameNo, int bAll)
        {
            if (KAEngine != null && KAScene != null)
            {
                KAScene.DeletePause(AnimationType, FrameNo, bAll);
            }
            else
            {
                MessageBox.Show("Not have KAScene");
            }
        }
        #endregion

        private void btnConnectKarisma_Click(object sender, EventArgs e)
        {
            string ip = txtIpAddress.Text;
            int port = Convert.ToInt32(txtPort.Text);
            if (KAEngine != null && ip != null && port > 0)
            {
                KAEngine.KTAPConnect(1, ip, port, 0, MyEventHandler);
                KAScenePlayer = KAEngine.GetScenePlayer();
            }
            else
            {
                MessageBox.Show("KAEngine does not exits, Please open KarismaCG");
                OnLogMessage("Disconnected Karisma");
            }
        }
        private void btnDisconnectKarisma_Click(object sender, EventArgs e)
        {
            KAEngine.Disconnect();
            OnLogMessage("Disconnected Karisma");
        }
        private void btnWorkingFolderBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FolderBrowserWFDialog = new FolderBrowserDialog();
            if (FolderBrowserWFDialog.ShowDialog() == DialogResult.OK)
            {
                txtWorkingFolder.Text = FolderBrowserWFDialog.SelectedPath;
            }
        }
        private void btnDataBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtData.Text = openFileDialog.FileName;
                try
                {
                    DBConfig.Connection(txtData.Text);
                    loadMatchIDandThoiTiet();
                    loadTrongTai();
                    MessageBox.Show("Dữ liệu đã được tải thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show("Không tìm thấy tệp tin. Vui lòng kiểm tra lại đường dẫn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Handler.handlerError("btnDataBrowser_Click - FileNotFoundException", ex);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Định dạng tệp không đúng. Vui lòng chọn tệp đúng định dạng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Handler.handlerError("btnDataBrowser_Click - FormatException", ex);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Handler.handlerError("btnDataBrowser_Click - General Exception", ex);
                }
            }
        }


        private void txtData_Leave(object sender, EventArgs e)
        {
            loadMatchIDandThoiTiet();
            loadTrongTai();
        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            AppConfig.ConfigReader.Write(key, ip, txtIpAddress.Text);
            AppConfig.ConfigReader.Write(key, port, txtPort.Text);
            AppConfig.ConfigReader.Write(key, workingPath, txtWorkingFolder.Text);
            AppConfig.ConfigReader.Write(key, dataFilePath, txtData.Text);

            LoadLayerScene("VLEAGUE1");
            MessageBox.Show("Success Change!");
        }
        private void btnConnectDB_Click(object sender, EventArgs e)
        {
            DBConfig.Connection(txtData.Text);
            AppConfig.ConfigReader.Write(key, workingPath, txtWorkingFolder.Text);
            AppConfig.ConfigReader.Write(key, dataFilePath, txtData.Text);
        }
        public void connectCG()
        {
            KAEngine = new KAEngine();

            if (KAEngine != null)
            {
                KAEngine.KTAPConnect(1, txtIpAddress.Text, Convert.ToInt32(txtPort.Text), 0, MyEventHandler);
                KAScenePlayer = KAEngine.GetScenePlayer();
            }
            else
            {
                FrmKarismaMenu.FrmSetting.OnLogMessage("KAEngine does not exits!");
            }
        }
        private void btnOpenConfig_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = Application.StartupPath + "\\config.cfg";
            process.Start();
        }
        public void loadLineUpSub(string txtTeamLongName,
    string txtCoachName, string teamHomeItem, string teamAwayItem, Player[] playersLineUp, Player[] PlayersSub)
        {

            string scene = "\\teamlineup.t2s";
            string workingPath = txtWorkingFolder.Text;
            string path = workingPath + "\\Scenes"+ scene;
            KAScene KAScene = KAEngine.LoadScene(path, scene);
            Thread.Sleep(10);
            KAEngine.BeginTransaction();
            for (int i = 0; i < playersLineUp.Length; i++)
            {
                int index = i + 1;
                string name = "cauthu" + index;
                string number = "sa" + index;

                int subIndex = i + 12;
                string nameSub = "cauthu" + subIndex;
                string numSub = "sa" + subIndex;

                KAObject = KAScene.GetObject(name);
                KAObject.SetValue($"{playersLineUp[i].Name} {playersLineUp[i].Lineup}");
                KAObject = KAScene.GetObject(number);
                KAObject.SetValue(playersLineUp[i].Number.ToString());
                if (PlayersSub.Length > i)
                {
                    KAObject = KAScene.GetObject(nameSub);
                    KAObject.SetValue($"{PlayersSub[i].Name} {PlayersSub[i].Lineup}");
                    KAObject = KAScene.GetObject(numSub);
                    KAObject.SetValue(PlayersSub[i].Number.ToString());
                }
            }

            KAObject = KAScene.GetObject("logo");
            KAObject.SetValue(teamHomeItem);
            KAObject = KAScene.GetObject("logoout");
            KAObject.SetValue(teamAwayItem);
            KAObject = KAScene.GetObject("team");
            KAObject.SetValue(txtTeamLongName);
            KAObject = KAScene.GetObject("hlv");
            KAObject.SetValue(txtCoachName);
            KAEngine.EndTransaction();
            Thread.Sleep(10);
            KAScenePlayer.Prepare(layerPreMatch, KAScene);
            Thread.Sleep(10);
            KAScenePlayer.Play(layerPreMatch);
        }

        public void loadSceneLineup(string tactical, string logo, string hlv, Player[] playersHome)
        {
            string scene = Stactical + tactical + ".t2s";
            KAScene KAScene = KAEngine.LoadScene(scene, scene);

            Thread.Sleep(10);
            KAEngine.BeginTransaction();

            // Xử lý 11 cầu thủ chính (index 0-10)
            for (int i = 0; i < 11; i++)
            {
                int index = i + 1;

                // Tên và số áo cầu thủ chính
                string longPlayer = "tenct" + index;
                string shortPlayer = "tensub" + index;
                string SoAo = "aoct" + index;
                string SoSub = "sosub" + index;
                string imageLineup = "anhct" + index;
                string imageSub = "aosub" + index;

                KAObject = KAScene.GetObject(longPlayer);
                KAObject.SetValue(playersHome[i].Name);

                KAObject = KAScene.GetObject(shortPlayer);
                KAObject.SetValue(playersHome[i].ShortName);

                KAObject = KAScene.GetObject(SoAo);
                KAObject.SetValue(playersHome[i].Number.ToString());

                KAObject = KAScene.GetObject(SoSub);
                KAObject.SetValue(playersHome[i].Number.ToString());

                KAObject = KAScene.GetObject(imageLineup);
                KAObject.SetValue(playersHome[i].Lineup);

                KAObject = KAScene.GetObject(imageSub);
                KAObject.SetValue(playersHome[i].Sub);
            }

            // Xử lý 10 cầu thủ dự bị (index 11-20 trong playersHome)
            for (int i = 0; i < 10; i++)
            {
                int subIndex = i + 12; // bắt đầu từ cauthu12
                string nameSub = "tenct" + subIndex;
                string numSub = "aoct" + subIndex;

                if (playersHome.Length > (11 + i)) // Kiểm tra có đủ cầu thủ dự bị không
                {
                    KAObject = KAScene.GetObject(nameSub);
                    KAObject.SetValue(playersHome[11 + i].Name);

                    KAObject = KAScene.GetObject(numSub);
                    KAObject.SetValue(playersHome[11 + i].Number.ToString());
                }
            }

            // Thiết lập thông tin đội
            KAObject = KAScene.GetObject("logo");
            KAObject.SetValue(logo);

            KAObject = KAScene.GetObject("hlv");
            KAObject.SetValue(hlv);

            KAObject = KAScene.GetObject("tactical");
            KAObject.SetValue("SƠ ĐỒ CHIẾN THUẬT " + tactical);

            KAEngine.EndTransaction();
            Thread.Sleep(10);
            KAScenePlayer.Prepare(layerPreMatch, KAScene);
        }


        public void loadCoachName(string coachName, string logo)
        {
            string scene = Stitle;
            KAScene KAScene = KAEngine.LoadScene(scene, scene);
            Thread.Sleep(10);
            KAEngine.BeginTransaction();
            KAObject = KAScene.GetObject("name");
            KAObject.SetValue(coachName);
            KAObject = KAScene.GetObject("title");
            KAObject.SetValue("HUẤN LUYỆN VIÊN TRƯỞNG");
            KAObject = KAScene.GetObject("logo");
            KAObject.SetValue(logo);
            KAEngine.EndTransaction();
            Thread.Sleep(10);
            KAScenePlayer.Prepare(layerTSL, KAScene);
            Thread.Sleep(10);
            KAScenePlayer.Play(layerTSL);
        }

        public void PlayGoalClock(string name, string item, int layer)
        {
            string scene = SGoalClock;
            KAScene KAScene = KAEngine.LoadScene(scene, scene);
            Thread.Sleep(10);
            KAEngine.BeginTransaction();
            KAObject = KAScene.GetObject("name");
            KAObject.SetValue(name);

            KAObject = KAScene.GetObject("item");
            KAObject.SetValue(item);
            KAEngine.EndTransaction();
            Thread.Sleep(10);
            KAScenePlayer.Prepare(layer, KAScene);
            Thread.Sleep(10);
            KAScenePlayer.Play(layer);
        }

        public void loadYellowCard(string playerName, string logo)
        {
            string scene = SYellowCard;
            KAScene KAScene = KAEngine.LoadScene(scene, scene);
            Thread.Sleep(10);

            KAEngine.BeginTransaction();
            KAObject = KAScene.GetObject("name");
            KAObject.SetValue(playerName);
            KAObject = KAScene.GetObject("logo");
            KAObject.SetValue(logo);
            KAEngine.EndTransaction();

            Thread.Sleep(10);
            KAScenePlayer.Prepare(layerTSL, KAScene);
            Thread.Sleep(10);
            KAScenePlayer.Play(layerTSL);
        }

        public void loadTwoYellowCard(string playerName, string logo)
        {
            string scene = SSecondYellowCard;
            KAScene KAScene = KAEngine.LoadScene(scene, scene);

            Thread.Sleep(10);
            KAEngine.BeginTransaction();
            KAObject = KAScene.GetObject("name");
            KAObject.SetValue(playerName);
            KAObject = KAScene.GetObject("logo");
            KAObject.SetValue(logo);
            KAEngine.EndTransaction();

            Thread.Sleep(10);
            KAScenePlayer.Prepare(layerTSL, KAScene);
            Thread.Sleep(10);
            KAScenePlayer.Play(layerTSL);
        }
        public void loadRedCard(string playerName, string logo)
        {
            string scene = SRedCard;
            KAScene KAScene = KAEngine.LoadScene(scene, scene);

            Thread.Sleep(10);
            KAEngine.BeginTransaction();
            KAObject = KAScene.GetObject("name");
            KAObject.SetValue(playerName);
            KAObject = KAScene.GetObject("logo");
            KAObject.SetValue(logo);
            KAEngine.EndTransaction();

            Thread.Sleep(10);
            KAScenePlayer.Prepare(layerTSL, KAScene);
            Thread.Sleep(10);
            KAScenePlayer.Play(layerTSL);
        }

        //Play scene Tysohno 
        public void loadTSN(string homeCode, string awayCode, string homeScore, string awayScore, int startTime, int endTime)
        {
            string scene = SpermClock;
            KAScene KAScene = KAEngine.LoadScene(scene, scene);
            //Thread.Sleep(10);
            KAEngine.BeginTransaction();
            KAObject = KAScene.GetObject("Counter");
            KAObject.SetCounterRange(startTime, endTime);
            KAObject = KAScene.GetObject("home");
            KAObject.SetValue(homeCode);
            KAObject = KAScene.GetObject("tiso1");
            KAObject.SetValue(homeScore);
            KAObject = KAScene.GetObject("away");
            KAObject.SetValue(awayCode);
            KAObject = KAScene.GetObject("tiso2");
            KAObject.SetValue(awayScore);
            KAObject = KAScene.GetObject("colorhome");
            KAObject.SetFaceColor(TeamInfor.Player_HomeColor.R, TeamInfor.Player_HomeColor.G, TeamInfor.Player_HomeColor.B, 255);
            KAObject = KAScene.GetObject("coloraway");
            KAObject.SetFaceColor(TeamInfor.Player_AwayColor.R, TeamInfor.Player_AwayColor.G, TeamInfor.Player_AwayColor.B, 255);
            KAEngine.EndTransaction();
            //Thread.Sleep(10);
            KAScenePlayer.Prepare(layerTSN, KAScene);
            //Thread.Sleep(10);
            KAScenePlayer.Play(layerTSN);
        }
        public void loadTSNOut(string homeCode, string awayCode, string homeScore, string awayScore, int startTime, int endTime)
        {
            string scene = SpermClockOut;
            KAScene KAScene = KAEngine.LoadScene(scene, scene);
            //Thread.Sleep(10);
            KAEngine.BeginTransaction();
            //KAObject = KAScene.GetObject("Counter");
            //KAObject.SetCounterRange(startTime, endTime);
            KAObject = KAScene.GetObject("home");
            KAObject.SetValue(homeCode);
            KAObject = KAScene.GetObject("tiso1");
            KAObject.SetValue(homeScore);
            KAObject = KAScene.GetObject("away");
            KAObject.SetValue(awayCode);
            KAObject = KAScene.GetObject("tiso2");
            KAObject.SetValue(awayScore);
            KAObject = KAScene.GetObject("colorhome");
            KAObject.SetFaceColor(TeamInfor.Player_HomeColor.R, TeamInfor.Player_HomeColor.G, TeamInfor.Player_HomeColor.B, 255);
            KAObject = KAScene.GetObject("coloraway");
            KAObject.SetFaceColor(TeamInfor.Player_AwayColor.R, TeamInfor.Player_AwayColor.G, TeamInfor.Player_AwayColor.B, 255);
            KAEngine.EndTransaction();
            //Thread.Sleep(10);
            KAScenePlayer.Prepare(layerTSN, KAScene);
            //Thread.Sleep(10);
            KAScenePlayer.Play(layerTSN);
        }
        public void loadTSNGoal(string scene, string homeCode, string awayCode, string homeScore, string awayScore, int startTime, int endTime)
        {
            Static.UpdateScores(homeScore, awayScore);
            string workingPath = txtWorkingFolder.Text;
            string path = workingPath + "\\Scenes"+ scene;
            KAScene KAScene = KAEngine.LoadScene(path, scene);
            //Thread.Sleep(10);
            KAEngine.BeginTransaction();
            KAObject = KAScene.GetObject("Counter");
            KAObject.SetCounterRange(startTime, endTime);
            KAObject = KAScene.GetObject("home");
            KAObject.SetValue(homeCode);
            KAObject = KAScene.GetObject("home1");
            KAObject.SetValue(homeCode);
            KAObject = KAScene.GetObject("tiso1");
            KAObject.SetValue(homeScore);
            KAObject = KAScene.GetObject("away");
            KAObject.SetValue(awayCode);
            KAObject = KAScene.GetObject("away1");
            KAObject.SetValue(awayCode);
            KAObject = KAScene.GetObject("tiso2");
            KAObject.SetValue(awayScore);
            KAEngine.EndTransaction();
            //Thread.Sleep(10);
            KAScenePlayer.Prepare(layerTSN, KAScene);
            //Thread.Sleep(10);
            KAScenePlayer.Play(layerTSN);
        }
        public void loadTSNNoGoal(string scene, string checkghiban, string homeCode, string awayCode, string homeScore, string awayScore, int startTime, int endTime)
        {
            Static.UpdateScores(homeScore, awayScore);
            string workingPath = txtWorkingFolder.Text;
            string path = workingPath + "\\Scenes"+ scene;
            KAScene KAScene = KAEngine.LoadScene(path, scene);
            //Thread.Sleep(10);
            KAEngine.BeginTransaction();
            KAObject = KAScene.GetObject("Counter");
            KAObject.SetCounterRange(startTime, endTime);
            KAObject = KAScene.GetObject("checkghiban");
            KAObject.SetValue(checkghiban);
            KAObject = KAScene.GetObject("home");
            KAObject.SetValue(homeCode);
            KAObject = KAScene.GetObject("tiso1");
            KAObject.SetValue(homeScore);
            KAObject = KAScene.GetObject("away");
            KAObject.SetValue(awayCode);
            KAObject = KAScene.GetObject("tiso2");
            KAObject.SetValue(awayScore);
            KAEngine.EndTransaction();
            //Thread.Sleep(10);
            KAScenePlayer.Prepare(layerTSN, KAScene);
            //Thread.Sleep(10);
            KAScenePlayer.Play(layerTSN);
        }

        public void loadGoalInfo(string playerName, string logo, string minutes)
        {
            string scene = SGhiBan;
            KAScene KAScene = KAEngine.LoadScene(scene, scene);

            Thread.Sleep(10);
            KAEngine.BeginTransaction();
            KAObject = KAScene.GetObject("name");
            KAObject.SetValue(playerName + " " + minutes + "'");
            KAObject = KAScene.GetObject("logo");
            KAObject.SetValue(logo);

            KAEngine.EndTransaction();
            Thread.Sleep(10);
            KAScenePlayer.Prepare(layerTSL, KAScene);
            Thread.Sleep(10);
            KAScenePlayer.Play(layerTSL);
        }
        public void loadGoalPenInfo(string playerName, string logo, string minutes)
        {
            string scene = SGhiBan;
            KAScene KAScene = KAEngine.LoadScene(scene, scene);

            Thread.Sleep(10);
            KAEngine.BeginTransaction();
            KAObject = KAScene.GetObject("name");
            KAObject.SetValue(playerName + " " + minutes + "' (P)");
            KAObject = KAScene.GetObject("logo");
            KAObject.SetValue(logo);


            KAEngine.EndTransaction();
            Thread.Sleep(10);
            KAScenePlayer.Prepare(layerTSL, KAScene);
            Thread.Sleep(10);
            KAScenePlayer.Play(layerTSL);
        }
        public void loadOGInfo(string playerName, string logo, string minutes)
        {
            string scene = SGhiBan;
            KAScene KAScene = KAEngine.LoadScene(scene, scene);

            Thread.Sleep(10);
            KAEngine.BeginTransaction();
            KAObject = KAScene.GetObject("name");
            KAObject.SetValue(playerName + " " + minutes + "' (OG)");
            KAObject = KAScene.GetObject("logo");
            KAObject.SetValue(logo);
            KAEngine.EndTransaction();
            Thread.Sleep(10);
            KAScenePlayer.Prepare(layerTSL, KAScene);
            Thread.Sleep(10);
            KAScenePlayer.Play(layerTSL);
        }
        public void swapOnePlayer(string lineName,string subName, string lineNum, string subNum,
                string lineIMG, string subIMG, string logo)
        {
            string scene = SSub1;
            KAScene KAScene = KAEngine.LoadScene(scene, scene);
            Thread.Sleep(10);

            KAEngine.BeginTransaction();
            KAObject = KAScene.GetObject("nameout1");
            KAObject.SetValue(lineName);
            KAObject = KAScene.GetObject("namein1");
            KAObject.SetValue(subName);
            KAObject = KAScene.GetObject("numout1");
            KAObject.SetValue(lineNum);
            KAObject = KAScene.GetObject("numin1");
            KAObject.SetValue(subNum);
            KAObject = KAScene.GetObject("picout1");
            KAObject.SetValue(lineIMG);
            KAObject = KAScene.GetObject("picin1");
            KAObject.SetValue(subIMG);
            KAObject = KAScene.GetObject("logo");
            KAObject.SetValue(logo);
            KAEngine.EndTransaction();
            KAScenePlayer.Prepare(layerTSL, KAScene);
            Thread.Sleep(10);
            KAScenePlayer.Play(layerTSL);
        }

        //write swap two player
        public void swapTwoPlayer(string lineName, string subName, string lineNum, string subNum,
            string lineIMG, string subIMG, string lineName2, string subName2, string lineNum2, string subNum2,
            string lineIMG2, string subIMG2, string logo)
        {
            string scene = SSub2;
            KAScene KAScene = KAEngine.LoadScene(scene, scene);
            Thread.Sleep(10);
            KAEngine.BeginTransaction();
            KAObject = KAScene.GetObject("nameout1");
            KAObject.SetValue(lineName);
            KAObject = KAScene.GetObject("namein1");
            KAObject.SetValue(subName);
            KAObject = KAScene.GetObject("numout1");
            KAObject.SetValue(lineNum);
            KAObject = KAScene.GetObject("numin1");
            KAObject.SetValue(subNum);
            KAObject = KAScene.GetObject("picout1");
            KAObject.SetValue(lineIMG);
            KAObject = KAScene.GetObject("picin1");
            KAObject.SetValue(subIMG);
            KAObject = KAScene.GetObject("nameout2");
            KAObject.SetValue(lineName2);
            KAObject = KAScene.GetObject("namein2");
            KAObject.SetValue(subName2);
            KAObject = KAScene.GetObject("numout2");
            KAObject.SetValue(lineNum2);
            KAObject = KAScene.GetObject("numin2");
            KAObject.SetValue(subNum2);
            KAObject = KAScene.GetObject("picout2");
            KAObject.SetValue(lineIMG2);
            KAObject = KAScene.GetObject("picin2");
            KAObject.SetValue(subIMG2);
            KAObject = KAScene.GetObject("logo");
            KAObject.SetValue(logo);
            KAEngine.EndTransaction();
            KAScenePlayer.Prepare(layerTSL, KAScene);
            Thread.Sleep(10);
            KAScenePlayer.Play(layerTSL);
        }
        //write swap three player
        public void swapThreePlayer(string lineName, string subName, string lineNum, string subNum,
            string lineIMG, string subIMG, string lineName2, string subName2, string lineNum2, string subNum2,
            string lineIMG2, string subIMG2, string lineName3, string subName3, string lineNum3, string subNum3,
            string lineIMG3, string subIMG3, string logo)
        {
            string scene = SSub3;
            KAScene KAScene = KAEngine.LoadScene(scene, scene);
            Thread.Sleep(10);
            KAEngine.BeginTransaction();
            KAObject = KAScene.GetObject("nameout1");
            KAObject.SetValue(lineName);
            KAObject = KAScene.GetObject("namein1");
            KAObject.SetValue(subName);
            KAObject = KAScene.GetObject("numout1");
            KAObject.SetValue(lineNum);
            KAObject = KAScene.GetObject("numin1");
            KAObject.SetValue(subNum);
            KAObject = KAScene.GetObject("picout1");
            KAObject.SetValue(lineIMG);
            KAObject = KAScene.GetObject("picin1");
            KAObject.SetValue(subIMG);
            KAObject = KAScene.GetObject("nameout2");
            KAObject.SetValue(lineName2);
            KAObject = KAScene.GetObject("namein2");
            KAObject.SetValue(subName2);
            KAObject = KAScene.GetObject("numout2");
            KAObject.SetValue(lineNum2);
            KAObject = KAScene.GetObject("numin2");
            KAObject.SetValue(subNum2);
            KAObject = KAScene.GetObject("picout2");
            KAObject.SetValue(lineIMG2);
            KAObject = KAScene.GetObject("picin2");
            KAObject.SetValue(subIMG2);
            KAObject = KAScene.GetObject("nameout3");
            KAObject.SetValue(lineName3);
            KAObject = KAScene.GetObject("namein3");
            KAObject.SetValue(subName3);
            KAObject = KAScene.GetObject("numout3");
            KAObject.SetValue(lineNum3);
            KAObject = KAScene.GetObject("numin3");
            KAObject.SetValue(subNum3);
            KAObject = KAScene.GetObject("picout3");
            KAObject.SetValue(lineIMG3);
            KAObject = KAScene.GetObject("picin3");
            KAObject.SetValue(subIMG3);
            KAObject = KAScene.GetObject("logo");
            KAObject.SetValue(logo);
            KAEngine.EndTransaction();
            KAScenePlayer.Prepare(layerTSL, KAScene);
            Thread.Sleep(10);
            KAScenePlayer.Play(layerTSL);
        }

        public void loadReferre(string mainReferee, string referreOne, string refereeTwo, string referreThree)
        {
            string scene = SmatchOff;
            KAScene KAScene = KAEngine.LoadScene(scene, scene);
            Thread.Sleep(10);
            KAEngine.BeginTransaction();
            Thread.Sleep(10);
            KAObject = KAScene.GetObject("tt1");
            KAObject.SetValue(mainReferee);
            KAObject = KAScene.GetObject("tt2");
            KAObject.SetValue(referreOne);
            KAObject = KAScene.GetObject("tt3");
            KAObject.SetValue(refereeTwo);
            KAObject = KAScene.GetObject("tt4");
            KAObject.SetValue(referreThree);
            KAEngine.EndTransaction();
            Thread.Sleep(10);
            KAScenePlayer.Prepare(layerPreMatch, KAScene);
            Thread.Sleep(10);
            KAScenePlayer.Play(layerPreMatch);
        }
        public void loadVarReferee(string varRefereeOne, string varRefereeTwo)
        {
            string scene = SvarOff;
            KAScene KAScene = KAEngine.LoadScene(scene, scene);
            Thread.Sleep(10);
            KAEngine.BeginTransaction();
            Thread.Sleep(10);
            KAObject = KAScene.GetObject("tt1");
            KAObject.SetValue(varRefereeOne);
            KAObject = KAScene.GetObject("tt2");
            KAObject.SetValue(varRefereeTwo);
            KAEngine.EndTransaction();
            Thread.Sleep(10);
            KAScenePlayer.Prepare(layerPreMatch, KAScene);
            Thread.Sleep(10);
            KAScenePlayer.Play(layerPreMatch);
        }
        public void varChecking(string text)
        {
            string scene = SBarVar;
            KAScene KAScene = KAEngine.LoadScene(scene, scene);
            Thread.Sleep(10);
            KAEngine.BeginTransaction();
            KAObject = KAScene.GetObject("text");
            KAObject.SetValue(text);
            KAEngine.EndTransaction();
            Thread.Sleep(10);
            KAScenePlayer.Prepare(layerTSL, KAScene);
            Thread.Sleep(10);
            KAScenePlayer.Play(layerTSL);
        }
        public void varUpdate(string text1, string text2)
        {
            string scene = SDecisionVar;
            KAScene KAScene = KAEngine.LoadScene(scene, scene);
            Thread.Sleep(10);
            KAEngine.BeginTransaction();
            KAObject = KAScene.GetObject("text");
            KAObject.SetValue(text1);
            KAObject = KAScene.GetObject("text2");
            KAObject.SetValue(text2);
            KAEngine.EndTransaction();
            Thread.Sleep(10);
            KAScenePlayer.Prepare(layerTSL, KAScene);
            Thread.Sleep(10);
            KAScenePlayer.Play(layerTSL);
        }

        public void loadDisplayAddtime(string time)
        {

            string scene = SaddTime;
            KAScene KAScene = KAEngine.LoadScene(scene, scene);

            KAEngine.BeginTransaction();
            KAObject = KAScene.GetObject("bugio");
            KAObject.SetValue("+" + time);
            KAEngine.EndTransaction();
            Thread.Sleep(10);
            KAScenePlayer.Prepare(layerBuGio, KAScene);
            Thread.Sleep(10);
            KAScenePlayer.Play(layerBuGio);
        }

        public void loadKickOffTime(string homeName, string awayName, string scoreHome, string scoreAway,
    string homeLogo, string awayLogo, int startTime, int endTime)
        {
            string scene = SkickoffTime;
            KAScene KAScene = KAEngine.LoadScene(scene, scene);
            Thread.Sleep(10);
            KAEngine.BeginTransaction();
            KAObject = KAScene.GetObject("home");
            KAObject.SetValue(homeName);
            KAObject = KAScene.GetObject("away");
            KAObject.SetValue(awayName);
            KAObject = KAScene.GetObject("tiso1");
            KAObject.SetValue(scoreHome);
            KAObject = KAScene.GetObject("tiso2");
            KAObject.SetValue(scoreAway);
            KAObject = KAScene.GetObject("logohome");
            KAObject.SetValue(homeLogo);
            KAObject = KAScene.GetObject("logoaway");
            KAObject.SetValue(awayLogo);
            KAObject = KAScene.GetObject("Counter");
            KAObject.SetOpacity(255);
            KAObject.SetCounterRange(startTime, endTime);
            KAEngine.EndTransaction();
            Thread.Sleep(10);
            KAScenePlayer.Prepare(layerTSL, KAScene);
            Thread.Sleep(10);
            KAScenePlayer.Play(layerTSL);
        }
        public void loadKickOffTimeOut(string homeName, string awayName, string scoreHome, string scoreAway,
string homeLogo, string awayLogo, float startTime, int endTime)
        {
            string scene = SkickoffTimeOut;
            KAScene KAScene = KAEngine.LoadScene(scene, scene);
            Thread.Sleep(10);
            KAEngine.BeginTransaction();
            KAObject = KAScene.GetObject("home");
            KAObject.SetValue(homeName);
            KAObject = KAScene.GetObject("away");
            KAObject.SetValue(awayName);
            KAObject = KAScene.GetObject("tiso1");
            KAObject.SetValue(scoreHome);
            KAObject = KAScene.GetObject("tiso2");
            KAObject.SetValue(scoreAway);
            KAObject = KAScene.GetObject("logohome");
            KAObject.SetValue(homeLogo);
            KAObject = KAScene.GetObject("logoaway");
            KAObject.SetValue(awayLogo);
            KAObject = KAScene.GetObject("Counter");
            KAObject.SetCounterRange(startTime, endTime);
            KAEngine.EndTransaction();
            Thread.Sleep(10);
            KAScenePlayer.Prepare(layerTSL, KAScene);
            Thread.Sleep(10);
            KAScenePlayer.Play(layerTSL);
        }
        public void loadLTPenalty(string homeName, string awayName, string scoreHome, string scoreAway,
string homeLogo, string awayLogo, string match, string goalhome1, string goalhome2, string goalaway1, string goalaway2)
        {
            string scene = "\\ltpenalty.t2s";
            string workingPath = txtWorkingFolder.Text;
            string path = workingPath + "\\Scenes" + scene;
            KAScene KAScene = KAEngine.LoadScene(path, scene);
            Thread.Sleep(10);
            KAEngine.BeginTransaction();
            KAObject = KAScene.GetObject("home");
            KAObject.SetValue(homeName);
            KAObject = KAScene.GetObject("away");
            KAObject.SetValue(awayName);
            KAObject = KAScene.GetObject("tiso1");
            KAObject.SetValue(scoreHome);
            KAObject = KAScene.GetObject("tiso2");
            KAObject.SetValue(scoreAway);
            KAObject = KAScene.GetObject("homeghiban");
            KAObject.SetValue(goalhome1);
            KAObject = KAScene.GetObject("awayghiban");
            KAObject.SetValue(goalaway1);
            KAObject = KAScene.GetObject("homeghiban2");
            KAObject.SetValue(goalhome2);
            KAObject = KAScene.GetObject("awayghiban2");
            KAObject.SetValue(goalaway2);
            KAObject = KAScene.GetObject("logohome");
            KAObject.SetValue(homeLogo);
            KAObject = KAScene.GetObject("logoaway");
            KAObject.SetValue(awayLogo);
            KAObject = KAScene.GetObject("text");
            KAObject.SetValue(match);
            KAEngine.EndTransaction();
            Thread.Sleep(10);
            KAScenePlayer.Prepare(layerTSL, KAScene);
            Thread.Sleep(10);
            KAScenePlayer.Play(layerTSL);
        }

        public void PlayKickOff1Line(string homeName, string awayName, string scoreHome, string scoreAway,
string homeLogo, string awayLogo, string match, string goalhome1, string goalaway1)
        {
            string scene = SkickOff;
            KAScene KAScene = KAEngine.LoadScene(scene, scene);
            Thread.Sleep(10);
            KAEngine.BeginTransaction();
            KAObject = KAScene.GetObject("home");
            KAObject.SetValue(homeName);
            KAObject = KAScene.GetObject("away");
            KAObject.SetValue(awayName);
            KAObject = KAScene.GetObject("tiso1");
            KAObject.SetValue(scoreHome);
            KAObject = KAScene.GetObject("tiso2");
            KAObject.SetValue(scoreAway);
            KAObject = KAScene.GetObject("homeghiban");
            KAObject.SetValue(goalhome1);
            KAObject = KAScene.GetObject("awayghiban");
            KAObject.SetValue(goalaway1);
            KAObject = KAScene.GetObject("logohome");
            KAObject.SetValue(homeLogo);
            KAObject = KAScene.GetObject("logoaway");
            KAObject.SetValue(awayLogo);
            KAObject = KAScene.GetObject("text");
            KAObject.SetValue(match);
            KAEngine.EndTransaction();
            Thread.Sleep(10);
            KAScenePlayer.Prepare(layerTSL, KAScene);
            Thread.Sleep(10);
            KAScenePlayer.Play(layerTSL);
        }

        public void PlayKickOff2Lines(string homeName, string awayName, string scoreHome, string scoreAway,
string homeLogo, string awayLogo, string match, string goalhome1, string goalaway1, string goalhome2, string goalaway2)
        {
            string scene = SkickOff2;
            KAScene KAScene = KAEngine.LoadScene(scene, scene);
            Thread.Sleep(10);
            KAEngine.BeginTransaction();
            KAObject = KAScene.GetObject("home");
            KAObject.SetValue(homeName);
            KAObject = KAScene.GetObject("away");
            KAObject.SetValue(awayName);
            KAObject = KAScene.GetObject("tiso1");
            KAObject.SetValue(scoreHome);
            KAObject = KAScene.GetObject("tiso2");
            KAObject.SetValue(scoreAway);
            KAObject = KAScene.GetObject("homeghiban");
            KAObject.SetValue(goalhome1);
            KAObject = KAScene.GetObject("awayghiban");
            KAObject.SetValue(goalaway1);
            KAObject = KAScene.GetObject("homeghiban2");
            KAObject.SetValue(goalhome2);
            KAObject = KAScene.GetObject("awayghiban2");
            KAObject.SetValue(goalaway2);
            KAObject = KAScene.GetObject("logohome");
            KAObject.SetValue(homeLogo);
            KAObject = KAScene.GetObject("logoaway");
            KAObject.SetValue(awayLogo);
            KAObject = KAScene.GetObject("text");
            KAObject.SetValue(match);
            KAEngine.EndTransaction();
            Thread.Sleep(10);
            KAScenePlayer.Prepare(layerTSL, KAScene);
            Thread.Sleep(10);
            KAScenePlayer.Play(layerTSL);
        }





        public void loadKickOffGoal(string homeName, string awayName, string scoreHome, string scoreAway,
string homeLogo, string awayLogo, string match, string goalhome1, string goalhome2, string goalaway1, string goalaway2)
        {
            string scene = "\\kickoff.t2s";
            string workingPath = txtWorkingFolder.Text;
            string path = workingPath + "\\Scenes"+ scene;
            KAScene KAScene = KAEngine.LoadScene(path, scene);
            Thread.Sleep(10);
            KAEngine.BeginTransaction();
            KAObject = KAScene.GetObject("home");
            KAObject.SetValue(homeName);
            KAObject = KAScene.GetObject("away");
            KAObject.SetValue(awayName);
            KAObject = KAScene.GetObject("tiso1");
            KAObject.SetValue(scoreHome);
            KAObject = KAScene.GetObject("tiso2");
            KAObject.SetValue(scoreAway);
            KAObject = KAScene.GetObject("homeghiban");
            KAObject.SetValue(goalhome1);
            KAObject = KAScene.GetObject("awayghiban");
            KAObject.SetValue(goalaway1);
            KAObject = KAScene.GetObject("homeghiban2");
            KAObject.SetValue(goalhome2);
            KAObject = KAScene.GetObject("awayghiban2");
            KAObject.SetValue(goalaway2);
            KAObject = KAScene.GetObject("logohome");
            KAObject.SetValue(homeLogo);
            KAObject = KAScene.GetObject("logoaway");
            KAObject.SetValue(awayLogo);
            KAObject = KAScene.GetObject("text");
            KAObject.SetValue(match);
            KAEngine.EndTransaction();
            Thread.Sleep(10);
            KAScenePlayer.Prepare(layerTSL, KAScene);
            Thread.Sleep(10);
            KAScenePlayer.Play(layerTSL);
        }
        public void loadTimeLowerThird(string homeName, string awayName, string scoreHome, string scoreAway,
string homeLogo, string awayLogo, string goalhome1, string goalhome2, string goalaway1, string goalaway2, int startTime, int endTime)
        {
            string scene = "\\kickofftime.t2s";
            string workingPath = txtWorkingFolder.Text;
            string path = workingPath + "\\Scenes" + scene;
            KAScene KAScene = KAEngine.LoadScene(path, scene);
            //Thread.Sleep(10);
            KAEngine.BeginTransaction();
            KAObject = KAScene.GetObject("home");
            KAObject.SetValue(homeName);
            KAObject = KAScene.GetObject("away");
            KAObject.SetValue(awayName);
            KAObject = KAScene.GetObject("tiso1");
            KAObject.SetValue(scoreHome);
            KAObject = KAScene.GetObject("tiso2");
            KAObject.SetValue(scoreAway);
            KAObject = KAScene.GetObject("homeghiban");
            KAObject.SetValue(goalhome1);
            KAObject = KAScene.GetObject("awayghiban");
            KAObject.SetValue(goalaway1);
            KAObject = KAScene.GetObject("homeghiban2");
            KAObject.SetValue(goalhome2);
            KAObject = KAScene.GetObject("awayghiban2");
            KAObject.SetValue(goalaway2);
            KAObject = KAScene.GetObject("logohome");
            KAObject.SetValue(homeLogo);
            KAObject = KAScene.GetObject("logoaway");
            KAObject.SetValue(awayLogo);
            KAObject = KAScene.GetObject("Counter");
            KAObject.SetOpacity(0);
            KAEngine.EndTransaction();
            //Thread.Sleep(10);
            KAScenePlayer.Prepare(layerTSL, KAScene);
            //Thread.Sleep(10);
            KAScenePlayer.Play(layerTSL);
        }
        public void loadTimeLowerThirdOut(string homeName, string awayName, string scoreHome, string scoreAway,
string homeLogo, string awayLogo, string goalhome1, string goalhome2, string goalaway1, string goalaway2, int startTime, int endTime)
        {
            string scene = "\\kickofftimeout.t2s";
            string workingPath = txtWorkingFolder.Text;
            string path = workingPath + "\\Scenes"+ scene;
            KAScene KAScene = KAEngine.LoadScene(path, scene);
            //Thread.Sleep(10);
            KAEngine.BeginTransaction();
            KAObject = KAScene.GetObject("home");
            KAObject.SetValue(homeName);
            KAObject = KAScene.GetObject("away");
            KAObject.SetValue(awayName);
            KAObject = KAScene.GetObject("tiso1");
            KAObject.SetValue(scoreHome);
            KAObject = KAScene.GetObject("tiso2");
            KAObject.SetValue(scoreAway);
            KAObject = KAScene.GetObject("homeghiban");
            KAObject.SetValue(goalhome1);
            KAObject = KAScene.GetObject("awayghiban");
            KAObject.SetValue(goalaway1);
            KAObject = KAScene.GetObject("homeghiban2");
            KAObject.SetValue(goalhome2);
            KAObject = KAScene.GetObject("awayghiban2");
            KAObject.SetValue(goalaway2);
            KAObject = KAScene.GetObject("logohome");
            KAObject.SetValue(homeLogo);
            KAObject = KAScene.GetObject("logoaway");
            KAObject.SetValue(awayLogo);
            KAObject = KAScene.GetObject("Counter");
            KAObject.SetOpacity(0);
            KAEngine.EndTransaction();
            //Thread.Sleep(10);
            KAScenePlayer.Prepare(layerTSL, KAScene);
            //Thread.Sleep(10);
            KAScenePlayer.Play(layerTSL);
        }
        public void stopTimeLowerThird(string homeName, string awayName, string scoreHome, string scoreAway,
string homeLogo, string awayLogo, string goalhome1, string goalaway1, int startTime, int endTime)
        {
            string scene = "tysoout.t2s";
            string workingPath = txtWorkingFolder.Text;
            string path = workingPath + "\\Scenes"+ scene;
            KAScene KAScene = KAEngine.LoadScene(path, scene);
            //Thread.Sleep(10);
            KAEngine.BeginTransaction();
            KAObject = KAScene.GetObject("home");
            KAObject.SetValue(homeName);
            KAObject = KAScene.GetObject("away");
            KAObject.SetValue(awayName);
            KAObject = KAScene.GetObject("tiso1");
            KAObject.SetValue(scoreHome);
            KAObject = KAScene.GetObject("tiso2");
            KAObject.SetValue(scoreAway);
            KAObject = KAScene.GetObject("goalhome1");
            KAObject.SetValue(goalhome1);
            KAObject = KAScene.GetObject("goalaway1");
            KAObject.SetValue(goalaway1);
            KAObject = KAScene.GetObject("logohome");
            KAObject.SetValue(workingPath + homeLogo);
            KAObject = KAScene.GetObject("logoaway");
            KAObject.SetValue(workingPath + awayLogo);
            KAObject = KAScene.GetObject("Counter");
            KAObject.SetCounterRange(startTime, endTime);
            KAEngine.EndTransaction();
            //Thread.Sleep(10);
            KAScenePlayer.Prepare(layerTSL, KAScene);
            //Thread.Sleep(10);
            KAScenePlayer.Play(layerTSL);
        }

        public void loadBarScene(string name, string title)
        {
            string scene = SBar;
            KAScene KAScene = KAEngine.LoadScene(scene, scene);
            Thread.Sleep(10);
            KAEngine.BeginTransaction();
            KAObject = KAScene.GetObject("name");
            KAObject.SetValue(name);
            KAObject = KAScene.GetObject("title");
            KAObject.SetValue(title);

            KAEngine.EndTransaction();
            Thread.Sleep(10);
            KAScenePlayer.Prepare(layerTSL, KAScene);
            Thread.Sleep(10);
            KAScenePlayer.Play(layerTSL);
        }
        public void loadTitleScene(string name, string title)
        {
            string scene = SBar;
            KAScene KAScene = KAEngine.LoadScene(scene, scene);
            Thread.Sleep(10);
            KAEngine.BeginTransaction();
            KAObject = KAScene.GetObject("name");
            KAObject.SetValue(name);
            KAObject = KAScene.GetObject("title");
            KAObject.SetValue(title);

            KAEngine.EndTransaction();
            Thread.Sleep(10);
            KAScenePlayer.Prepare(layerTSL, KAScene);
            Thread.Sleep(10);
            KAScenePlayer.Play(layerTSL);
        }
        public void loadKickOffOut(string homeName, string awayName, string scoreHome, string scoreAway,
            string homeLogo, string awayLogo, string match)
        {
            string scene = "kickoffout.t2s";
            string workingPath = txtWorkingFolder.Text;
            string path = workingPath + "\\Scenes"+ scene;
            KAScene KAScene = KAEngine.LoadScene(path, scene);
            Thread.Sleep(100);
            KAEngine.BeginTransaction();
            KAObject = KAScene.GetObject("home");
            KAObject.SetValue(homeName);
            KAObject = KAScene.GetObject("away");
            KAObject.SetValue(awayName);
            KAObject = KAScene.GetObject("tiso1");
            KAObject.SetValue(scoreHome);
            KAObject = KAScene.GetObject("tiso2");
            KAObject.SetValue(scoreAway);
            KAObject = KAScene.GetObject("logohome");
            KAObject.SetValue(workingPath + homeLogo);
            KAObject = KAScene.GetObject("logoaway");
            KAObject.SetValue(workingPath + awayLogo);
            KAObject = KAScene.GetObject("hiepdau");
            KAObject.SetValue(match);
            KAEngine.EndTransaction();
            Thread.Sleep(100);
            KAScenePlayer.Prepare(layerTSL, KAScene);
            Thread.Sleep(100);
            KAScenePlayer.Play(layerTSL);
        }

        public void loadBackGround()
        {
            KAScene KAScene = KAEngine.LoadScene(Sbackground, Sbackground);

            KAScenePlayer.Prepare(layerBackground, KAScene);
            Thread.Sleep(10);
            KAScenePlayer.Play(layerBackground);
        }

        public void loadVarGrid()
        {
            KAScene KAScene = KAEngine.LoadScene(SVarGrid, SVarGrid);

            KAScenePlayer.Prepare(0, KAScene);
            Thread.Sleep(10);
            KAScenePlayer.Play(0);
        }


        public void loadScene(string scene)
        {
            KAEngine.UnloadAll();
            string workingPath = txtWorkingFolder.Text;
            string path = workingPath + "\\Scenes"+ scene;
            KAScene KAScene = KAEngine.LoadScene(path, scene);

            KAScenePlayer.Prepare(layerPreMatch, KAScene);
            KAScenePlayer.Play(layerPreMatch);
        }
        public void loadSponsor(string sponsor)
        {
            string scene = sponsor;
            string workingPath = txtWorkingFolder.Text;
            string path = workingPath + "\\Scenes"+ scene;
            KAScene KAScene = KAEngine.LoadScene(path, scene);
            Thread.Sleep(10);
            KAScenePlayer.Prepare(layerTSL, KAScene);
            Thread.Sleep(10);
            KAScenePlayer.Play(layerTSL);
        }
        public void loadCupQG(string link)
        {
            string scene = "\\KQCupQG.t2s";
            string workingPath = txtWorkingFolder.Text;
            string path = workingPath + "\\Scenes"+ scene;
            KAScene KAScene = KAEngine.LoadScene(path, scene);
            Thread.Sleep(10);
            KAEngine.BeginTransaction();
            KAObject = KAScene.GetObject("link");
            KAObject.SetValue(link);
            KAEngine.EndTransaction();
            KAScenePlayer.Prepare(layerPreMatch, KAScene);
            Thread.Sleep(10);
            KAScenePlayer.Play(layerPreMatch);
        }

        public void loadStatistic(string title, string homeIndex, string awayIndex, string homeCode, string awayCode)
        {
            string scene = SThongke1;
            KAScene KAScene = KAEngine.LoadScene(scene, scene);
            Thread.Sleep(10);
            KAEngine.BeginTransaction();
            KAObject = KAScene.GetObject("thongke1");
            KAObject.SetValue(title);
            KAObject = KAScene.GetObject("home1");
            KAObject.SetValue(homeIndex);
            KAObject = KAScene.GetObject("away1");
            KAObject.SetValue(awayIndex);
            KAObject = KAScene.GetObject("home");
            KAObject.SetValue(homeCode);
            KAObject = KAScene.GetObject("away");
            KAObject.SetValue(awayCode);
            KAEngine.EndTransaction();
            KAScenePlayer.Prepare(layerTSL, KAScene);
            Thread.Sleep(10);
            KAScenePlayer.Play(layerTSL);
        }

        public void loadStatistic2(string title, string homeIndex, string awayIndex, 
            string title2, string homeIndex2, string awayIndex2, string homeCode, string awayCode)
        {
            string scene = SThongke2;
            KAScene KAScene = KAEngine.LoadScene(scene, scene);
            Thread.Sleep(10);
            KAEngine.BeginTransaction();
            KAObject = KAScene.GetObject("thongke1");
            KAObject.SetValue(title);
            KAObject = KAScene.GetObject("home1");
            KAObject.SetValue(homeIndex);
            KAObject = KAScene.GetObject("away1");
            KAObject.SetValue(awayIndex);
            KAObject = KAScene.GetObject("thongke2");
            KAObject.SetValue(title2);
            KAObject = KAScene.GetObject("home2");
            KAObject.SetValue(homeIndex2);
            KAObject = KAScene.GetObject("away2");
            KAObject.SetValue(awayIndex2);
            KAObject = KAScene.GetObject("home");
            KAObject.SetValue(homeCode);
            KAObject = KAScene.GetObject("away");
            KAObject.SetValue(awayCode);
            KAEngine.EndTransaction();
            KAScenePlayer.Prepare(layerTSL, KAScene);
            Thread.Sleep(10);
            KAScenePlayer.Play(layerTSL);
        }
        public void loadStatistic3(string title, string homeIndex, string awayIndex,
    string title2, string homeIndex2, string awayIndex2,
    string title3, string homeIndex3, string awayIndex3, string homeCode, string awayCode)
        {
            string scene = SThongke3;
            KAScene KAScene = KAEngine.LoadScene(scene, scene);

            Thread.Sleep(10);
            KAEngine.BeginTransaction();
            KAObject = KAScene.GetObject("thongke1");
            KAObject.SetValue(title);
            KAObject = KAScene.GetObject("home1");
            KAObject.SetValue(homeIndex);
            KAObject = KAScene.GetObject("away1");
            KAObject.SetValue(awayIndex);
            KAObject = KAScene.GetObject("thongke2");
            KAObject.SetValue(title2);
            KAObject = KAScene.GetObject("home2");
            KAObject.SetValue(homeIndex2);
            KAObject = KAScene.GetObject("away2");
            KAObject.SetValue(awayIndex2);
            KAObject = KAScene.GetObject("thongke3");
            KAObject.SetValue(title3);
            KAObject = KAScene.GetObject("home3");
            KAObject.SetValue(homeIndex3);
            KAObject = KAScene.GetObject("away3");
            KAObject.SetValue(awayIndex3);
            KAObject = KAScene.GetObject("home");
            KAObject.SetValue(homeCode);
            KAObject = KAScene.GetObject("away");
            KAObject.SetValue(awayCode);
            KAEngine.EndTransaction();
            KAScenePlayer.Prepare(layerTSL, KAScene);
            Thread.Sleep(10);
            KAScenePlayer.Play(layerTSL);
        }
        public void loadStatistic5(string title, string homeIndex, string awayIndex,
string title2, string homeIndex2, string awayIndex2,
string title3, string homeIndex3, string awayIndex3,
string title4, string homeIndex4, string awayIndex4,
string title5, string homeIndex5, string awayIndex5, string homeCode, string awayCode)
        {
            string scene = "\\thongke5.t2s";
            string workingPath = txtWorkingFolder.Text;
            string path = workingPath + "\\Scenes" + scene;
            KAScene KAScene = KAEngine.LoadScene(path, scene);
            Thread.Sleep(100);
            KAEngine.BeginTransaction();
            KAObject = KAScene.GetObject("thongke1");
            KAObject.SetValue(title);
            KAObject = KAScene.GetObject("home1");
            KAObject.SetValue(homeIndex);
            KAObject = KAScene.GetObject("away1");
            KAObject.SetValue(awayIndex);
            KAObject = KAScene.GetObject("thongke2");
            KAObject.SetValue(title2);
            KAObject = KAScene.GetObject("home2");
            KAObject.SetValue(homeIndex2);
            KAObject = KAScene.GetObject("away2");
            KAObject.SetValue(awayIndex2);
            KAObject = KAScene.GetObject("thongke3");
            KAObject.SetValue(title3);
            KAObject = KAScene.GetObject("home3");
            KAObject.SetValue(homeIndex3);
            KAObject = KAScene.GetObject("away3");
            KAObject.SetValue(awayIndex3);
            KAObject = KAScene.GetObject("thongke4");
            KAObject.SetValue(title4);
            KAObject = KAScene.GetObject("home4");
            KAObject.SetValue(homeIndex4);
            KAObject = KAScene.GetObject("away4");
            KAObject.SetValue(awayIndex4);
            KAObject = KAScene.GetObject("thongke5");
            KAObject.SetValue(title5);
            KAObject = KAScene.GetObject("home5");
            KAObject.SetValue(homeIndex5);
            KAObject = KAScene.GetObject("away5");
            KAObject.SetValue(awayIndex5);
            KAObject = KAScene.GetObject("home");
            KAObject.SetValue(homeCode);
            KAObject = KAScene.GetObject("away");
            KAObject.SetValue(awayCode);
            KAEngine.EndTransaction();
            KAScenePlayer.Prepare(layerTSL, KAScene);
            Thread.Sleep(10);
            KAScenePlayer.Play(layerTSL);
        }
        public void loadAllStatistic(string match, string homelogo, string awaylogo, string homeScore,
            string awayScore, string homeName, string awayName)
        {
            DBConfig.goGetMatchInfoDetail();
            int index = 0;
            string scene = Sthongke;
            KAScene KAScene = KAEngine.LoadScene(scene, scene);
            Thread.Sleep(10);
            KAEngine.BeginTransaction();
            foreach (DataRow dt in DBConfig.matchDetail.Tables[0].Rows)
            {
                index++;
                string tieude = "thongke" + index;
                string chisohome = "home" + index;
                string chisoaway = "away" + index;
                string value = dt["Tieude"].ToString();
                string valueHome = dt["ChiSo1"].ToString();
                string valueAway = dt["ChiSo2"].ToString();
                KAObject = KAScene.GetObject(tieude);
                KAObject.SetValue(value);
                KAObject = KAScene.GetObject(chisohome);
                KAObject.SetValue(valueHome);
                KAObject = KAScene.GetObject(chisoaway);
                KAObject.SetValue(valueAway);

            }
            KAObject = KAScene.GetObject("hiepdau");
            KAObject.SetValue(match);
            KAObject = KAScene.GetObject("logo1");
            KAObject.SetValue(homelogo);
            KAObject = KAScene.GetObject("logo2");
            KAObject.SetValue(awaylogo);
            KAObject = KAScene.GetObject("tiso");
            KAObject.SetValue(homeScore + " - " + awayScore);
            KAObject = KAScene.GetObject("homename");
            KAObject.SetValue(homeName);
            KAObject = KAScene.GetObject("awayname");
            KAObject.SetValue(awayName);

            KAEngine.EndTransaction();
            KAScenePlayer.Prepare(layerPostMatch, KAScene);
            Thread.Sleep(10);
            KAScenePlayer.Play(layerPostMatch);
        }
        public void loadStatisticPen(string penalty, string match, string homeLogo, string awayLogo, string homeScore,
    string awayScore, string homeLongName, string awayLongName)
        {
            DBConfig.goGetMatchInfoDetail();
            int index = 0;
            string scene = "thongkechung.t2s";
            string workingPath = txtWorkingFolder.Text;
            string path = workingPath + "\\Scenes"+ scene;
            KAScene KAScene = KAEngine.LoadScene(path, scene);
            Thread.Sleep(10);
            KAEngine.BeginTransaction();
            foreach (DataRow dt in DBConfig.matchDetail.Tables[0].Rows)
            {
                index++;
                string tieude = "tieude" + index;
                string chisohome = "chisohome" + index;
                string chisoaway = "chisoaway" + index;
                string value = dt["Tieude"].ToString();
                string valueHome = dt["ChiSo1"].ToString();
                string valueAway = dt["ChiSo2"].ToString();
                KAObject = KAScene.GetObject(tieude);
                KAObject.SetValue(value);
                KAObject = KAScene.GetObject(chisohome);
                KAObject.SetValue(valueHome);
                KAObject = KAScene.GetObject(chisoaway);
                KAObject.SetValue(valueAway);
            }
            KAObject = KAScene.GetObject("hiepdau");
            KAObject.SetValue(match);
            KAObject = KAScene.GetObject("logo1");
            KAObject.SetValue(workingPath + homeLogo);
            KAObject = KAScene.GetObject("logo2");
            KAObject.SetValue(workingPath + awayLogo);
            KAObject = KAScene.GetObject("tiso1");
            KAObject.SetValue(homeScore);
            KAObject = KAScene.GetObject("tiso2");
            KAObject.SetValue(awayScore);
            KAObject = KAScene.GetObject("tendai1");
            KAObject.SetValue(homeLongName);
            KAObject = KAScene.GetObject("tendai2");
            KAObject.SetValue(awayLongName);
            KAObject = KAScene.GetObject("penaltycg");
            KAObject.SetVisible(100);
            KAObject = KAScene.GetObject("tysopen");
            KAObject.SetValue(penalty);

            KAEngine.EndTransaction();
            KAScenePlayer.Prepare(layerTSL, KAScene);
            Thread.Sleep(10);
            KAScenePlayer.Play(layerTSL);
        }
        public void loadRankingListSevenTeam(string[] team, string[] diem, string[] tran,
    string[] thang, string[] bai, string[] hoa, string[] heso)
        {
            string scene = "BXH1.t2s";
            string workingPath = txtWorkingFolder.Text;
            string path = workingPath + "\\Scenes"+ scene;
            KAScene KAScene = KAEngine.LoadScene(path, scene);
            Thread.Sleep(50);
            KAEngine.BeginTransaction();

            // Arrays of prefixes and data arrays to iterate over
            string[] prefixes = {"team", "t0", "t1", "t2", "t3", "t4", "t5" };
            string[][] data = {team, diem, tran, thang, bai, hoa, heso };

            // Loop through each prefix and corresponding data array
            for (int i = 0; i < prefixes.Length; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (i > 1) // For "t0" to "t5" arrays, the index starts from 1
                        KAObject = KAScene.GetObject($"{prefixes[i]}{j + 1}");
                    else // For "hang" and "team" arrays, use 1-based indexing
                        KAObject = KAScene.GetObject($"{prefixes[i]}{j + 1}");

                    KAObject.SetValue(data[i][j]);
                }
            }

            KAEngine.EndTransaction();
            KAScenePlayer.Prepare(layerTSL, KAScene);
            Thread.Sleep(50);
            KAScenePlayer.Play(layerTSL);
        }
        public void loadFullRanking(string[] team, string[] diem, string[] tran, string[] thang, string[] bai, string[] hoa, string[] heso)
        {
            string scene = SgroupStanding;
            KAScene KAScene = KAEngine.LoadScene(scene, scene);
            Thread.Sleep(10);
            KAEngine.BeginTransaction();

            string[] prefixes = {"team", "t0", "t1", "t2", "t3", "t4", "t5" };
            string[][] data = {team, diem, tran, thang, bai, hoa, heso };

            for (int i = 0; i < prefixes.Length; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    if (i >= 1) // For "t0" to "t5" arrays
                    {
                        if (j < 7)
                        {
                            KAObject = KAScene.GetObject($"{prefixes[i]}{j + 1}");
                        }
                        else
                        {
                            KAObject = KAScene.GetObject($"{prefixes[i]}{j - 6}1"); // Thêm "1" vào sau cho đội từ 8 đến 14
                        }
                    }
                    else // For "team" arrays
                    {
                        KAObject = KAScene.GetObject($"{prefixes[i]}{j + 1}");
                    }

                    KAObject.SetValue(data[i][j]);
                }
            }

            KAEngine.EndTransaction();
            KAScenePlayer.Prepare(layerPostMatch, KAScene);
            Thread.Sleep(10);
            KAScenePlayer.Play(layerPostMatch);
        }

        public void loadMatchID(string homeLogo, string awayLogo, string homeItem, string awayItem, 
            string homeLongName, string awayLongName,string round, string date, string svd)
        {
            string scene = SmatchID;
            KAScene KAScene = KAEngine.LoadScene(scene, scene);

            Thread.Sleep(10);
            KAEngine.BeginTransaction();
            KAObject = KAScene.GetObject("logo1");
            KAObject.SetValue(homeLogo);
            KAObject = KAScene.GetObject("logo2");
            KAObject.SetValue(awayLogo);

            KAObject = KAScene.GetObject("item1");
            KAObject.SetValue(homeItem);
            KAObject = KAScene.GetObject("item2");
            KAObject.SetValue(awayItem);

            KAObject = KAScene.GetObject("tendai1");
            KAObject.SetValue(homeLongName);
            KAObject = KAScene.GetObject("tendai2");
            KAObject.SetValue(awayLongName);

            KAObject = KAScene.GetObject("vongdau");
            KAObject.SetValue(round);
            KAObject = KAScene.GetObject("date");
            KAObject.SetValue(date);
            KAObject = KAScene.GetObject("svd");
            KAObject.SetValue(svd);

            KAEngine.EndTransaction();
            Thread.Sleep(10);
            KAScenePlayer.Prepare(layerPreMatch, KAScene);
            Thread.Sleep(10);
            KAScenePlayer.Play(layerPreMatch);
        }
        public void loadWeather(string Icons, string thoitiet, string DoAm, string SucGio, string NhietDo,
            string homeName, string awayName, string homeLogo, string awayLogo)
        {
            string scene = Sweather;
            KAScene KAScene = KAEngine.LoadScene(scene, scene);
            Thread.Sleep(10);

            KAEngine.BeginTransaction();
            KAObject = KAScene.GetObject("icon1");
            KAObject.SetValue(Icons);
            KAObject = KAScene.GetObject("thoitiet");
            KAObject.SetValue(thoitiet);
            KAObject = KAScene.GetObject("doam");
            KAObject.SetValue(DoAm);
            KAObject = KAScene.GetObject("sucgio");
            KAObject.SetValue(SucGio);
            KAObject = KAScene.GetObject("nhietdo");
            KAObject.SetValue(NhietDo);
            KAObject = KAScene.GetObject("tendai1");
            KAObject.SetValue(homeName);
            KAObject = KAScene.GetObject("tendai2");
            KAObject.SetValue(awayName);
            KAObject = KAScene.GetObject("logo1");
            KAObject.SetValue(homeLogo);
            KAObject = KAScene.GetObject("logo2");
            KAObject.SetValue(awayLogo);
            KAEngine.EndTransaction();

            Thread.Sleep(10);
            KAScenePlayer.Prepare(layerPreMatch, KAScene);
            Thread.Sleep(10);
            KAScenePlayer.Play(layerPreMatch);
        }

        //Show red cards on PERMCLOCK
        public void showRedCard(int RedCardHome, int RedCardAway)
        {
            string scene = SredClock;
            KAScene kAScene = KAEngine.LoadScene(scene, scene);

            KAEngine.BeginTransaction();

            for (int i = 1; i <= 4; i++)
            {
                KAObject obj = kAScene.GetObject($"homered{i}");
                obj.SetOpacity(i <= RedCardHome ? 255 : 0);
            }

            for (int i = 1; i <= 4; i++)
            {
                KAObject obj = kAScene.GetObject($"awayred{i}");
                obj.SetOpacity((i) <= RedCardAway ? 255 : 0);
            }

            KAEngine.EndTransaction();
            Thread.Sleep(10);
            KAScenePlayer.Prepare(layerTheDo, kAScene);
            Thread.Sleep(10);
            KAScenePlayer.Play(layerTheDo);
        }

        public void loadPenalty(string homeLongName, string awayLongName, string homeLogo, string awayLogo, string homeScore, string awayScore, string round, string[] home, string[] away)
        {

            string scene = "\\PENALTY.t2s";
            string workingPath = txtWorkingFolder.Text;
            string path = workingPath + "\\Scenes" + scene;
            KAScene KAScene = KAEngine.LoadScene(path, scene);
            Thread.Sleep(100);
            KAEngine.BeginTransaction();
            KAObject = KAScene.GetObject("home");
            KAObject.SetValue(homeLongName);
            KAObject = KAScene.GetObject("away");
            KAObject.SetValue(awayLongName);
            KAObject = KAScene.GetObject("logohome");
            KAObject.SetValue(homeLogo);
            KAObject = KAScene.GetObject("logoaway");
            KAObject.SetValue(awayLogo);
            KAObject = KAScene.GetObject("tiso1");
            KAObject.SetValue(homeScore);
            KAObject = KAScene.GetObject("tiso2");
            KAObject.SetValue(awayScore);
            //KAObject = KAScene.GetObject("loatsut");
            //KAObject.SetValue("Loạt sút" + " " + round);
            for (int i = 0; i < 5; i++)
            {
                int index = i + 1;
                string homeVar = "home" + index;
                string awayVar = "away" + index;
                string homeValue = home[i];
                string awayValue = away[i];
                ; KAObject = KAScene.GetObject(homeVar);
                KAObject.SetValue(homeValue);
                KAObject = KAScene.GetObject(awayVar);
                KAObject.SetValue(awayValue);
            }
            KAEngine.EndTransaction();
            KAScenePlayer.Prepare(layerPenalty, KAScene);
            Thread.Sleep(10);
            KAScenePlayer.Play(layerPenalty);
        }
        public void updatePenalty(string homeScore, string awayScore, string[] home, string[] away)
        {
            if (KAEngine == null || KAScenePlayer == null)
                return;
            KAScene KAScene = KAScenePlayer.GetPlayingScene(layerPenalty);
            if (KAScene != null)
            {
                KAObject = KAScene.GetObject("tiso1");
                KAObject.SetValue(homeScore);
                KAObject = KAScene.GetObject("tiso2");
                KAObject.SetValue(awayScore);
                for (int i = 0; i < 5; i++)
                {
                    int index = i + 1;
                    string homeVar = "home" + index;
                    string awayVar = "away" + index;
                    string homeValue = home[i];
                    string awayValue = away[i];
                    ; KAObject = KAScene.GetObject(homeVar);
                    KAObject.SetValue(homeValue);
                    KAObject = KAScene.GetObject(awayVar);
                    KAObject.SetValue(awayValue);
                }
            }
        }
        public void updatePermClock(string tiso1, string tiso2)
        {
            if (KAEngine == null || KAScenePlayer == null)
                return;
            KAScene KAScene = KAScenePlayer.GetPlayingScene(layerTSN);
            if (KAScene != null)
            {
                KAObject = KAScene.GetObject("tiso1");
                KAObject.SetValue(tiso1);
                KAObject = KAScene.GetObject("tiso2");
                KAObject.SetValue(tiso2);
            }
        }

        private void saveMatchID_Click(object sender, EventArgs e)
        {
            DBConfig.updateMatchID(2, txtVongDau.Text);
            DBConfig.updateMatchID(3, txtDiaDiem.Text);
            DBConfig.updateMatchID(4, txtThoiGian.Text);
            MessageBox.Show("Cập nhật Match ID thành công");
        }

        private void saveThoiTiet_Click(object sender, EventArgs e)
        {
            DBConfig.updateWeather(1, txtIcon.Text);
            DBConfig.updateWeather(2, txtThoiTiet.Text);
            DBConfig.updateWeather(3, txtNhietDo.Text);
            DBConfig.updateWeather(4, txtDoAm.Text);
            DBConfig.updateWeather(5, txtSucGio.Text);
            MessageBox.Show("Cập nhật Thời Tiết thành công");
        }

        private void saveTrongTai_Click(object sender, EventArgs e)
        {
            DBConfig.UpdateReferee("trongtai1", txtTT1.Text);
            DBConfig.UpdateReferee("troly1", txtTT2.Text);
            DBConfig.UpdateReferee("troly2", txtTT3.Text);
            DBConfig.UpdateReferee("trongtai4", txtTT4.Text);
            DBConfig.UpdateReferee("trongtaivar1", txtVAR1.Text);
            DBConfig.UpdateReferee("trongtaivar2", txtVAR2.Text);
            MessageBox.Show("Cập nhật Trọng tài thành công");
        }

        public void playScene(int layer)
        {
            try
            {
                if (KAEngine == null)
                    return;
                KAScenePlayer.Prepare(layer, KAScene);
                Thread.Sleep(10);
                KAScenePlayer.Play(layer);
            }
            catch { MessageBox.Show("Chưa chọn Scene"); }
        }
        public void LoadScene(string FileName, string SceneName)
        {
            try
            {
                if (KAEngine == null)
                    return;
                KAScene = KAEngine.LoadScene(FileName, SceneName);
            }
            catch { MessageBox.Show("Chưa chọn Scene"); }
        }
    }
}
