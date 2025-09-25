using K3DAsyncEngineLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VLeague.src.helper;
using VLeague.src.model;

namespace VLeague.src.menu
{
    public partial class FrmPreMatch : Form
    {
        //string iconTacticalPlayer, iconTacticalGK;
        Color playerColor, GKColor;

        public FrmPreMatch()
        {
            InitializeComponent();
            ButtonHelper.InitializeButtons(this);
        }

        private void clearTagButton()
        {
            Button[] buttons = new Button[]
            {
        btnWeather, btnMatchID, btnGroupSTD, btnReferee, btnVar
            };
            ButtonHelper.ClearTagButton(buttons);
        }
        private void clearTagButtonEx(Button clickedButton)
        {
            Button[] buttons = new Button[]
            {
        btnWeather, btnMatchID, btnGroupSTD, btnReferee, btnVar
            };
            ButtonHelper.ClearTagButtonEx(buttons, clickedButton);
        }
        private void UpdateButtonState(Button btn, int x)
        {
            ButtonHelper.UpdateButtonState(btn, x);
        }

        private void FrmPreMatch_Load(object sender, EventArgs e)
        {
            try
            {
                homeTeamName.Text = TeamInfor.homeTenDai;
                awayTeamName.Text = TeamInfor.awayTenDai;
                labelHomeTac.Text = TeamInfor.homeTactical;
                labelAwayTac.Text = TeamInfor.awayTactical;

            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra khi load dữ liệu, vui lòng LOAD DATA ở DATA IMPORT", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnMatchID_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            clearTagButtonEx(clickedButton);
            DBConfig.doGetInfoTournaments();
            String round = DBConfig.tournaments.Tables[0].Rows[1]["Name"].ToString();
            String date = DBConfig.tournaments.Tables[0].Rows[3]["Name"].ToString();
            String location = DBConfig.tournaments.Tables[0].Rows[2]["Name"].ToString();

            UpdateButtonState(sender as Button, 1);
            switch (btnMatchID.Tag)
            {
                case 0:
                    FrmKarismaMenu.FrmSetting.Resume(FrmSetting.layerPreMatch);
                    break;
                case 1:
                    FrmKarismaMenu.FrmSetting.loadMatchID(TeamInfor.homeLogo, TeamInfor.awayLogo, 
                        TeamInfor.homeHomeItem, TeamInfor.awayAwayItem, 
                        TeamInfor.homeTenDai, TeamInfor.awayTenDai,round, date, location);
                    break;
            }
        }
        private void btnStopMatchID_Click(object sender, EventArgs e)
        {
            clearTagButton();
            FrmKarismaMenu.FrmSetting.Stop(FrmSetting.layerPreMatch);
        }

        private void btnWeather_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            clearTagButtonEx(clickedButton);
            DBConfig.doGetInfoWeather();
            String Icons = DBConfig.weather.Tables[0].Rows[0]["Name"].ToString();
            String ThoiTiet = DBConfig.weather.Tables[0].Rows[1]["Name"].ToString();
            String NhietDo = DBConfig.weather.Tables[0].Rows[2]["Name"].ToString();
            String DoAm = DBConfig.weather.Tables[0].Rows[3]["Name"].ToString();
            String SucGio = DBConfig.weather.Tables[0].Rows[4]["Name"].ToString();

            UpdateButtonState(sender as Button, 1);

            switch (btnWeather.Tag)
            {
                case 0:
                    FrmKarismaMenu.FrmSetting.Resume(FrmSetting.layerPreMatch);
                    break;
                case 1:
                    FrmKarismaMenu.FrmSetting.loadWeather(Icons, ThoiTiet, DoAm, SucGio, NhietDo,
                        TeamInfor.homeTenDai, TeamInfor.awayTenDai, TeamInfor.homeLogo, TeamInfor.awayLogo);
                    break;
            }
        }

        private void btnStopWeather_Click(object sender, EventArgs e)
        {
            clearTagButton();
            FrmKarismaMenu.FrmSetting.Stop(FrmSetting.layerPreMatch);
        }

        private void btnGroupSTD_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            clearTagButtonEx(clickedButton);
            DBConfig.doGetSoccerRanking();
            //Đổi icon button
            UpdateButtonState(sender as Button, 0);
            //function theo btn.tag
            switch (btnGroupSTD.Tag)
            {
                case 0:
                    FrmKarismaMenu.FrmSetting.Resume(FrmSetting.layerPostMatch);
                    break;
                case 1:
                    ShowRankingTeam(0, 14);
                    break;
                case 2:
                    FrmKarismaMenu.FrmSetting.Resume(FrmSetting.layerPostMatch);
                    break;
            }
        }

        private void ShowRankingTeam(int start, int count)
        {
            string[] team = new string[count];
            string[] diem = new string[count];
            string[] tran = new string[count];
            string[] thang = new string[count];
            string[] bai = new string[count];
            string[] hoa = new string[count];
            string[] heso = new string[count];

            for (int i = 0; i < count && (start + i) < DBConfig.ranking.Rows.Count; i++)
            {
                DataRow row = DBConfig.ranking.Rows[start + i];

                team[i] = row["TenDoi"].ToString();
                diem[i] = row["Diem"].ToString();
                tran[i] = row["Tran"].ToString();
                thang[i] = row["T"].ToString();
                bai[i] = row["B"].ToString();
                hoa[i] = row["H"].ToString();
                heso[i] = row["HS"].ToString();
            }

            FrmKarismaMenu.FrmSetting.loadFullRanking(team, diem, tran, thang, bai, hoa, heso);
        }

        private void btnStopGroupSTD_Click(object sender, EventArgs e)
        {
            clearTagButton();
            FrmKarismaMenu.FrmSetting.Stop(FrmSetting.layerPreMatch);
        }


        private void SetBackground_Click(object sender, EventArgs e)
        {
            FrmKarismaMenu.FrmSetting.loadBackGround(); 
        }

        private void btnReferee_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            clearTagButtonEx(clickedButton);
            DBConfig.doGetInforeferee();
            string mainReferee = DBConfig.referee.Tables[0].Rows[0]["Name"].ToString();
            string refereeOne = DBConfig.referee.Tables[0].Rows[1]["Name"].ToString();
            string refereeTwo = DBConfig.referee.Tables[0].Rows[2]["Name"].ToString();
            string refereeThree = DBConfig.referee.Tables[0].Rows[3]["Name"].ToString();
            if (mainReferee.Equals(""))
            {
                MessageBox.Show("Vui lòng thêm tên trọng tài !");
                return;
            }
            UpdateButtonState(sender as Button, 1);
            switch (btnReferee.Tag)
            {
                case 0:
                    FrmKarismaMenu.FrmSetting.Resume(FrmSetting.layerPreMatch);
                    break;
                case 1:
                    FrmKarismaMenu.FrmSetting.loadReferre(mainReferee, refereeOne, refereeTwo, refereeThree);
                    break;
            }

        }
        private void btnStopReferee_Click(object sender, EventArgs e)
        {
            clearTagButton();
            FrmKarismaMenu.FrmSetting.Stop(FrmSetting.layerPreMatch);
        }
        private void btnVar_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            clearTagButtonEx(clickedButton);
            DBConfig.doGetInforeferee();
            string varRefereeOne = DBConfig.referee.Tables[0].Rows[4]["Name"].ToString();
            string varRefereeTwo = DBConfig.referee.Tables[0].Rows[5]["Name"].ToString();
            if (varRefereeOne.Equals(""))
            {
                MessageBox.Show("Vui lòng thêm tên trọng tài !");
                return;
            }

            UpdateButtonState(sender as Button, 1);
            switch (btnVar.Tag)
            {
                case 0:
                    FrmKarismaMenu.FrmSetting.Resume(FrmSetting.layerPreMatch);
                    break;
                case 1:
                    FrmKarismaMenu.FrmSetting.loadVarReferee(varRefereeOne, varRefereeTwo);
                    break;
            }
        }

        private void btnStopVar_Click(object sender, EventArgs e)
        {
            clearTagButton();
            FrmKarismaMenu.FrmSetting.Stop(FrmSetting.layerPreMatch);
        }

        private void stopAll_Click(object sender, EventArgs e)
        {
            clearTagButton();
            FrmKarismaMenu.FrmSetting.StopAll();
        }

        private void btnPlayHomeLinup_Click(object sender, EventArgs e)
        {
            FrmKarismaMenu.FrmSetting.loadSceneLineup(TeamInfor.homeTactical,
                TeamInfor.homeLogo, TeamInfor.homeHLV, TeamInfor.PlayersHome);

            FrmKarismaMenu.FrmSetting.Play(FrmSetting.layerPreMatch);
        }

        private void btnResumeHomeLineup_Click(object sender, EventArgs e)
        {
            FrmKarismaMenu.FrmSetting.Resume(FrmSetting.layerPreMatch);
        }

        private void btnStopHome_Click_1(object sender, EventArgs e)
        {
            FrmKarismaMenu.FrmSetting.Stop(FrmSetting.layerPreMatch);
        }

        private void btnPlayAwayLineup_Click(object sender, EventArgs e)
        {
            FrmKarismaMenu.FrmSetting.loadSceneLineup(TeamInfor.awayTactical,
                TeamInfor.awayLogo, TeamInfor.awayHLV, TeamInfor.PlayersAway);
            FrmKarismaMenu.FrmSetting.Play(FrmSetting.layerPreMatch);
        }

        private void btnResumeAway_Click(object sender, EventArgs e)
        {
            FrmKarismaMenu.FrmSetting.Resume(FrmSetting.layerPreMatch);
        }

        private void btnStopAway_Click(object sender, EventArgs e)
        {
            FrmKarismaMenu.FrmSetting.Stop(FrmSetting.layerPreMatch);
        }

    }
}
