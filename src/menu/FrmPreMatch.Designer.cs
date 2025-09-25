namespace VLeague.src.menu
{
    partial class FrmPreMatch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPreMatch));
            this.groupHome = new System.Windows.Forms.GroupBox();
            this.btnStopHome = new System.Windows.Forms.Button();
            this.labelHomeTac = new System.Windows.Forms.Label();
            this.btnPlayHomeLineup = new System.Windows.Forms.Button();
            this.btnLoadHomeLinup = new System.Windows.Forms.Button();
            this.homeTeamName = new System.Windows.Forms.Label();
            this.awayTeamName = new System.Windows.Forms.Label();
            this.btnStopMatchID = new System.Windows.Forms.Button();
            this.btnMatchID = new System.Windows.Forms.Button();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.btnStopVar = new System.Windows.Forms.Button();
            this.btnStopReferee = new System.Windows.Forms.Button();
            this.btnVar = new System.Windows.Forms.Button();
            this.btnReferee = new System.Windows.Forms.Button();
            this.btnStopGroupSTD = new System.Windows.Forms.Button();
            this.btnGroupSTD = new System.Windows.Forms.Button();
            this.btnStopWeather = new System.Windows.Forms.Button();
            this.btnWeather = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SetBackground = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.stopAll = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupAway = new System.Windows.Forms.GroupBox();
            this.btnStopAway = new System.Windows.Forms.Button();
            this.labelAwayTac = new System.Windows.Forms.Label();
            this.btnResumeAway = new System.Windows.Forms.Button();
            this.btnPlayAwayLineup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupHome.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupAway.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupHome
            // 
            this.groupHome.BackColor = System.Drawing.Color.White;
            this.groupHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupHome.Controls.Add(this.label3);
            this.groupHome.Controls.Add(this.label2);
            this.groupHome.Controls.Add(this.label1);
            this.groupHome.Controls.Add(this.btnStopHome);
            this.groupHome.Controls.Add(this.labelHomeTac);
            this.groupHome.Controls.Add(this.btnPlayHomeLineup);
            this.groupHome.Controls.Add(this.btnLoadHomeLinup);
            this.groupHome.Controls.Add(this.homeTeamName);
            this.groupHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupHome.Location = new System.Drawing.Point(86, 312);
            this.groupHome.Name = "groupHome";
            this.groupHome.Size = new System.Drawing.Size(515, 251);
            this.groupHome.TabIndex = 9;
            this.groupHome.TabStop = false;
            this.groupHome.Text = "HOME LINEUP";
            // 
            // btnStopHome
            // 
            this.btnStopHome.FlatAppearance.BorderSize = 0;
            this.btnStopHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopHome.Image = ((System.Drawing.Image)(resources.GetObject("btnStopHome.Image")));
            this.btnStopHome.Location = new System.Drawing.Point(428, 77);
            this.btnStopHome.Name = "btnStopHome";
            this.btnStopHome.Size = new System.Drawing.Size(60, 55);
            this.btnStopHome.TabIndex = 31;
            this.btnStopHome.UseVisualStyleBackColor = true;
            this.btnStopHome.Click += new System.EventHandler(this.btnStopHome_Click_1);
            // 
            // labelHomeTac
            // 
            this.labelHomeTac.AutoSize = true;
            this.labelHomeTac.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelHomeTac.Location = new System.Drawing.Point(281, 44);
            this.labelHomeTac.Name = "labelHomeTac";
            this.labelHomeTac.Size = new System.Drawing.Size(82, 21);
            this.labelHomeTac.TabIndex = 30;
            this.labelHomeTac.Text = "TACTICAL";
            // 
            // btnPlayHomeLineup
            // 
            this.btnPlayHomeLineup.BackColor = System.Drawing.Color.Green;
            this.btnPlayHomeLineup.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnPlayHomeLineup.ForeColor = System.Drawing.Color.White;
            this.btnPlayHomeLineup.Location = new System.Drawing.Point(229, 82);
            this.btnPlayHomeLineup.Name = "btnPlayHomeLineup";
            this.btnPlayHomeLineup.Size = new System.Drawing.Size(193, 45);
            this.btnPlayHomeLineup.TabIndex = 27;
            this.btnPlayHomeLineup.Text = "RESUME";
            this.btnPlayHomeLineup.UseVisualStyleBackColor = false;
            this.btnPlayHomeLineup.Click += new System.EventHandler(this.btnResumeHomeLineup_Click);
            // 
            // btnLoadHomeLinup
            // 
            this.btnLoadHomeLinup.BackColor = System.Drawing.Color.Green;
            this.btnLoadHomeLinup.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnLoadHomeLinup.ForeColor = System.Drawing.Color.White;
            this.btnLoadHomeLinup.Location = new System.Drawing.Point(30, 82);
            this.btnLoadHomeLinup.Name = "btnLoadHomeLinup";
            this.btnLoadHomeLinup.Size = new System.Drawing.Size(193, 45);
            this.btnLoadHomeLinup.TabIndex = 26;
            this.btnLoadHomeLinup.Text = "PLAY";
            this.btnLoadHomeLinup.UseVisualStyleBackColor = false;
            this.btnLoadHomeLinup.Click += new System.EventHandler(this.btnPlayHomeLinup_Click);
            // 
            // homeTeamName
            // 
            this.homeTeamName.AutoSize = true;
            this.homeTeamName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.homeTeamName.Location = new System.Drawing.Point(36, 44);
            this.homeTeamName.Name = "homeTeamName";
            this.homeTeamName.Size = new System.Drawing.Size(158, 21);
            this.homeTeamName.TabIndex = 25;
            this.homeTeamName.Text = "HOME TEAM NAME";
            // 
            // awayTeamName
            // 
            this.awayTeamName.AutoSize = true;
            this.awayTeamName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.awayTeamName.Location = new System.Drawing.Point(36, 44);
            this.awayTeamName.Name = "awayTeamName";
            this.awayTeamName.Size = new System.Drawing.Size(155, 21);
            this.awayTeamName.TabIndex = 29;
            this.awayTeamName.Text = "AWAY TEAM NAME";
            // 
            // btnStopMatchID
            // 
            this.btnStopMatchID.FlatAppearance.BorderSize = 0;
            this.btnStopMatchID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopMatchID.Image = ((System.Drawing.Image)(resources.GetObject("btnStopMatchID.Image")));
            this.btnStopMatchID.Location = new System.Drawing.Point(282, 38);
            this.btnStopMatchID.Name = "btnStopMatchID";
            this.btnStopMatchID.Size = new System.Drawing.Size(60, 55);
            this.btnStopMatchID.TabIndex = 8;
            this.btnStopMatchID.UseVisualStyleBackColor = true;
            this.btnStopMatchID.Click += new System.EventHandler(this.btnStopMatchID_Click);
            // 
            // btnMatchID
            // 
            this.btnMatchID.BackColor = System.Drawing.Color.LightGray;
            this.btnMatchID.FlatAppearance.BorderSize = 0;
            this.btnMatchID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatchID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMatchID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMatchID.Image = ((System.Drawing.Image)(resources.GetObject("btnMatchID.Image")));
            this.btnMatchID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMatchID.Location = new System.Drawing.Point(31, 40);
            this.btnMatchID.Name = "btnMatchID";
            this.btnMatchID.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnMatchID.Size = new System.Drawing.Size(240, 50);
            this.btnMatchID.TabIndex = 9;
            this.btnMatchID.Text = "MATCH ID";
            this.btnMatchID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMatchID.UseVisualStyleBackColor = false;
            this.btnMatchID.Click += new System.EventHandler(this.btnMatchID_Click);
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.btnStopVar);
            this.groupBox15.Controls.Add(this.btnStopReferee);
            this.groupBox15.Controls.Add(this.btnVar);
            this.groupBox15.Controls.Add(this.btnReferee);
            this.groupBox15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox15.Location = new System.Drawing.Point(812, 69);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(350, 192);
            this.groupBox15.TabIndex = 13;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "REFEREE ";
            // 
            // btnStopVar
            // 
            this.btnStopVar.FlatAppearance.BorderSize = 0;
            this.btnStopVar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopVar.Image = ((System.Drawing.Image)(resources.GetObject("btnStopVar.Image")));
            this.btnStopVar.Location = new System.Drawing.Point(270, 111);
            this.btnStopVar.Name = "btnStopVar";
            this.btnStopVar.Size = new System.Drawing.Size(60, 55);
            this.btnStopVar.TabIndex = 8;
            this.btnStopVar.UseVisualStyleBackColor = true;
            this.btnStopVar.Click += new System.EventHandler(this.btnStopVar_Click);
            // 
            // btnStopReferee
            // 
            this.btnStopReferee.FlatAppearance.BorderSize = 0;
            this.btnStopReferee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopReferee.Image = ((System.Drawing.Image)(resources.GetObject("btnStopReferee.Image")));
            this.btnStopReferee.Location = new System.Drawing.Point(270, 40);
            this.btnStopReferee.Name = "btnStopReferee";
            this.btnStopReferee.Size = new System.Drawing.Size(60, 55);
            this.btnStopReferee.TabIndex = 8;
            this.btnStopReferee.UseVisualStyleBackColor = true;
            this.btnStopReferee.Click += new System.EventHandler(this.btnStopReferee_Click);
            // 
            // btnVar
            // 
            this.btnVar.BackColor = System.Drawing.Color.LightGray;
            this.btnVar.FlatAppearance.BorderSize = 0;
            this.btnVar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnVar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVar.Image = ((System.Drawing.Image)(resources.GetObject("btnVar.Image")));
            this.btnVar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVar.Location = new System.Drawing.Point(19, 113);
            this.btnVar.Name = "btnVar";
            this.btnVar.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnVar.Size = new System.Drawing.Size(240, 50);
            this.btnVar.TabIndex = 9;
            this.btnVar.Text = "VAR OFFICIAL";
            this.btnVar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVar.UseVisualStyleBackColor = false;
            this.btnVar.Click += new System.EventHandler(this.btnVar_Click);
            // 
            // btnReferee
            // 
            this.btnReferee.BackColor = System.Drawing.Color.LightGray;
            this.btnReferee.FlatAppearance.BorderSize = 0;
            this.btnReferee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReferee.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReferee.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReferee.Image = ((System.Drawing.Image)(resources.GetObject("btnReferee.Image")));
            this.btnReferee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReferee.Location = new System.Drawing.Point(19, 42);
            this.btnReferee.Name = "btnReferee";
            this.btnReferee.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnReferee.Size = new System.Drawing.Size(240, 50);
            this.btnReferee.TabIndex = 9;
            this.btnReferee.Text = "MATCH OFFICIAL";
            this.btnReferee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReferee.UseVisualStyleBackColor = false;
            this.btnReferee.Click += new System.EventHandler(this.btnReferee_Click);
            // 
            // btnStopGroupSTD
            // 
            this.btnStopGroupSTD.FlatAppearance.BorderSize = 0;
            this.btnStopGroupSTD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopGroupSTD.Image = ((System.Drawing.Image)(resources.GetObject("btnStopGroupSTD.Image")));
            this.btnStopGroupSTD.Location = new System.Drawing.Point(282, 107);
            this.btnStopGroupSTD.Name = "btnStopGroupSTD";
            this.btnStopGroupSTD.Size = new System.Drawing.Size(60, 55);
            this.btnStopGroupSTD.TabIndex = 8;
            this.btnStopGroupSTD.UseVisualStyleBackColor = true;
            this.btnStopGroupSTD.Click += new System.EventHandler(this.btnStopGroupSTD_Click);
            // 
            // btnGroupSTD
            // 
            this.btnGroupSTD.BackColor = System.Drawing.Color.LightGray;
            this.btnGroupSTD.FlatAppearance.BorderSize = 0;
            this.btnGroupSTD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGroupSTD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGroupSTD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGroupSTD.Image = ((System.Drawing.Image)(resources.GetObject("btnGroupSTD.Image")));
            this.btnGroupSTD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGroupSTD.Location = new System.Drawing.Point(31, 109);
            this.btnGroupSTD.Name = "btnGroupSTD";
            this.btnGroupSTD.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnGroupSTD.Size = new System.Drawing.Size(240, 50);
            this.btnGroupSTD.TabIndex = 9;
            this.btnGroupSTD.Text = "GROUP STANDING";
            this.btnGroupSTD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGroupSTD.UseVisualStyleBackColor = false;
            this.btnGroupSTD.Click += new System.EventHandler(this.btnGroupSTD_Click);
            // 
            // btnStopWeather
            // 
            this.btnStopWeather.FlatAppearance.BorderSize = 0;
            this.btnStopWeather.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopWeather.Image = ((System.Drawing.Image)(resources.GetObject("btnStopWeather.Image")));
            this.btnStopWeather.Location = new System.Drawing.Point(608, 38);
            this.btnStopWeather.Name = "btnStopWeather";
            this.btnStopWeather.Size = new System.Drawing.Size(60, 55);
            this.btnStopWeather.TabIndex = 8;
            this.btnStopWeather.UseVisualStyleBackColor = true;
            this.btnStopWeather.Click += new System.EventHandler(this.btnStopWeather_Click);
            // 
            // btnWeather
            // 
            this.btnWeather.BackColor = System.Drawing.Color.LightGray;
            this.btnWeather.FlatAppearance.BorderSize = 0;
            this.btnWeather.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeather.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnWeather.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnWeather.Image = ((System.Drawing.Image)(resources.GetObject("btnWeather.Image")));
            this.btnWeather.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWeather.Location = new System.Drawing.Point(357, 40);
            this.btnWeather.Name = "btnWeather";
            this.btnWeather.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnWeather.Size = new System.Drawing.Size(240, 50);
            this.btnWeather.TabIndex = 9;
            this.btnWeather.Text = "WEATHER";
            this.btnWeather.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWeather.UseVisualStyleBackColor = false;
            this.btnWeather.Click += new System.EventHandler(this.btnWeather_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(1305, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 21);
            this.label5.TabIndex = 299;
            this.label5.Text = "STOP ALL";
            // 
            // SetBackground
            // 
            this.SetBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(182)))), ((int)(((byte)(213)))));
            this.SetBackground.FlatAppearance.BorderSize = 0;
            this.SetBackground.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetBackground.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.SetBackground.ForeColor = System.Drawing.Color.White;
            this.SetBackground.Location = new System.Drawing.Point(1226, 181);
            this.SetBackground.Name = "SetBackground";
            this.SetBackground.Size = new System.Drawing.Size(154, 52);
            this.SetBackground.TabIndex = 301;
            this.SetBackground.Text = "Set Background";
            this.SetBackground.UseVisualStyleBackColor = false;
            this.SetBackground.Click += new System.EventHandler(this.SetBackground_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(80, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 25);
            this.label12.TabIndex = 329;
            this.label12.Text = "PREMATCH";
            // 
            // stopAll
            // 
            this.stopAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.stopAll.Image = ((System.Drawing.Image)(resources.GetObject("stopAll.Image")));
            this.stopAll.Location = new System.Drawing.Point(1307, 78);
            this.stopAll.Name = "stopAll";
            this.stopAll.Size = new System.Drawing.Size(73, 68);
            this.stopAll.TabIndex = 298;
            this.stopAll.UseVisualStyleBackColor = true;
            this.stopAll.Click += new System.EventHandler(this.stopAll_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStopGroupSTD);
            this.groupBox1.Controls.Add(this.btnStopMatchID);
            this.groupBox1.Controls.Add(this.btnGroupSTD);
            this.groupBox1.Controls.Add(this.btnStopWeather);
            this.groupBox1.Controls.Add(this.btnMatchID);
            this.groupBox1.Controls.Add(this.btnWeather);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(85, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 192);
            this.groupBox1.TabIndex = 330;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INFO";
            // 
            // groupAway
            // 
            this.groupAway.BackColor = System.Drawing.Color.White;
            this.groupAway.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupAway.Controls.Add(this.label4);
            this.groupAway.Controls.Add(this.label6);
            this.groupAway.Controls.Add(this.label7);
            this.groupAway.Controls.Add(this.awayTeamName);
            this.groupAway.Controls.Add(this.btnStopAway);
            this.groupAway.Controls.Add(this.labelAwayTac);
            this.groupAway.Controls.Add(this.btnResumeAway);
            this.groupAway.Controls.Add(this.btnPlayAwayLineup);
            this.groupAway.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupAway.Location = new System.Drawing.Point(647, 312);
            this.groupAway.Name = "groupAway";
            this.groupAway.Size = new System.Drawing.Size(515, 251);
            this.groupAway.TabIndex = 32;
            this.groupAway.TabStop = false;
            this.groupAway.Text = "AWAY LINEUP";
            // 
            // btnStopAway
            // 
            this.btnStopAway.FlatAppearance.BorderSize = 0;
            this.btnStopAway.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopAway.Image = ((System.Drawing.Image)(resources.GetObject("btnStopAway.Image")));
            this.btnStopAway.Location = new System.Drawing.Point(428, 77);
            this.btnStopAway.Name = "btnStopAway";
            this.btnStopAway.Size = new System.Drawing.Size(60, 55);
            this.btnStopAway.TabIndex = 31;
            this.btnStopAway.UseVisualStyleBackColor = true;
            this.btnStopAway.Click += new System.EventHandler(this.btnStopAway_Click);
            // 
            // labelAwayTac
            // 
            this.labelAwayTac.AutoSize = true;
            this.labelAwayTac.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelAwayTac.Location = new System.Drawing.Point(281, 44);
            this.labelAwayTac.Name = "labelAwayTac";
            this.labelAwayTac.Size = new System.Drawing.Size(82, 21);
            this.labelAwayTac.TabIndex = 30;
            this.labelAwayTac.Text = "TACTICAL";
            // 
            // btnResumeAway
            // 
            this.btnResumeAway.BackColor = System.Drawing.Color.Green;
            this.btnResumeAway.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnResumeAway.ForeColor = System.Drawing.Color.White;
            this.btnResumeAway.Location = new System.Drawing.Point(229, 82);
            this.btnResumeAway.Name = "btnResumeAway";
            this.btnResumeAway.Size = new System.Drawing.Size(193, 45);
            this.btnResumeAway.TabIndex = 27;
            this.btnResumeAway.Text = "RESUME";
            this.btnResumeAway.UseVisualStyleBackColor = false;
            this.btnResumeAway.Click += new System.EventHandler(this.btnResumeAway_Click);
            // 
            // btnPlayAwayLineup
            // 
            this.btnPlayAwayLineup.BackColor = System.Drawing.Color.Green;
            this.btnPlayAwayLineup.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnPlayAwayLineup.ForeColor = System.Drawing.Color.White;
            this.btnPlayAwayLineup.Location = new System.Drawing.Point(30, 82);
            this.btnPlayAwayLineup.Name = "btnPlayAwayLineup";
            this.btnPlayAwayLineup.Size = new System.Drawing.Size(193, 45);
            this.btnPlayAwayLineup.TabIndex = 26;
            this.btnPlayAwayLineup.Text = "PLAY";
            this.btnPlayAwayLineup.UseVisualStyleBackColor = false;
            this.btnPlayAwayLineup.Click += new System.EventHandler(this.btnPlayAwayLineup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 21);
            this.label1.TabIndex = 32;
            this.label1.Text = "PLAY: bấm để phát lần đầu - GK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 21);
            this.label2.TabIndex = 33;
            this.label2.Text = "RESUME: Tiếp tục Lineup cho đến hết";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 21);
            this.label3.TabIndex = 34;
            this.label3.Text = "RED: dừng hẳn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 21);
            this.label4.TabIndex = 37;
            this.label4.Text = "RED: dừng hẳn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(267, 21);
            this.label6.TabIndex = 36;
            this.label6.Text = "RESUME: Tiếp tục Lineup cho đến hết";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(228, 21);
            this.label7.TabIndex = 35;
            this.label7.Text = "PLAY: bấm để phát lần đầu - GK";
            // 
            // FrmPreMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1670, 950);
            this.Controls.Add(this.groupAway);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.SetBackground);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.stopAll);
            this.Controls.Add(this.groupBox15);
            this.Controls.Add(this.groupHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPreMatch";
            this.Text = "Pre Match";
            this.Load += new System.EventHandler(this.FrmPreMatch_Load);
            this.groupHome.ResumeLayout(false);
            this.groupHome.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupAway.ResumeLayout(false);
            this.groupAway.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupHome;
        private System.Windows.Forms.Button btnStopMatchID;
        private System.Windows.Forms.Button btnMatchID;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.Button btnStopReferee;
        private System.Windows.Forms.Button btnReferee;
        private System.Windows.Forms.Button btnStopGroupSTD;
        private System.Windows.Forms.Button btnGroupSTD;
        private System.Windows.Forms.Button btnWeather;
        private System.Windows.Forms.Button btnStopWeather;
        private System.Windows.Forms.Button btnStopVar;
        private System.Windows.Forms.Button btnVar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button stopAll;
        private System.Windows.Forms.Button SetBackground;
        private System.Windows.Forms.Label homeTeamName;
        private System.Windows.Forms.Label awayTeamName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLoadHomeLinup;
        private System.Windows.Forms.Button btnPlayHomeLineup;
        private System.Windows.Forms.Label labelHomeTac;
        private System.Windows.Forms.Button btnStopHome;
        private System.Windows.Forms.GroupBox groupAway;
        private System.Windows.Forms.Button btnStopAway;
        private System.Windows.Forms.Label labelAwayTac;
        private System.Windows.Forms.Button btnResumeAway;
        private System.Windows.Forms.Button btnPlayAwayLineup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}