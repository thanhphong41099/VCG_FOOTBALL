using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using VLeague.src.helper;
using VLeague.src.menu;
using VLeague.src.model;

namespace VLeague
{
    public partial class FrmKarismaMenu : Form
    {
        public static FrmSetting FrmSetting;
        public static FrmDataImport FrmDataImport;
        public static FrmPreMatch FrmPreMatch;
        public static FrmTactical FrmTactical;
        public static FrmInMatchClock FrmInMatchClock;
        public static FrmInMatchStatic FrmInMatchStatic;
        public static FrmSubstitution FrmSubstitution;
        public static FrmVar FrmVar;
        public static FrmPenalty FrmPenalty;
        public static FrmLowerThird FrmLowerThird;
        public static FrmSponsor FrmSponsor;
        public static FrmPostMatch FrmPostMatch;
        public static FrmCupQG FrmCupQG;
        public static FrmCheckLicenseKey FrmCheckLicenseKey;
        public static FrmAbout FrmAbout;
        public static FrmOption FrmOption;
        public static FrmPlayScene FrmPlayScene;


        public static FrmSettingNews FrmSettingNews;
        public static FrmNews FrmNews;


        private Button _lastClickedButton = null;

        public FrmKarismaMenu()
        {

            InitializeComponent();
            panelHorizontal.Visible = false;
            ShowHideButton(false);

        }
        private void FrmKarismaMenu_Load(object sender, EventArgs e)
        {
            string licenseKey = LicenseKeyHandler.readLicenseLocalFile();
            bool isLicenseKeyValid = LicenseKeyHandler.onCheckLicenseKeyIsValid(licenseKey, false);

            if (!isLicenseKeyValid)
            {
                OpenFrmCheckLicenseKey();
                bóngĐáToolStripMenuItem.Enabled = false; //check KEY False sau khi Build
            }
            else
            {
                bóngĐáToolStripMenuItem.Enabled = true;
                bóngĐáToolStripMenuItem_Click(null, null);
            }
        }

        private void OpenFrmCheckLicenseKey()
        {
            if (FrmCheckLicenseKey == null || FrmCheckLicenseKey.IsDisposed)
            {
                FrmCheckLicenseKey = new FrmCheckLicenseKey();
                FrmCheckLicenseKey.MdiParent = this;
                this.panelDesktop.Controls.Add(FrmCheckLicenseKey);
            }

            FrmCheckLicenseKey.BringToFront();
            FrmCheckLicenseKey.Show();

            CenterChildFormInPanel(FrmCheckLicenseKey, panelDesktop);
        }
        private void CenterChildFormInPanel(Form childForm, Panel panel)
        {
            int centerX = (panel.Width - childForm.Width) / 2;
            int centerY = (panel.Height - childForm.Height) / 2;

            childForm.Location = new Point(centerX, centerY);
        }
        private void ChangeButtonColor(Button clickedButton)
        {
            if (_lastClickedButton != null && _lastClickedButton != clickedButton)
            {
                _lastClickedButton.BackColor = Color.FromArgb(41, 39, 40);
            }
            clickedButton.BackColor = Color.FromArgb(100, 150, 200);
            _lastClickedButton = clickedButton;
        }
        private void btnSetup_Click(object sender, EventArgs e)
        {
            if (FrmSetting == null || FrmSetting.IsDisposed)
            {
                FrmSetting = new FrmSetting();
                FrmSetting.MdiParent = this;
                this.panelDesktop.Controls.Add(FrmSetting);
            }

            FrmSetting.BringToFront();
            FrmSetting.Show();
            ChangeButtonColor(sender as Button);
        }

        private void btnDataImport_Click(object sender, EventArgs e)
        {
            //SidePanel.Height = btnDataImport.Height;
            //SidePanel.Top = btnDataImport.Top;
            ChangeButtonColor(sender as Button);

            // Nếu FrmDataImport chưa được khởi tạo hoặc đã bị disposed
            if (FrmDataImport == null || FrmDataImport.IsDisposed)
            {
                FrmDataImport = new FrmDataImport();
                FrmDataImport.MdiParent = this;
                this.panelDesktop.Controls.Add(FrmDataImport);
            }

            FrmDataImport.BringToFront();
            FrmDataImport.Show();
        }


        private void btnPreMatch_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(sender as Button);
            //SidePanel.Height = btnPreMatch.Height;
            //SidePanel.Top = btnPreMatch.Top;

            // Nếu FrmPreMatch chưa được khởi tạo hoặc đã bị disposed
            if (FrmPreMatch == null || FrmPreMatch.IsDisposed)
            {
                FrmPreMatch = new FrmPreMatch();
                FrmPreMatch.MdiParent = this;
                this.panelDesktop.Controls.Add(FrmPreMatch);
            }

            // Đưa FrmPreMatch lên phía trước và hiển thị
            FrmPreMatch.BringToFront();
            FrmPreMatch.Show();
        }

        private void btnInMatchClock_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(sender as Button);
            //SidePanel.Height = btnInMatchClock.Height;
            //SidePanel.Top = btnInMatchClock.Top;

            // Nếu FrmInMatchClock chưa được khởi tạo hoặc đã bị disposed
            if (FrmInMatchClock == null || FrmInMatchClock.IsDisposed)
            {
                FrmInMatchClock = new FrmInMatchClock();
                FrmInMatchClock.MdiParent = this;
                this.panelDesktop.Controls.Add(FrmInMatchClock);
            }

            // Đưa FrmInMatchClock lên phía trước và hiển thị
            FrmInMatchClock.BringToFront();
            FrmInMatchClock.Show();
        }

        private void btnTactical_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(sender as Button);
            //SidePanel.Height = btnTactical.Height;
            //SidePanel.Top = btnTactical.Top;

            // Nếu FrmTactical chưa được khởi tạo hoặc đã bị disposed
            if (FrmTactical == null || FrmTactical.IsDisposed)
            {
                FrmTactical = new FrmTactical();
                FrmTactical.MdiParent = this;
                this.panelDesktop.Controls.Add(FrmTactical);
            }

            // Đưa FrmTactical lên phía trước và hiển thị
            FrmTactical.BringToFront();
            FrmTactical.Show();
        }

        private void btnInMatchStatic_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(sender as Button);
            //SidePanel.Height = btnInMatchStatic.Height;
            //SidePanel.Top = btnInMatchStatic.Top;

            // Nếu FrmInMatchStatic chưa được khởi tạo hoặc đã bị disposed
            if (FrmInMatchStatic == null || FrmInMatchStatic.IsDisposed)
            {
                FrmInMatchStatic = new FrmInMatchStatic();
                FrmInMatchStatic.MdiParent = this;
                this.panelDesktop.Controls.Add(FrmInMatchStatic);
            }

            // Đưa FrmInMatchStatic lên phía trước và hiển thị
            FrmInMatchStatic.BringToFront();
            FrmInMatchStatic.Show();
        }

        private void btnSubstitution_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(sender as Button);
            //SidePanel.Height = btnSubstitution.Height;
            //SidePanel.Top = btnSubstitution.Top;

            // Nếu FrmSubstitution chưa được khởi tạo hoặc đã bị disposed
            if (FrmSubstitution == null || FrmSubstitution.IsDisposed)
            {
                FrmSubstitution = new FrmSubstitution();
                FrmSubstitution.MdiParent = this;
                this.panelDesktop.Controls.Add(FrmSubstitution);
            }

            // Đưa FrmSubstitution lên phía trước và hiển thị
            FrmSubstitution.BringToFront();
            FrmSubstitution.Show();
        }

        private void btnVar_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(sender as Button);
            //SidePanel.Height = btnVar.Height;
            //SidePanel.Top = btnVar.Top;

            // Nếu FrmVar chưa được khởi tạo hoặc đã bị disposed
            if (FrmVar == null || FrmVar.IsDisposed)
            {
                FrmVar = new FrmVar();
                FrmVar.MdiParent = this;
                this.panelDesktop.Controls.Add(FrmVar);
            }

            // Đưa FrmVar lên phía trước và hiển thị
            FrmVar.BringToFront();
            FrmVar.Show();

        }

        private void btnPenalty_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(sender as Button);
            //SidePanel.Height = btnPenalty.Height;
            //SidePanel.Top = btnPenalty.Top;

            // Nếu FrmPenalty chưa được khởi tạo hoặc đã bị disposed
            if (FrmPenalty == null || FrmPenalty.IsDisposed)
            {
                FrmPenalty = new FrmPenalty();
                FrmPenalty.MdiParent = this;
                this.panelDesktop.Controls.Add(FrmPenalty);
            }

            // Đưa FrmPenalty lên phía trước và hiển thị
            FrmPenalty.BringToFront();
            FrmPenalty.Show();
        }

        private void btnLowerThird_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(sender as Button);
            //SidePanel.Height = btnLowerThird.Height;
            //SidePanel.Top = btnLowerThird.Top;

            // Nếu FrmLowerThird chưa được khởi tạo hoặc đã bị disposed
            if (FrmLowerThird == null || FrmLowerThird.IsDisposed)
            {
                FrmLowerThird = new FrmLowerThird();
                FrmLowerThird.MdiParent = this;
                this.panelDesktop.Controls.Add(FrmLowerThird);
            }

            // Đưa FrmLowerThird lên phía trước và hiển thị
            FrmLowerThird.BringToFront();
            FrmLowerThird.Show();
        }

        private void btnSponsor_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(sender as Button);
            //SidePanel.Height = btnSponsor.Height;
            //SidePanel.Top = btnSponsor.Top;

            // Nếu FrmSponsor chưa được khởi tạo hoặc đã bị disposed
            if (FrmSponsor == null || FrmSponsor.IsDisposed)
            {
                FrmSponsor = new FrmSponsor();
                FrmSponsor.MdiParent = this;
                this.panelDesktop.Controls.Add(FrmSponsor);
            }

            // Đưa FrmSponsor lên phía trước và hiển thị
            FrmSponsor.BringToFront();
            FrmSponsor.Show();
        }

        private void btnPostMatch_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(sender as Button);
            //SidePanel.Height = btnPostMatch.Height;
            //SidePanel.Top = btnPostMatch.Top;

            // Nếu FrmPostMatch chưa được khởi tạo hoặc đã bị disposed
            if (FrmPostMatch == null || FrmPostMatch.IsDisposed)
            {
                FrmPostMatch = new FrmPostMatch();
                FrmPostMatch.MdiParent = this;
                this.panelDesktop.Controls.Add(FrmPostMatch);
            }

            // Đưa FrmPostMatch lên phía trước và hiển thị
            FrmPostMatch.BringToFront();
            FrmPostMatch.Show();
        }

        private void btnCupQG_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(sender as Button);
            //SidePanel.Height = btnCupQG.Height;
            //SidePanel.Top = btnCupQG.Top;

            // Nếu FrmCupQG chưa được khởi tạo hoặc đã bị disposed
            if (FrmCupQG == null || FrmCupQG.IsDisposed)
            {
                FrmCupQG = new FrmCupQG();
                FrmCupQG.MdiParent = this;
                this.panelDesktop.Controls.Add(FrmCupQG);
            }

            // Đưa FrmCupQG lên phía trước và hiển thị
            FrmCupQG.BringToFront();
            FrmCupQG.Show();
        }

        private void bóngĐáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowHideButton(true);
            if (FrmSetting == null || FrmSetting.IsDisposed)
            {
                FrmSetting = new FrmSetting();
                FrmSetting.MdiParent = this;
                this.panelDesktop.Controls.Add(FrmSetting);
            }

            FrmSetting.BringToFront();
            FrmSetting.Show();

            ChangeButtonColor(btnSetup);
        }
        private void ShowHideButton(bool showbutton)
        {
            btnSetup.Visible = showbutton;
            btnDataImport.Visible = showbutton;
            btnTactical.Visible = showbutton;
            btnPreMatch.Visible = showbutton;
            btnInMatchClock.Visible = showbutton;
            btnInMatchStatic.Visible = showbutton;
            btnSubstitution.Visible = showbutton;
            btnVar.Visible = showbutton;
            btnPenalty.Visible = showbutton;
            btnLowerThird.Visible = showbutton;
            btnSponsor.Visible = showbutton;
            btnPostMatch.Visible = showbutton;
            //SidePanel.Visible = showbutton;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn đóng ứng dụng không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void horizontalButtonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelHorizontal.Visible = true;
            panel1.Visible = false;

            MoveButtons(panel1, panelHorizontal);

            Button[] buttons = new Button[] {btnSetup,btnDataImport,btnTactical,btnPreMatch,btnInMatchClock,btnInMatchStatic,btnSubstitution,
                btnVar,btnPenalty,btnLowerThird,btnSponsor,btnPostMatch};

            int[] widths = new int[] {120, 155, 140, 140, 170, 160, 160, 120, 120, 170, 150, 160, 160, 160 };

            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Width = widths[i];
                buttons[i].FlatAppearance.BorderSize = 1;
            }
            int currentX = 0;
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Location = new Point(currentX, 0);
                currentX += buttons[i].Width;
            }
        }

        private void verticalButtonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelHorizontal.Visible = false;
            panel1.Visible = true;

            MoveButtons(panelHorizontal, panel1);

            Button[] buttons = new Button[] {btnSetup,btnDataImport,btnTactical,btnPreMatch,btnInMatchClock,btnInMatchStatic,btnSubstitution,
                btnVar,btnPenalty,btnLowerThird,btnSponsor,btnPostMatch};

            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Width = 198;
                buttons[i].FlatAppearance.BorderSize = 0;
            }
            int currentX = 73;
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Location = new Point(0, currentX);
                currentX += 51;
            }

        }
        private void MoveButtons(Panel a, Panel b)
        {
            Button[] buttons = new Button[] {btnSetup, btnDataImport, btnTactical, btnPreMatch, btnInMatchClock, btnInMatchStatic,
                btnSubstitution, btnVar, btnPenalty, btnLowerThird, btnSponsor, btnPostMatch, };

            foreach (var button in buttons)
            {
                a.Controls.Remove(button);
                b.Controls.Add(button);
            }
        }

        private void layoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string licenseKey = LicenseKeyHandler.readLicenseLocalFile();
            bool isLicenseKeyValid = LicenseKeyHandler.onCheckLicenseKeyIsValid(licenseKey, false);

            if (isLicenseKeyValid)
            {
                bóngĐáToolStripMenuItem.Enabled = true;
            }
        }
        private void closeProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form[] forms = { FrmSetting, FrmDataImport, FrmPreMatch, FrmTactical, FrmInMatchClock, FrmInMatchStatic, FrmSubstitution, 
                FrmVar, FrmPenalty, FrmLowerThird, FrmSponsor, FrmPostMatch, FrmCupQG, FrmCheckLicenseKey};

            foreach (Form frm in forms)
            {
                if (frm != null && !frm.IsDisposed)
                {
                    frm.Close();
                }
            }
        }
        public static void closeTabwithFrmDataImport()
        {
            //Đóng tất cả các form trừ FrmDataImport, FrmTactical
            Form[] forms = { FrmPreMatch, FrmInMatchClock, FrmInMatchStatic, FrmSubstitution, FrmVar, FrmPenalty, FrmLowerThird, 
                FrmSponsor, FrmPostMatch, FrmCupQG, FrmCheckLicenseKey };

            foreach (Form frm in forms)
            {
                if (frm != null && !frm.IsDisposed)
                {
                    frm.Close();
                }
            }
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmAbout == null || FrmAbout.IsDisposed)
            {
                FrmAbout = new FrmAbout();
                FrmAbout.MdiParent = this;
                this.panelDesktop.Controls.Add(FrmAbout);
            }

            FrmAbout.BringToFront();
            FrmAbout.Show();

            CenterChildFormInPanel(FrmAbout, panelDesktop);
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmOption == null || FrmOption.IsDisposed)
            {
                FrmOption = new FrmOption();
                FrmOption.MdiParent = this;
                this.panelDesktop.Controls.Add(FrmOption);
            }

            FrmOption.BringToFront();
            FrmOption.Show();

            CenterChildFormInPanel(FrmOption, panelDesktop);
        }

        private void thờiSựToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowHideButton(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FrmSettingNews == null || FrmSettingNews.IsDisposed)
            {
                FrmSettingNews = new FrmSettingNews();
                FrmSettingNews.MdiParent = this;
                this.panelDesktop.Controls.Add(FrmSettingNews);
            }

            FrmSettingNews.BringToFront();
            FrmSettingNews.Show();

            CenterChildFormInPanel(FrmSettingNews, panelDesktop);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (FrmNews == null || FrmNews.IsDisposed)
            {
                FrmNews = new FrmNews();
                FrmNews.MdiParent = this;
                this.panelDesktop.Controls.Add(FrmNews);
            }
            
            FrmNews.ShowNewsControl();
            FrmNews.BringToFront();
            FrmNews.Show();

        }

        private void btnCHUNGANG_Click(object sender, EventArgs e)
        {

            if (FrmNews == null || FrmNews.IsDisposed)
            {
                FrmNews = new FrmNews();
                FrmNews.MdiParent = this;
                this.panelDesktop.Controls.Add(FrmNews);
            }

            FrmNews.ShowChayChuNgang();
            FrmNews.BringToFront();
            FrmNews.Show();
        }

        private void btnCHUDUNG_Click(object sender, EventArgs e)
        {
            if (FrmNews == null || FrmNews.IsDisposed)
            {
                FrmNews = new FrmNews();
                FrmNews.MdiParent = this;
                this.panelDesktop.Controls.Add(FrmNews);
            }

            FrmNews.ShowChayChuDung();
            FrmNews.BringToFront();
            FrmNews.Show();
        }

        private void btnPlayScene_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(sender as Button);

            if (FrmPlayScene == null || FrmPlayScene.IsDisposed)
            {
                FrmPlayScene = new FrmPlayScene();
                FrmPlayScene.MdiParent = this;
                this.panelDesktop.Controls.Add(FrmPlayScene);
            }
            FrmPlayScene.BringToFront();
            FrmPlayScene.Show();
            CenterChildFormInPanel(FrmPlayScene, panelDesktop);
        }           
    }
}
