using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace VLeague.src.menu
{
    public partial class FrmNews : Form
    {
        public static int layerBreakingNews = DBConfig.doGetIntValue("BREAKINGNEWS", "Layer");
        public static int layerChayChuDung = DBConfig.doGetIntValue("CHAYCHUDUNG", "Layer");
        public static int layerChayChuNgang = DBConfig.doGetIntValue("CHAYCHUNGANG", "Layer");
        public static int layerChuCuoi = DBConfig.doGetIntValue("CHUCUOI", "Layer");
        public static int layerDiaDiem1 = DBConfig.doGetIntValue("DIADIEM1", "Layer");
        public static int layerDiaDiem2 = DBConfig.doGetIntValue("DIADIEM2", "Layer");
        public static int layerHotline = DBConfig.doGetIntValue("HOTLINE", "Layer");
        public static int layerLive = DBConfig.doGetIntValue("LIVE", "Layer");
        public static int layerLogo1 = DBConfig.doGetIntValue("LOGO1", "Layer");
        public static int layerLogo2 = DBConfig.doGetIntValue("LOGO2", "Layer");
        public static int layerLogo3 = DBConfig.doGetIntValue("LOGO3", "Layer");
        public static int layerMC1 = DBConfig.doGetIntValue("MC1", "Layer");
        public static int layerMC2 = DBConfig.doGetIntValue("MC2", "Layer");
        public static int layerPhatBieu1 = DBConfig.doGetIntValue("PHATBIEU1", "Layer");
        public static int layerPhatBieu2 = DBConfig.doGetIntValue("PHATBIEU2", "Layer");
        public static int layerPopup1 = DBConfig.doGetIntValue("POPUP1", "Layer");
        public static int layerPopup2 = DBConfig.doGetIntValue("POPUP2", "Layer");
        public static int layerPopup3 = DBConfig.doGetIntValue("POPUP3", "Layer");
        public static int layerTransition = DBConfig.doGetIntValue("TRANSITION", "Layer");
        public static int layerTin1 = DBConfig.doGetIntValue("TIN1", "Layer");
        public static int layerTin2 = DBConfig.doGetIntValue("TIN2", "Layer");

        string workingPath = AppConfig.ConfigReader.ReadString(FrmSettingNews.key, FrmSettingNews.workingPath);
        private bool isLooping = true;

        public FrmNews()
        {
            InitializeComponent();
            CapnhatTimeNow();
        }

        private void FrmNews_Load(object sender, EventArgs e)
        {
            timeNow.Start();
            DBConfig.doGetInfoLayer();

        }

        public void ShowNewsControl()
        {
            newsControl1.Visible = true;
            newsControl1.BringToFront();
        }

        public void ShowChayChuNgang()
        {
            chaychungang1.Visible = true;
            chaychungang1.BringToFront();
        }
        public void ShowChayChuDung()
        {
            chaychudung1.Visible = true;
            chaychudung1.BringToFront();
        }

        private void btnHienLive_Click(object sender, EventArgs e)
        {
            try
            {
                string scene = DBConfig.doGetStringValue("LIVE","data");
                FrmKarismaMenu.FrmSettingNews.loadScene(scene, layerLive);
            }
            catch 
            {
                MessageBox.Show("False");
            }
        }

        private void btnXoaLive_Click(object sender, EventArgs e)
        {
            FrmKarismaMenu.FrmSettingNews.StopEff(layerLive);
        }

        private void btnHienBreakingNews_Click(object sender, EventArgs e)
        {
            string scene = DBConfig.doGetStringValue("BREAKINGNEWS", "data"); 
            FrmKarismaMenu.FrmSettingNews.loadScene(scene, layerBreakingNews);
        }

        private void btnXoaBreakingNews_Click(object sender, EventArgs e)
        {         
            string scene = DBConfig.doGetStringValue("BREAKINGNEWS", "Out"); 
            FrmKarismaMenu.FrmSettingNews.loadScene(scene, layerBreakingNews);
        }

        private void btnXoaHet_Click(object sender, EventArgs e)
        {
            FrmKarismaMenu.FrmSettingNews.StopAll();
        }

        private void timeNow_Tick(object sender, EventArgs e)
        {
            CapnhatTimeNow();

        }
        private void CapnhatTimeNow()
        {
            btnTimeNow.Text = String.Format("{0}", DateTime.Now.ToString("HH:mm:ss", CultureInfo.InvariantCulture));
        }

        private void btnHienHotline_Click(object sender, EventArgs e)
        {
            string scene = DBConfig.doGetStringValue("HOTLINE", "data");
            FrmKarismaMenu.FrmSettingNews.loadScene(scene, layerHotline);
        }

        private void btnXoaHotline_Click(object sender, EventArgs e)
        {
            FrmKarismaMenu.FrmSettingNews.StopEff(layerHotline);
        }

        private void btnChayHinhCat_Click(object sender, EventArgs e)
        {
            string scene = DBConfig.doGetStringValue("TRANSITION", "data"); 
            FrmKarismaMenu.FrmSettingNews.loadScene(scene, layerTransition);
        }

        private async void btnXemTruocBangChuCuoi_Click(object sender, EventArgs e)
        {
            string scene = DBConfig.doGetStringValue("CHUCUOI", "data");
            FrmKarismaMenu.FrmSettingNews.PreviewSceneChuCuoi(scene, layerChuCuoi);
            await Task.Delay(200);
            isLooping = true;
            for (int i = 1; i <= 60; i++)
            {
                if (!isLooping)
                    break;
                string imagePath = workingPath + $"\\Thumbnails\\ChuCuoi{i}.png";

                picPreviewPhatBieu.Image = Image.FromFile(imagePath);

                await Task.Delay(50);
            }

        }

        private void btnHienBangChuCuoi_Click(object sender, EventArgs e)
        {
            FrmKarismaMenu.FrmSettingNews.StopAll();
            string scene = DBConfig.doGetStringValue("CHUCUOI", "data"); 
            FrmKarismaMenu.FrmSettingNews.loadScene(scene, layerChuCuoi);
        }

        private void btnXoaBangChuCuoi_Click(object sender, EventArgs e)
        {
            FrmKarismaMenu.FrmSettingNews.StopEff(layerChuCuoi);
        }
    }
}
