using K3DAsyncEngineLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace VLeague.src.menu
{
    public partial class NewsControl : UserControl
    {
        public int TimeXoaPopup1, TimeXoaPopup2, TimeXoaPopup3, TimeXoaTinTuc, TimeXoaTenMC, TimeXoaDiaDiem, TimeXoaPhatBieu;
        string dong1 = "";
        string dong2 = "";
        string tenpb = "";
        string dong1pb = "";
        string dong2pb = "";
        string scene = "";

        Dictionary<string, string> mcEmailMap = new Dictionary<string, string>();
        Dictionary<string, string> DiaDiemMap = new Dictionary<string, string>();

        string workingPath = AppConfig.ConfigReader.ReadString(FrmSettingNews.key, FrmSettingNews.workingPath);
        private bool isLooping = true;
        private int P = 0;
        private int T = 0;

        public NewsControl()
        {
            InitializeComponent();
        }
        private void NewsControl_Load(object sender, EventArgs e)
        {
            FillComboBoxWithMCData();
            FillComboBoxWithDiaDiem();
            loadTableTinTuc();
            loadTablePhatBieu();
            numPopup1Time.Value = DBConfig.doGetIntValue("POPUP1", "AutoOff");
            numPopup2Time.Value = DBConfig.doGetIntValue("POPUP2", "AutoOff");
            numPopup3Time.Value = DBConfig.doGetIntValue("POPUP3", "AutoOff");
            numTimeTenMC.Value = DBConfig.doGetIntValue("MC1", "AutoOff");
            numTimeDiaDiem.Value = DBConfig.doGetIntValue("DIADIEM1", "AutoOff");
            numTimeTinTuc.Value = DBConfig.doGetIntValue("TIN1", "AutoOff");
            numTimePhatBieu.Value = DBConfig.doGetIntValue("PHATBIEU", "AutoOff");
            lblTimerXoaPopup1.Text = (int)numPopup1Time.Value + "s";
            lblTimerXoaPopup2.Text = (int)numPopup2Time.Value + "s";
            lblTimerXoaPopup3.Text = (int)numPopup3Time.Value + "s";
            lbTimeXoaTenMC.Text = (int)numTimeTenMC.Value + "s";
            lbTimeXoaDiaDiem.Text = (int)numTimeDiaDiem.Value + "s";
            lbTimeXoaTinTuc.Text = (int)numTimeTinTuc.Value + "s";
            lbTimeXoaPhatBieu.Text = (int)numTimePhatBieu.Value + "s";
        }

        private void numPopup1Time_ValueChanged(object sender, EventArgs e)
        {
            lblTimerXoaPopup1.Text = (int)numPopup1Time.Value + "s";
        }

        private void numPopup2Time_ValueChanged(object sender, EventArgs e)
        {
            lblTimerXoaPopup2.Text = (int)numPopup2Time.Value + "s";
        }

        private void numPopup3Time_ValueChanged(object sender, EventArgs e)
        {
            lblTimerXoaPopup3.Text = (int)numPopup3Time.Value + "s";
        }
        private void timePopup1_Tick(object sender, EventArgs e)
        {
            if (TimeXoaPopup1 > 0)
            {
                TimeXoaPopup1--;
                progressBarPopup1.Value++;
                lblTimerXoaPopup1.Text = TimeXoaPopup1 + "s";
            }
            else
            {
                btnXoaPopup1_Click(null, null);
            }
        }
        private void btnHienPopup1_Click(object sender, EventArgs e)
        {
            try
            {
                TimeXoaPopup1 = (int)numPopup1Time.Value;
                timePopup1.Start();

                progressBarPopup1.Maximum = TimeXoaPopup1;
                progressBarPopup1.Value = 0;

                string scene = DBConfig.doGetStringValue("POPUP1","data");
                FrmKarismaMenu.FrmSettingNews.loadScene(scene, FrmNews.layerPopup1);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void btnXoaPopup1_Click(object sender, EventArgs e)
        {
            try
            {
                timePopup1.Stop();
                lblTimerXoaPopup1.Text = numPopup1Time.Value + "s";
                progressBarPopup1.Value = 0;

                FrmKarismaMenu.FrmSettingNews.StopEff(FrmNews.layerPopup1);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnHienLogo1_Click(object sender, EventArgs e)
        {
            try
            {
                string scene = DBConfig.doGetStringValue("LOGO1", "data");
                FrmKarismaMenu.FrmSettingNews.loadScene(scene, FrmNews.layerLogo1);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void btnXoaLogo1_Click(object sender, EventArgs e)
        {
            try
            {
                FrmKarismaMenu.FrmSettingNews.StopEff(FrmNews.layerLogo1);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnHienLogo2_Click(object sender, EventArgs e)
        {
            try
            {
                string scene = DBConfig.doGetStringValue("LOGO2", "data");
                FrmKarismaMenu.FrmSettingNews.loadScene(scene, FrmNews.layerLogo2);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnXoaLogo2_Click(object sender, EventArgs e)
        {
            try
            {
                FrmKarismaMenu.FrmSettingNews.StopEff(FrmNews.layerLogo2);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnHienLogo3_Click(object sender, EventArgs e)
        {
            try
            {
                string scene = DBConfig.doGetStringValue("LOGO3", "data");
                FrmKarismaMenu.FrmSettingNews.loadScene(scene, FrmNews.layerLogo3);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void btnXoaLogo3_Click(object sender, EventArgs e)
        {
            FrmKarismaMenu.FrmSettingNews.StopEff(FrmNews.layerLogo3);
        }

        private void timePopup2_Tick(object sender, EventArgs e)
        {
            if (TimeXoaPopup2 > 0)
            {
                TimeXoaPopup2--;
                progressBarPopup2.Value++;
                lblTimerXoaPopup2.Text = TimeXoaPopup2 + "s";
            }
            else
            {
                btnXoaPopup2_Click(null, null);
            }
        }

        private void btnXoaPopup2_Click(object sender, EventArgs e)
        {
            try
            {
                timePopup2.Stop();
                lblTimerXoaPopup2.Text = numPopup2Time.Value + "s";
                progressBarPopup2.Value = 0;

                FrmKarismaMenu.FrmSettingNews.StopEff(FrmNews.layerPopup2);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnHienPopup2_Click(object sender, EventArgs e)
        {
            try
            {
                TimeXoaPopup2 = (int)numPopup2Time.Value;
                timePopup2.Start();

                progressBarPopup2.Maximum = TimeXoaPopup2;
                progressBarPopup2.Value = 0;

                string scene = DBConfig.doGetStringValue("POPUP2", "data");
                FrmKarismaMenu.FrmSettingNews.loadScene(scene, FrmNews.layerPopup2);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void timePopup3_Tick(object sender, EventArgs e)
        {
            if (TimeXoaPopup3 > 0)
            {
                TimeXoaPopup3--;
                progressBarPopup3.Value++;
                lblTimerXoaPopup3.Text = TimeXoaPopup3 + "s";
            }
            else
            {
                btnXoaPopup3_Click(null, null);
            }
        }

        private void btnHienPopup3_Click(object sender, EventArgs e)
        {
            try
            {
                TimeXoaPopup3 = (int)numPopup3Time.Value;
                timePopup3.Start();

                progressBarPopup3.Maximum = TimeXoaPopup3;
                progressBarPopup3.Value = 0;

                string scene = DBConfig.doGetStringValue("POPUP3", "data");
                FrmKarismaMenu.FrmSettingNews.loadScene(scene, FrmNews.layerPopup3);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnXoaPopup3_Click(object sender, EventArgs e)
        {
            try
            {
                timePopup3.Stop();
                lblTimerXoaPopup3.Text = numPopup3Time.Value + "s";
                progressBarPopup3.Value = 0;

                FrmKarismaMenu.FrmSettingNews.StopEff(FrmNews.layerPopup3);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void timeMC_Tick(object sender, EventArgs e)
        {
            if (TimeXoaTenMC > 0)
            {
                TimeXoaTenMC--;
                progressBarTenMC.Value++;
                lbTimeXoaTenMC.Text = TimeXoaTenMC + "s";
            }
            else
            {
                btnXoaTenMC_Click(null, null);
            }
        }

        private void btnXoaTenMC_Click(object sender, EventArgs e)
        {
            try
            {
                timeMC.Stop();
                lbTimeXoaTenMC.Text = numTimeTenMC.Value + "s";
                progressBarTenMC.Value = 0;
                string scene = DBConfig.doGetStringValue("MC2", "Out");
                FrmKarismaMenu.FrmSettingNews.loadScene(scene ,FrmNews.layerMC2);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnHienTenMC_Click(object sender, EventArgs e)
        {
            try
            {
                TimeXoaTenMC = (int)numTimeTenMC.Value;
                timeMC.Start();

                progressBarTenMC.Maximum = TimeXoaTenMC;
                progressBarTenMC.Value = 0;
                if (txtEmail.Text == "") 
                {
                    string scene = DBConfig.doGetStringValue("MC1", "data");
                    FrmKarismaMenu.FrmSettingNews.loadMC2Line(scene, FrmNews.layerMC1, cbbMC.Text, txtEmail.Text);
                }
                else
                {
                    string scene = DBConfig.doGetStringValue("MC2", "data");
                    FrmKarismaMenu.FrmSettingNews.loadMC2Line(scene, FrmNews.layerMC2, cbbMC.Text, txtEmail.Text);
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnXoaTenMCCut_Click(object sender, EventArgs e)
        {
            timeMC.Stop();
            lbTimeXoaTenMC.Text = numTimeTenMC.Value + "s";
            progressBarTenMC.Value = 0;
            FrmKarismaMenu.FrmSettingNews.StopEff(FrmNews.layerMC2);
        }

        private void numTimeTenMC_ValueChanged(object sender, EventArgs e)
        {
            lbTimeXoaTenMC.Text = (int)numTimeTenMC.Value + "s";
        }

        private void numTimeDiaDiem_ValueChanged(object sender, EventArgs e)
        {
            lbTimeXoaDiaDiem.Text = (int)numTimeDiaDiem.Value + "s";
        }

        private void numTimeTinTuc_ValueChanged(object sender, EventArgs e)
        {
            lbTimeXoaTinTuc.Text = (int)numTimeTinTuc.Value + "s";
        }

        private void numTimePhatBieu_ValueChanged(object sender, EventArgs e)
        {
            lbTimeXoaPhatBieu.Text = (int)numTimePhatBieu.Value + "s";
        }

        private void timeDiaDiem_Tick(object sender, EventArgs e)
        {
            if (TimeXoaDiaDiem > 0)
            {
                TimeXoaDiaDiem--;
                progressBarDiaDiem.Value++;
                lbTimeXoaDiaDiem.Text = TimeXoaDiaDiem + "s";
            }
            else
            {
                btnXoaDiaDiem_Click(null, null);
            }
        }

        private void btnXoaDiaDiem_Click(object sender, EventArgs e)
        {
            try
            {
                timeDiaDiem.Stop();
                lbTimeXoaDiaDiem.Text = numTimeDiaDiem.Value + "s";
                progressBarDiaDiem.Value = 0;
                if (txtDiaDiem.Text == "")
                {
                    string scene = DBConfig.doGetStringValue("DIADIEM1", "Out");
                    FrmKarismaMenu.FrmSettingNews.loadScene(scene, FrmNews.layerDiaDiem1);
                }
                else
                {
                    string scene = DBConfig.doGetStringValue("DIADIEM2", "Out");
                    FrmKarismaMenu.FrmSettingNews.loadScene(scene, FrmNews.layerDiaDiem2);
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnHienDiaDiem_Click(object sender, EventArgs e)
        {
            try
            {
                TimeXoaDiaDiem = (int)numTimeDiaDiem.Value;
                timeDiaDiem.Start();

                progressBarDiaDiem.Maximum = TimeXoaDiaDiem;
                progressBarDiaDiem.Value = 0;
                if (txtDiaDiem.Text == "")
                {
                    string scene = DBConfig.doGetStringValue("DIADIEM1", "data");
                    FrmKarismaMenu.FrmSettingNews.loadDiaDiem(scene, FrmNews.layerDiaDiem1, cbbDiaDiem.Text, txtDiaDiem.Text);
                }
                else
                {
                    string scene = DBConfig.doGetStringValue("DIADIEM2", "data");
                    FrmKarismaMenu.FrmSettingNews.loadDiaDiem(scene, FrmNews.layerDiaDiem2, cbbDiaDiem.Text, txtDiaDiem.Text);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnXoaDiaDiemCut_Click(object sender, EventArgs e)
        {
            timeDiaDiem.Stop();
            lbTimeXoaDiaDiem.Text = numTimeDiaDiem.Value + "s";
            progressBarDiaDiem.Value = 0;
            FrmKarismaMenu.FrmSettingNews.StopEff(FrmNews.layerDiaDiem1);
        }

        private void btnHienTinTuc_Click(object sender, EventArgs e)
        {
            TimeXoaTinTuc = (int)numTimeTinTuc.Value;
            timeTinTuc.Start();

            progressBarTinTuc.Maximum = TimeXoaTinTuc;
            progressBarTinTuc.Value = 0;

            dong1 = lstTinTuc.CurrentRow.Cells[1].Value.ToString();
            dong2 = lstTinTuc.CurrentRow.Cells[2].Value.ToString();
            if (string.IsNullOrWhiteSpace(dong2))
            {
                scene = DBConfig.doGetStringValue("TIN1", "data");
                FrmKarismaMenu.FrmSettingNews.loadTin(scene, FrmNews.layerTin1, dong1, dong2);
            }
            else
            {
                scene = DBConfig.doGetStringValue("TIN2", "data");
                FrmKarismaMenu.FrmSettingNews.loadTin(scene, FrmNews.layerTin2, dong1, dong2);
            }
        }

        private void btnXoaTinTuc_Click(object sender, EventArgs e)
        {
            timeTinTuc.Stop();
            lbTimeXoaTinTuc.Text = numTimeTinTuc.Value + "s";
            progressBarTinTuc.Value = 0;
            if (string.IsNullOrWhiteSpace(dong2pb))
            {
                scene = DBConfig.doGetStringValue("TIN1", "Out");
                FrmKarismaMenu.FrmSettingNews.loadScene(scene, FrmNews.layerTin1);
            }
            else
            {
                scene = DBConfig.doGetStringValue("TIN2", "Out");
                FrmKarismaMenu.FrmSettingNews.loadScene(scene, FrmNews.layerTin2);
            }
        }

        private void btnXoaTinTucCut_Click(object sender, EventArgs e)
        {
            timeTinTuc.Stop();
            lbTimeXoaTinTuc.Text = numTimeTinTuc.Value + "s";
            progressBarTinTuc.Value = 0;
            FrmKarismaMenu.FrmSettingNews.StopEff(FrmNews.layerTin1);
        }

        private void btnNextTinTuc_Click(object sender, EventArgs e)
        {
            int currentIndex = lstTinTuc.CurrentRow.Index;
            int rowCount = lstTinTuc.Rows.Count;

            if (currentIndex < rowCount - 1)
            {
                lstTinTuc.CurrentCell = lstTinTuc.Rows[currentIndex + 1].Cells[0];
            }
            else
            {
                lstTinTuc.CurrentCell = lstTinTuc.Rows[0].Cells[0];
            }
        }

        private void btnNextPhatBieu_Click(object sender, EventArgs e)
        {
            int currentIndex = lstPhatBieu.CurrentRow.Index;
            int rowCount = lstPhatBieu.Rows.Count;

            if (currentIndex < rowCount - 1)
            {
                lstPhatBieu.CurrentCell = lstPhatBieu.Rows[currentIndex + 1].Cells[0];
            }
            else
            {
                lstPhatBieu.CurrentCell = lstPhatBieu.Rows[0].Cells[0];
            }
        }

        private void btnXoaPhatBieuCut_Click(object sender, EventArgs e)
        {
            timePhatBieu.Stop();
            lbTimeXoaPhatBieu.Text = numTimePhatBieu.Value + "s";
            progressBarPhatBieu.Value = 0;
            FrmKarismaMenu.FrmSettingNews.StopEff(FrmNews.layerPhatBieu1);
        }

        private void btnHienPhatBieu_Click(object sender, EventArgs e)
        {
            TimeXoaPhatBieu = (int)numTimePhatBieu.Value;
            timePhatBieu.Start();

            progressBarPhatBieu.Maximum = TimeXoaPhatBieu;
            progressBarPhatBieu.Value = 0;

            tenpb = lstPhatBieu.CurrentRow.Cells[1].Value.ToString();
            dong1pb = lstPhatBieu.CurrentRow.Cells[2].Value.ToString();
            dong2pb = lstPhatBieu.CurrentRow.Cells[3].Value.ToString();
            if (string.IsNullOrWhiteSpace(dong1pb) && string.IsNullOrWhiteSpace(dong2pb))
            {
                scene = DBConfig.doGetStringValue("PHATBIEU", "data");
                FrmKarismaMenu.FrmSettingNews.loadPhatBieu(scene, FrmNews.layerPhatBieu1, tenpb, dong1pb, dong2pb);
            }
            else if (!string.IsNullOrWhiteSpace(dong1pb) && string.IsNullOrWhiteSpace(dong2pb))
            {
                scene = DBConfig.doGetStringValue("PHATBIEU1", "data");
                FrmKarismaMenu.FrmSettingNews.loadPhatBieu(scene, FrmNews.layerPhatBieu1, tenpb, dong1pb, dong2pb);
            }
            else
            {
                scene = DBConfig.doGetStringValue("PHATBIEU2", "data");
                FrmKarismaMenu.FrmSettingNews.loadPhatBieu(scene, FrmNews.layerPhatBieu2, tenpb, dong1pb, dong2pb);
            }
        }

        private void btnXoaPhatBieu_Click(object sender, EventArgs e)
        {
            timePhatBieu.Stop();
            lbTimeXoaPhatBieu.Text = numTimePhatBieu.Value + "s";
            progressBarPhatBieu.Value = 0;

            if (string.IsNullOrWhiteSpace(dong2pb))
            {
                scene = DBConfig.doGetStringValue("PHATBIEU1", "Out");
                FrmKarismaMenu.FrmSettingNews.loadScene(scene, FrmNews.layerPhatBieu1);
            }
            else
            {
                scene = DBConfig.doGetStringValue("PHATBIEU2", "Out");
                FrmKarismaMenu.FrmSettingNews.loadScene(scene, FrmNews.layerPhatBieu2);
            }
        }

        private void btnRefreshTinTuc_Click(object sender, EventArgs e)
        {
            loadTableTinTuc();
        }

        private void btnRefreshPhatBieu_Click(object sender, EventArgs e)
        {
            loadTablePhatBieu();
        }

        private void timeTinTuc_Tick(object sender, EventArgs e)
        {
            if (TimeXoaTinTuc > 0)
            {
                TimeXoaTinTuc--;
                progressBarTinTuc.Value++;
                lbTimeXoaTinTuc.Text = TimeXoaTinTuc + "s";
            }
            else
            {
                btnXoaTinTuc_Click(null, null);
            }
        }

        private void timePhatBieu_Tick(object sender, EventArgs e)
        {
            if (TimeXoaPhatBieu > 0)
            {
                TimeXoaPhatBieu--;
                progressBarPhatBieu.Value++;
                lbTimeXoaPhatBieu.Text = TimeXoaPhatBieu + "s";
            }
            else
            {
                btnXoaPhatBieu_Click(null, null);
            }
        }

        private async void btnXemTruocMC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                string scene = DBConfig.doGetStringValue("MC1", "data");
                FrmKarismaMenu.FrmSettingNews.PreviewSceneMC(scene, FrmNews.layerMC1, cbbMC.Text, txtEmail.Text);
                await Task.Delay(300);
            }
            else
            {
                string scene = DBConfig.doGetStringValue("MC2", "data");
                FrmKarismaMenu.FrmSettingNews.PreviewSceneMC(scene, FrmNews.layerMC2, cbbMC.Text, txtEmail.Text);
                await Task.Delay(300);
            }
            try
            {
                for (int i = 1; i <= 40; i++)
                {
                    if (!isLooping)
                        break;

                    string imagePath = workingPath + $"\\Thumbnails\\MC\\preview{i}.png";
                    // Dispose of the previous image before loading a new one
                    if (((FrmNews)this.ParentForm).picPreviewTinTuc.Image != null)
                    {
                        ((FrmNews)this.ParentForm).picPreviewTinTuc.Image.Dispose();
                        ((FrmNews)this.ParentForm).picPreviewTinTuc.Image = null;
                    }

                    ((FrmNews)this.ParentForm).picPreviewTinTuc.Image = Image.FromFile(imagePath);
                    await Task.Delay(50);
                }
            }
            catch
            {
                await Task.Delay(200);
                for (int i = 1; i <= 40; i++)
                {
                    if (!isLooping)
                        break;

                    string imagePath = workingPath + $"\\Thumbnails\\MC\\preview{i}.png";
                    // Dispose of the previous image before loading a new one
                    if (((FrmNews)this.ParentForm).picPreviewTinTuc.Image != null)
                    {
                        ((FrmNews)this.ParentForm).picPreviewTinTuc.Image.Dispose();
                        ((FrmNews)this.ParentForm).picPreviewTinTuc.Image = null;
                    }

                    ((FrmNews)this.ParentForm).picPreviewTinTuc.Image = Image.FromFile(imagePath);
                    await Task.Delay(50);
                }
            }

        }

        private async void btnXemTruocDiaDiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDiaDiem.Text))
            {
                string scene = DBConfig.doGetStringValue("DIADIEM1", "data");
                FrmKarismaMenu.FrmSettingNews.PreviewSceneDiaDiem(scene, FrmNews.layerDiaDiem1, cbbDiaDiem.Text, txtDiaDiem.Text);
                await Task.Delay(300);
            }
            else
            {
                string scene = DBConfig.doGetStringValue("DIADIEM2", "data");
                FrmKarismaMenu.FrmSettingNews.PreviewSceneDiaDiem(scene, FrmNews.layerDiaDiem2, cbbDiaDiem.Text, txtDiaDiem.Text);
                await Task.Delay(300);
            }
            try
            {
                for (int i = 1; i <= 10; i++)
                {
                    if (!isLooping)
                        break;

                    string imagePath = workingPath + $"\\Thumbnails\\DiaDiem\\preview{i}.png";
                    // Dispose of the previous image before loading a new one
                    if (((FrmNews)this.ParentForm).picPreviewTinTuc.Image != null)
                    {
                        ((FrmNews)this.ParentForm).picPreviewTinTuc.Image.Dispose();
                        ((FrmNews)this.ParentForm).picPreviewTinTuc.Image = null;
                    }

                    ((FrmNews)this.ParentForm).picPreviewTinTuc.Image = Image.FromFile(imagePath);
                    await Task.Delay(50);
                }
            }
            catch
            {
                await Task.Delay(200);
                for (int i = 1; i <= 10; i++)
                {
                    if (!isLooping)
                        break;

                    string imagePath = workingPath + $"\\Thumbnails\\DiaDiem\\preview{i}.png";
                    // Dispose of the previous image before loading a new one
                    if (((FrmNews)this.ParentForm).picPreviewTinTuc.Image != null)
                    {
                        ((FrmNews)this.ParentForm).picPreviewTinTuc.Image.Dispose();
                        ((FrmNews)this.ParentForm).picPreviewTinTuc.Image = null;
                    }

                    ((FrmNews)this.ParentForm).picPreviewTinTuc.Image = Image.FromFile(imagePath);
                    await Task.Delay(50);
                }
            }
        }

        private async void btnXemTruocTinTuc_Click(object sender, EventArgs e)
        {
            timePreviewTinTuc.Stop();

            if (((FrmNews)this.ParentForm).picPreviewTinTuc.Image != null)
            {
                ((FrmNews)this.ParentForm).picPreviewTinTuc.Image.Dispose();
                ((FrmNews)this.ParentForm).picPreviewTinTuc.Image = null;
            }

            Array.ForEach(Directory.GetFiles(Path.Combine(workingPath, "Thumbnails\\TinTuc")), File.Delete);

            dong1 = lstTinTuc.CurrentRow.Cells[1].Value.ToString();
            dong2 = lstTinTuc.CurrentRow.Cells[2].Value.ToString();
            if (string.IsNullOrWhiteSpace(dong2))
            {
                scene = DBConfig.doGetStringValue("TIN1", "data");
                FrmKarismaMenu.FrmSettingNews.PreviewTinTuc(scene, dong1, dong2);
                await Task.Delay(300);
            }
            else
            {
                await Task.Delay(300);
                scene = DBConfig.doGetStringValue("TIN2", "data");
                FrmKarismaMenu.FrmSettingNews.PreviewTinTuc(scene, dong1, dong2);
            }
            T = 1;
            timePreviewTinTuc.Start();
        }

        private void btnXemTruocPhatBieu_Click(object sender, EventArgs e)
        {
            timePreviewPhatBieu.Stop();
            if (((FrmNews)this.ParentForm).picPreviewPhatBieu.Image != null)
            {
                ((FrmNews)this.ParentForm).picPreviewPhatBieu.Image.Dispose();
                ((FrmNews)this.ParentForm).picPreviewPhatBieu.Image = null;
            }
            Thread.Sleep(10);
            Array.ForEach(Directory.GetFiles(Path.Combine(workingPath, "Thumbnails\\PhatBieu")), File.Delete);
            Thread.Sleep(10);
            tenpb = lstPhatBieu.CurrentRow.Cells[1].Value.ToString();
            dong1pb = lstPhatBieu.CurrentRow.Cells[2].Value.ToString();
            dong2pb = lstPhatBieu.CurrentRow.Cells[3].Value.ToString();
            if (string.IsNullOrWhiteSpace(dong1pb) && string.IsNullOrWhiteSpace(dong2pb))
            {
                scene = DBConfig.doGetStringValue("PHATBIEU", "data");
                FrmKarismaMenu.FrmSettingNews.PreviewPhatBieu(scene, tenpb, dong1pb, dong2pb);
            }
            else if (!string.IsNullOrWhiteSpace(dong1pb) && string.IsNullOrWhiteSpace(dong2pb))
            {
                scene = DBConfig.doGetStringValue("PHATBIEU1", "data");
                FrmKarismaMenu.FrmSettingNews.PreviewPhatBieu(scene, tenpb, dong1pb, dong2pb);
            }
            else
            {
                scene = DBConfig.doGetStringValue("PHATBIEU2", "data");
                FrmKarismaMenu.FrmSettingNews.PreviewPhatBieu(scene, tenpb, dong1pb, dong2pb);
            }
            P = 1;
            timePreviewPhatBieu.Start();

        }


        private void timePreviewPhatBieu_Tick(object sender, EventArgs e)
        {
            try
            {
                if (P <= 30)
                {
                    string imagePath = workingPath + $"\\Thumbnails\\PhatBieu\\preview{P}.png";
                    // Dispose of the previous image before loading a new one
                    if (((FrmNews)this.ParentForm).picPreviewPhatBieu.Image != null)
                    {
                        ((FrmNews)this.ParentForm).picPreviewPhatBieu.Image.Dispose();
                        ((FrmNews)this.ParentForm).picPreviewPhatBieu.Image = null;
                    }
                    ((FrmNews)this.ParentForm).picPreviewPhatBieu.Image = Image.FromFile(imagePath);
                    P++;
                }
            }
            catch { }
        }

        private void timePreviewTinTuc_Tick(object sender, EventArgs e)
        {
            try
            {
                if (T <= 30)
                {
                    string imagePath = workingPath + $"\\Thumbnails\\TinTuc\\preview{T}.png";
                    // Dispose of the previous image before loading a new one
                    if (((FrmNews)this.ParentForm).picPreviewTinTuc.Image != null)
                    {
                        ((FrmNews)this.ParentForm).picPreviewTinTuc.Image.Dispose();
                        ((FrmNews)this.ParentForm).picPreviewTinTuc.Image = null;
                    }
                    ((FrmNews)this.ParentForm).picPreviewTinTuc.Image = Image.FromFile(imagePath);
                    T++;
                }
            }
            catch { }
        }

        private void btnRealTime_Click(object sender, EventArgs e)
        {
            try
            {
                tenpb = lstPhatBieu.CurrentRow.Cells[1].Value.ToString();
                dong1pb = lstPhatBieu.CurrentRow.Cells[2].Value.ToString();
                dong2pb = lstPhatBieu.CurrentRow.Cells[3].Value.ToString();
                FrmKarismaMenu.FrmSettingNews.changeRealTimePhatBieu(FrmNews.layerPhatBieu1, tenpb, dong1pb, dong2pb);
            }
            catch { MessageBox.Show("Không được để trống nội dung"); }
        }

        private void RealTimeTinTuc_Click(object sender, EventArgs e)
        {
            try
            {
                dong1 = lstTinTuc.CurrentRow.Cells[1].Value.ToString();
                dong2 = lstTinTuc.CurrentRow.Cells[2].Value.ToString();
                FrmKarismaMenu.FrmSettingNews.changeRealTimeTinTuc(FrmNews.layerTin1, dong1, dong2);
            }
            catch { MessageBox.Show("Không được để trống nội dung"); }
        }

        public void FillComboBoxWithMCData()
        {
            DBConfig.doGetInfoMC();
            if (DBConfig.MC.Tables.Count > 0)
            {
                DataTable mcTable = DBConfig.MC.Tables[0];
                foreach (DataRow row in mcTable.Rows)
                {
                    string mcName = row["MC"].ToString();
                    string email = row["Email"].ToString();
                    cbbMC.Items.Add(mcName);
                    mcEmailMap.Add(mcName, email);
                }
            }
        }
        private void cbbMC_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedMC = cbbMC.SelectedItem.ToString();
                if (mcEmailMap.ContainsKey(selectedMC))
                {
                    string email = mcEmailMap[selectedMC];
                    txtEmail.Text = email;
                }

                if (((FrmNews)this.ParentForm).picPreviewTinTuc.Image != null)
                {
                    ((FrmNews)this.ParentForm).picPreviewTinTuc.Image.Dispose();
                }
                Thread.Sleep(10);
                Array.ForEach(Directory.GetFiles(Path.Combine(workingPath, "Thumbnails\\MC")), File.Delete);
                Thread.Sleep(10);
            }
            catch { }
        }
        public void FillComboBoxWithDiaDiem()
        {
            DBConfig.doGetInfoDiaDiem();
            if (DBConfig.MC.Tables.Count > 0)
            {
                DataTable mcTable = DBConfig.DiaDiem.Tables[0];
                foreach (DataRow row in mcTable.Rows)
                {
                    string DD1 = row[1].ToString();
                    string DD2 = row[2].ToString();
                    cbbDiaDiem.Items.Add(DD1);
                    DiaDiemMap.Add(DD1, DD2);
                }
            }
        }
        private void cbbDiaDiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedDD = cbbDiaDiem.SelectedItem.ToString();
                if (DiaDiemMap.ContainsKey(selectedDD))
                {
                    string DD = DiaDiemMap[selectedDD];
                    txtDiaDiem.Text = DD;
                }

                if (((FrmNews)this.ParentForm).picPreviewTinTuc.Image != null)
                {
                    ((FrmNews)this.ParentForm).picPreviewTinTuc.Image.Dispose();
                }
                Thread.Sleep(10);
                Array.ForEach(Directory.GetFiles(Path.Combine(workingPath, "Thumbnails\\DiaDiem")), File.Delete);
                Thread.Sleep(10);
            }
            catch { }
        }
        private void loadTableTinTuc()
        {
            try
            {
                lstTinTuc.Rows.Clear();
                DBConfig.doGetTinTuc();
                foreach (DataRow dr in DBConfig.TinTuc.Tables[0].Rows)
                {
                    lstTinTuc.Rows.Add(dr.ItemArray);
                }
            }
            catch { }
        }
        private void loadTablePhatBieu()
        {
            try
            {
                lstPhatBieu.Rows.Clear();
                DBConfig.doGetPhatBieu();
                foreach (DataRow dr in DBConfig.PhatBieu.Tables[0].Rows)
                {
                    lstPhatBieu.Rows.Add(dr.ItemArray);
                }
            }
            catch { }
        }
    }
}
