using K3DAsyncEngineLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VLeague.src.menu
{
    public partial class chaychudung : UserControl
    {
        private int TimeXoaChayChuDung;
        public chaychudung()
        {
            InitializeComponent();
        }

        private void chaychudung_Load(object sender, EventArgs e)
        {
            numSpeed.Value = DBConfig.doGetIntValue("CHAYCHUDUNG", "speed");
            numHienBangChuCuoi.Value = DBConfig.doGetIntValue("CHAYCHUDUNG", "TimeOutro");
            lblTimerHienBangChuCuoi.Text = numHienBangChuCuoi.ToString() + "s";
        }

        private void btnChayChuDung_Click(object sender, EventArgs e)
        {
            string scene = DBConfig.doGetStringValue("CHAYCHUDUNG", "Data");
            int speed = (int)numSpeed.Value;
            FrmKarismaMenu.FrmSettingNews.loadChayChuDung(scene, FrmNews.layerChayChuDung, speed);
            if (radChaychu.Checked)
            {
                return;
            }
            if (radChaychucuoi.Checked)
            {
                TimeXoaChayChuDung = (int)numHienBangChuCuoi.Value;
                timeChayChuDung.Start();

                progressBarHienBangChuCuoi.Maximum = TimeXoaChayChuDung;
                progressBarHienBangChuCuoi.Value = 0;
            }
        }

        private void btnNgungChayChuDung_Click(object sender, EventArgs e)
        {
            if (radChaychu.Checked)
            {
                FrmKarismaMenu.FrmSettingNews.StopEff(FrmNews.layerChayChuDung);
            }
            if (radChaychucuoi.Checked)
            {
                timeChayChuDung.Stop();
                lblTimerHienBangChuCuoi.Text = numHienBangChuCuoi.Value + "s";
                progressBarHienBangChuCuoi.Value = 0;
                FrmKarismaMenu.FrmSettingNews.StopEff(FrmNews.layerChayChuDung);
            }

        }

        private void timeChayChuDung_Tick(object sender, EventArgs e)
        {
            if (TimeXoaChayChuDung > 0)
            {
                TimeXoaChayChuDung--;
                progressBarHienBangChuCuoi.Value++;
                lblTimerHienBangChuCuoi.Text = TimeXoaChayChuDung + "s";
            }
            else
            {
                btnNgungChayChuDung_Click(null, null);
                string scene = DBConfig.doGetStringValue("CHUCUOI", "data");
                FrmKarismaMenu.FrmSettingNews.loadScene(scene, FrmNews.layerChuCuoi);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
