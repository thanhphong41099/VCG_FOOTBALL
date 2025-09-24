using K3DAsyncEngineLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VLeague.src.menu
{

    public partial class FrmSettingNews : Form
    {
        private EventHandlerNews MyEventHandler;

        public int m_SceneIndex = -1;

        public int m_LogIndex = 0;

        public KAEngine KAEngine;

        public KAScenePlayer KAScenePlayer;

        public KAObject KAObject;

        public KAScene KAScene;

        public static string key = "CONNECT NEWS";

        private static string ip = "IPADDRESS";

        private static string port = "PORT";

        public static string workingPath = "WORKINGFOLDERNEWS";

        private static string dataFilePath = "DATANEWS";

        public static bool check = true;
        public FrmSettingNews()
        {
            InitializeComponent();
        }

        private void FrmSettingNews_Load(object sender, EventArgs e)
        {
            AppConfig.envFileConfig();
            txtIpAddress.Text = AppConfig.ConfigReader.ReadString(key, ip);
            txtPort.Text = AppConfig.ConfigReader.ReadString(key, port);
            txtWorkingFolder.Text = AppConfig.ConfigReader.ReadString(key, workingPath);
            txtData.Text = AppConfig.ConfigReader.ReadString(key, dataFilePath);
            KAEngine = (KAEngine)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("D756CDBE-AA31-42B2-9CC7-018753CA61BF")));
            MyEventHandler = new EventHandlerNews(this);
            DBConfig.ConnectionNews(txtData.Text);
            connectCG();

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
        public void connectCG()
        {
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
            }
        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            AppConfig.ConfigReader.Write(key, ip, txtIpAddress.Text);
            AppConfig.ConfigReader.Write(key, port, txtPort.Text);
            AppConfig.ConfigReader.Write(key, workingPath, txtWorkingFolder.Text);
            AppConfig.ConfigReader.Write(key, dataFilePath, txtData.Text);
            MessageBox.Show("Success Change!");
        }

        private void btnConnectDB_Click(object sender, EventArgs e)
        {
            DBConfig.ConnectionNews(txtData.Text);
            AppConfig.ConfigReader.Write(key, workingPath, txtWorkingFolder.Text);
            AppConfig.ConfigReader.Write(key, dataFilePath, txtData.Text);
        }

        private void btnOpenConfig_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = Application.StartupPath + "\\config.cfg";
            process.Start();
        }

        public void loadScene(string scene, int layer)
        {
            string workingPath = txtWorkingFolder.Text;
            string path = workingPath + scene;
            KAScene KAScene = KAEngine.LoadScene(path, scene);
            Thread.Sleep(10);
            KAScenePlayer.Prepare(layer, KAScene);
            Thread.Sleep(10);
            KAScenePlayer.Play(layer);
        }
        public void loadMC2Line(string scene, int layer, string text1, string text2)
        {
            string workingPath = txtWorkingFolder.Text;
            string path = workingPath + scene;
            KAScene KAScene = KAEngine.LoadScene(path, scene);
            Thread.Sleep(10);
            KAEngine.BeginTransaction();
            KAObject = KAScene.GetObject("TENMC");
            KAObject.SetValue(text1);
            KAObject = KAScene.GetObject("EMAIL");
            KAObject.SetValue(text2);
            KAEngine.EndTransaction();
            KAScenePlayer.Prepare(layer, KAScene);
            Thread.Sleep(10);
            KAScenePlayer.Play(layer);
        }
        public void loadDiaDiem(string scene, int layer, string text1, string text2)
        {
            string workingPath = txtWorkingFolder.Text;
            string path = workingPath + scene;
            KAScene KAScene = KAEngine.LoadScene(path, scene);
            Thread.Sleep(10);
            KAEngine.BeginTransaction();
            KAObject = KAScene.GetObject("DIADIEM1");
            KAObject.SetValue(text1);
            KAObject = KAScene.GetObject("DIADIEM2");
            KAObject.SetValue(text2);
            KAEngine.EndTransaction();
            KAScenePlayer.Prepare(layer, KAScene);
            Thread.Sleep(10);
            KAScenePlayer.Play(layer);
        }
        public void loadTin(string scene, int layer, string text1, string text2)
        {
            string workingPath = txtWorkingFolder.Text;
            string path = workingPath + scene;
            KAScene KAScene = KAEngine.LoadScene(path, scene);
            Thread.Sleep(10);
            KAEngine.BeginTransaction();
            KAObject = KAScene.GetObject("DONG1");
            KAObject.SetValue(text1);
            KAObject = KAScene.GetObject("DONG2");
            KAObject.SetValue(text2);
            KAEngine.EndTransaction();
            KAScenePlayer.Prepare(layer, KAScene);
            Thread.Sleep(10);
            KAScenePlayer.Play(layer);
        }
        public void loadPhatBieu(string scene, int layer, string text1, string text2, string text3)
        {
            string workingPath = txtWorkingFolder.Text;
            string path = workingPath + scene;
            KAScene KAScene = KAEngine.LoadScene(path, scene);
            Thread.Sleep(10);
            KAEngine.BeginTransaction();
            KAObject = KAScene.GetObject("DONG0");
            KAObject.SetValue(text1);
            KAObject = KAScene.GetObject("DONG1");
            KAObject.SetValue(text2);
            KAObject = KAScene.GetObject("DONG2");
            KAObject.SetValue(text3);
            KAEngine.EndTransaction();
            KAScenePlayer.Prepare(layer, KAScene);
            Thread.Sleep(10);
            KAScenePlayer.Play(layer);
        }
        public void loadChayChuNgang(string scene, int layer, string text, int speed)
        {
            string workingPath = txtWorkingFolder.Text;
            string path = workingPath + scene;
            KAScene KAScene = KAEngine.LoadScene(path, scene);
            KAScene.SetSceneScrollSpeed(speed);
            Thread.Sleep(10);

            KAEngine.BeginTransaction();
            KAObject = KAScene.GetObject("CHAYCHUNGANG");
            KAObject.SetValue(text);
            KAEngine.EndTransaction();

            KAScenePlayer.Prepare(layer, KAScene);
            Thread.Sleep(10);
            KAScenePlayer.Play(layer);
        }
        public void loadChayChuDung(string scene, int layer, int speed)
        {
            string workingPath = txtWorkingFolder.Text;
            string path = workingPath + scene;
            KAScene KAScene = KAEngine.LoadScene(path, scene);
            KAScene.SetSceneScrollSpeed(speed);
            Thread.Sleep(10);
            KAScenePlayer.Prepare(layer, KAScene);
            Thread.Sleep(10);
            KAScenePlayer.Play(layer);
        }
        public void PreviewSceneChuCuoi(string scene, int layer)
        {
            string workingPath = txtWorkingFolder.Text;
            string path = workingPath + scene;
            KAScene KAScene = KAEngine.LoadScene(path, scene);

            for (int i = 1; i <= 60; i++)
            {
                string imagePath = workingPath + $"\\Thumbnails\\ChuCuoi{i}.png";
                KAScene.DownloadThumbnail(imagePath, 640, 360, i * 2);
            }
            KAScenePlayer.Prepare(layer, KAScene);
        }
        public void PreviewSceneMC(string scene, int layer, string text1, string text2)
        {
            string workingPath = txtWorkingFolder.Text;
            string path = workingPath + scene;
            KAScene KAScene = KAEngine.LoadScene(path, scene);
            KAEngine.BeginTransaction();
            KAObject = KAScene.GetObject("TENMC");
            KAObject.SetValue(text1);
            KAObject = KAScene.GetObject("EMAIL");
            KAObject.SetValue(text2);
            KAEngine.EndTransaction();
            KAScenePlayer.Prepare(layer, KAScene);

            for (int i = 1; i <= 40; i++)
            {
                string imagePath = workingPath + $"\\Thumbnails\\MC\\preview{i}.png";
                KAScene.DownloadThumbnail(imagePath, 640, 360, i * 3);
            }
        }
        public void PreviewSceneDiaDiem(string scene, int layer, string text1, string text2)
        {
            string workingPath = txtWorkingFolder.Text;
            string path = workingPath + scene;
            KAScene KAScene = KAEngine.LoadScene(path, scene);
            KAEngine.BeginTransaction();
            KAObject = KAScene.GetObject("DIADIEM1");
            KAObject.SetValue(text1);
            KAObject = KAScene.GetObject("DIADIEM2");
            KAObject.SetValue(text2);
            KAEngine.EndTransaction();
            KAScenePlayer.Prepare(layer, KAScene);

            for (int i = 1; i <= 10; i++)
            {
                string imagePath = workingPath + $"\\Thumbnails\\DiaDiem\\preview{i}.png";
                KAScene.DownloadThumbnail(imagePath, 640, 360, i * 3);
            }
        }
        public void PreviewTinTuc(string scene, string text1, string text2)
        {
            string workingPath = txtWorkingFolder.Text;
            string path = workingPath + scene;
            KAScene KAScene = KAEngine.LoadScene(path, scene);
            KAEngine.BeginTransaction();
            KAObject = KAScene.GetObject("DONG1");
            KAObject.SetValue(text1);
            KAObject = KAScene.GetObject("DONG2");
            KAObject.SetValue(text2);
            KAEngine.EndTransaction();

            for (int i = 1; i <= 30; i++)
            {
                string imagePath = workingPath + $"\\Thumbnails\\TinTuc\\preview{i}.png";
                KAScene.DownloadThumbnail(imagePath, 640, 360, i * 2);
            }
        }
        public void PreviewPhatBieu(string scene, string text1, string text2, string text3)
        {
            string workingPath = txtWorkingFolder.Text;
            string path = workingPath + scene;
            KAScene KAScene = KAEngine.LoadScene(path, scene);

            KAEngine.BeginTransaction();
            KAObject = KAScene.GetObject("DONG0");
            KAObject.SetValue(text1);
            KAObject = KAScene.GetObject("DONG1");
            KAObject.SetValue(text2);
            KAObject = KAScene.GetObject("DONG2");
            KAObject.SetValue(text3);
            KAEngine.EndTransaction();

            for (int i = 1; i <= 30; i++)
            {
                string imagePath = workingPath + $"\\Thumbnails\\PhatBieu\\preview{i}.png";
                KAScene.DownloadThumbnail(imagePath, 640, 360, i * 2);
            }
        }
        public void changeRealTimePhatBieu(int layer, string text1, string text2, string text3)
        {
            if (KAEngine == null || KAScenePlayer == null)
                return;
            KAScene KAScene = KAScenePlayer.GetPlayingScene(layer);
            if (KAScene != null)
            {
                KAObject = KAScene.GetObject("DONG0");
                KAObject.SetValue(text1);
                KAObject = KAScene.GetObject("DONG1");
                KAObject.SetValue(text2);
                KAObject = KAScene.GetObject("DONG2");
                KAObject.SetValue(text3);
            }
        }
        public void changeRealTimeTinTuc(int layer, string text1, string text2)
        {
            if (KAEngine == null || KAScenePlayer == null)
                return;
            KAScene KAScene = KAScenePlayer.GetPlayingScene(layer);
            if (KAScene != null)
            {
                KAObject = KAScene.GetObject("DONG1");
                KAObject.SetValue(text1);
                KAObject = KAScene.GetObject("DONG2");
                KAObject.SetValue(text2);
            }
        }
        private void setBackground1_Click(object sender, EventArgs e)
        {
            string scence = "\\CGScenes\\background.t2s";
            string workingPath = txtWorkingFolder.Text;
            string path = workingPath + scence;
            KAScene KAScene = KAEngine.LoadScene(path, scence);

            KAScenePlayer.Prepare(0, KAScene);

            KAScenePlayer.Play(0);
        }
    }
}
