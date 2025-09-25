namespace VLeague.src.menu
{
    partial class FrmDataImport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSaveTeam = new System.Windows.Forms.Button();
            this.labelTimeUpdated = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbbShirtAway = new System.Windows.Forms.ComboBox();
            this.cbbShirtHome = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbbAwayTeam = new System.Windows.Forms.ComboBox();
            this.cbbHomeTeam = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Player_AwayColor = new System.Windows.Forms.PictureBox();
            this.Player_HomeColor = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.picAwayLogo = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbAwayTactic = new System.Windows.Forms.ComboBox();
            this.picHomeLogo = new System.Windows.Forms.PictureBox();
            this.cbbHomeTactic = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvHomePlayer = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvAwayPlayer = new System.Windows.Forms.DataGridView();
            this.btnAddHomePlayer = new System.Windows.Forms.Button();
            this.btnAddAwayPlayer = new System.Windows.Forms.Button();
            this.btnSaveAwayPlayer = new System.Windows.Forms.Button();
            this.btnSaveHomePlayer = new System.Windows.Forms.Button();
            this.btnSortHomePlayer = new System.Windows.Forms.Button();
            this.btnSortAwayPlayer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player_AwayColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player_HomeColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAwayLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHomeLogo)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHomePlayer)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAwayPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSaveTeam);
            this.groupBox1.Controls.Add(this.labelTimeUpdated);
            this.groupBox1.Controls.Add(this.labelStatus);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnLoadData);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(66, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 191);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATA SOURCE";
            // 
            // btnSaveTeam
            // 
            this.btnSaveTeam.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSaveTeam.FlatAppearance.BorderSize = 0;
            this.btnSaveTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveTeam.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSaveTeam.ForeColor = System.Drawing.Color.White;
            this.btnSaveTeam.Location = new System.Drawing.Point(16, 138);
            this.btnSaveTeam.Name = "btnSaveTeam";
            this.btnSaveTeam.Size = new System.Drawing.Size(147, 32);
            this.btnSaveTeam.TabIndex = 5;
            this.btnSaveTeam.Text = "SAVE";
            this.btnSaveTeam.UseVisualStyleBackColor = false;
            this.btnSaveTeam.Click += new System.EventHandler(this.btnSaveTeam_Click);
            // 
            // labelTimeUpdated
            // 
            this.labelTimeUpdated.AutoSize = true;
            this.labelTimeUpdated.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelTimeUpdated.Location = new System.Drawing.Point(100, 113);
            this.labelTimeUpdated.Name = "labelTimeUpdated";
            this.labelTimeUpdated.Size = new System.Drawing.Size(16, 13);
            this.labelTimeUpdated.TabIndex = 4;
            this.labelTimeUpdated.Text = "...";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelStatus.Location = new System.Drawing.Point(58, 79);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(16, 13);
            this.labelStatus.TabIndex = 3;
            this.labelStatus.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(9, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Time Updated:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(9, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Status:";
            // 
            // btnLoadData
            // 
            this.btnLoadData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(182)))), ((int)(((byte)(213)))));
            this.btnLoadData.FlatAppearance.BorderSize = 0;
            this.btnLoadData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadData.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLoadData.ForeColor = System.Drawing.Color.White;
            this.btnLoadData.Location = new System.Drawing.Point(16, 34);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(147, 32);
            this.btnLoadData.TabIndex = 0;
            this.btnLoadData.Text = "LOAD DATA";
            this.btnLoadData.UseVisualStyleBackColor = false;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.cbbShirtAway);
            this.groupBox2.Controls.Add(this.cbbShirtHome);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cbbAwayTeam);
            this.groupBox2.Controls.Add(this.cbbHomeTeam);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Player_AwayColor);
            this.groupBox2.Controls.Add(this.Player_HomeColor);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.picAwayLogo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbbAwayTactic);
            this.groupBox2.Controls.Add(this.picHomeLogo);
            this.groupBox2.Controls.Add(this.cbbHomeTactic);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(261, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1059, 215);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(250, 173);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 338;
            this.label12.Text = "T-SHIRT";
            // 
            // cbbShirtAway
            // 
            this.cbbShirtAway.BackColor = System.Drawing.Color.White;
            this.cbbShirtAway.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbShirtAway.FormattingEnabled = true;
            this.cbbShirtAway.Items.AddRange(new object[] {
            "Lineup 1",
            "Lineup 2",
            "Lineup 3"});
            this.cbbShirtAway.Location = new System.Drawing.Point(338, 165);
            this.cbbShirtAway.Name = "cbbShirtAway";
            this.cbbShirtAway.Size = new System.Drawing.Size(195, 28);
            this.cbbShirtAway.TabIndex = 337;
            this.cbbShirtAway.SelectedIndexChanged += new System.EventHandler(this.cbbShirtAway_SelectedIndexChanged);
            // 
            // cbbShirtHome
            // 
            this.cbbShirtHome.BackColor = System.Drawing.Color.White;
            this.cbbShirtHome.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbShirtHome.FormattingEnabled = true;
            this.cbbShirtHome.Items.AddRange(new object[] {
            "Lineup 1",
            "Lineup 2",
            "Lineup 3"});
            this.cbbShirtHome.Location = new System.Drawing.Point(12, 164);
            this.cbbShirtHome.Name = "cbbShirtHome";
            this.cbbShirtHome.Size = new System.Drawing.Size(195, 28);
            this.cbbShirtHome.TabIndex = 336;
            this.cbbShirtHome.SelectedIndexChanged += new System.EventHandler(this.cbbShirtHome_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(245, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 335;
            this.label11.Text = "TACTICAL";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(252, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 300;
            this.label10.Text = "COLOR";
            // 
            // cbbAwayTeam
            // 
            this.cbbAwayTeam.BackColor = System.Drawing.Color.White;
            this.cbbAwayTeam.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbAwayTeam.FormattingEnabled = true;
            this.cbbAwayTeam.Location = new System.Drawing.Point(338, 83);
            this.cbbAwayTeam.Name = "cbbAwayTeam";
            this.cbbAwayTeam.Size = new System.Drawing.Size(195, 28);
            this.cbbAwayTeam.TabIndex = 297;
            this.cbbAwayTeam.SelectedIndexChanged += new System.EventHandler(this.cbbAwayTeam_SelectedIndexChanged);
            // 
            // cbbHomeTeam
            // 
            this.cbbHomeTeam.BackColor = System.Drawing.Color.White;
            this.cbbHomeTeam.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbHomeTeam.FormattingEnabled = true;
            this.cbbHomeTeam.Location = new System.Drawing.Point(12, 83);
            this.cbbHomeTeam.Name = "cbbHomeTeam";
            this.cbbHomeTeam.Size = new System.Drawing.Size(195, 28);
            this.cbbHomeTeam.TabIndex = 296;
            this.cbbHomeTeam.SelectedIndexChanged += new System.EventHandler(this.cbbHomeTeam_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(217, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 21);
            this.label1.TabIndex = 295;
            this.label1.Text = "TEAM SELECT";
            // 
            // Player_AwayColor
            // 
            this.Player_AwayColor.BackColor = System.Drawing.SystemColors.Control;
            this.Player_AwayColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Player_AwayColor.Location = new System.Drawing.Point(277, 86);
            this.Player_AwayColor.Name = "Player_AwayColor";
            this.Player_AwayColor.Size = new System.Drawing.Size(50, 28);
            this.Player_AwayColor.TabIndex = 293;
            this.Player_AwayColor.TabStop = false;
            this.Player_AwayColor.Click += new System.EventHandler(this.Player_AwayColor_Click);
            // 
            // Player_HomeColor
            // 
            this.Player_HomeColor.BackColor = System.Drawing.SystemColors.Control;
            this.Player_HomeColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Player_HomeColor.Location = new System.Drawing.Point(219, 86);
            this.Player_HomeColor.Name = "Player_HomeColor";
            this.Player_HomeColor.Size = new System.Drawing.Size(52, 28);
            this.Player_HomeColor.TabIndex = 292;
            this.Player_HomeColor.TabStop = false;
            this.Player_HomeColor.Click += new System.EventHandler(this.Player_HomeColor_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(799, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(211, 21);
            this.label9.TabIndex = 334;
            this.label9.Text = "AWAY TEAM";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(395, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 21);
            this.label5.TabIndex = 291;
            this.label5.Text = "AWAY TEAM";
            // 
            // picAwayLogo
            // 
            this.picAwayLogo.Location = new System.Drawing.Point(840, 67);
            this.picAwayLogo.Name = "picAwayLogo";
            this.picAwayLogo.Size = new System.Drawing.Size(138, 98);
            this.picAwayLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAwayLogo.TabIndex = 333;
            this.picAwayLogo.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(61, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 21);
            this.label4.TabIndex = 290;
            this.label4.Text = "HOME TEAM";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(574, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(205, 21);
            this.label8.TabIndex = 332;
            this.label8.Text = "HOME TEAM";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbbAwayTactic
            // 
            this.cbbAwayTactic.BackColor = System.Drawing.Color.White;
            this.cbbAwayTactic.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbAwayTactic.FormattingEnabled = true;
            this.cbbAwayTactic.Location = new System.Drawing.Point(338, 123);
            this.cbbAwayTactic.Name = "cbbAwayTactic";
            this.cbbAwayTactic.Size = new System.Drawing.Size(195, 28);
            this.cbbAwayTactic.TabIndex = 289;
            this.cbbAwayTactic.SelectedIndexChanged += new System.EventHandler(this.cbbAwayTactic_SelectedIndexChanged);
            // 
            // picHomeLogo
            // 
            this.picHomeLogo.Location = new System.Drawing.Point(609, 67);
            this.picHomeLogo.Name = "picHomeLogo";
            this.picHomeLogo.Size = new System.Drawing.Size(138, 98);
            this.picHomeLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHomeLogo.TabIndex = 331;
            this.picHomeLogo.TabStop = false;
            // 
            // cbbHomeTactic
            // 
            this.cbbHomeTactic.BackColor = System.Drawing.Color.White;
            this.cbbHomeTactic.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbHomeTactic.FormattingEnabled = true;
            this.cbbHomeTactic.Location = new System.Drawing.Point(12, 122);
            this.cbbHomeTactic.Name = "cbbHomeTactic";
            this.cbbHomeTactic.Size = new System.Drawing.Size(195, 28);
            this.cbbHomeTactic.TabIndex = 287;
            this.cbbHomeTactic.SelectedIndexChanged += new System.EventHandler(this.cbbHomeTactic_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.dgvHomePlayer);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(66, 262);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(680, 597);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(238, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 21);
            this.label6.TabIndex = 296;
            this.label6.Text = "HOME PLAYERS LIST";
            // 
            // dgvHomePlayer
            // 
            this.dgvHomePlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHomePlayer.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHomePlayer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHomePlayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHomePlayer.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHomePlayer.GridColor = System.Drawing.Color.Black;
            this.dgvHomePlayer.Location = new System.Drawing.Point(12, 48);
            this.dgvHomePlayer.MultiSelect = false;
            this.dgvHomePlayer.Name = "dgvHomePlayer";
            this.dgvHomePlayer.RowHeadersWidth = 51;
            this.dgvHomePlayer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHomePlayer.Size = new System.Drawing.Size(655, 535);
            this.dgvHomePlayer.TabIndex = 5;
            this.dgvHomePlayer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvHomePlayer_MouseDown);
            this.dgvHomePlayer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvHomePlayer_MouseMove);
            this.dgvHomePlayer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgvHomePlayer_MouseUp);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.dgvAwayPlayer);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F);
            this.groupBox5.Location = new System.Drawing.Point(756, 262);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(680, 597);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(247, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 21);
            this.label7.TabIndex = 296;
            this.label7.Text = "AWAY PLAYERS LIST";
            // 
            // dgvAwayPlayer
            // 
            this.dgvAwayPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAwayPlayer.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAwayPlayer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAwayPlayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAwayPlayer.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAwayPlayer.GridColor = System.Drawing.Color.Black;
            this.dgvAwayPlayer.Location = new System.Drawing.Point(12, 48);
            this.dgvAwayPlayer.MultiSelect = false;
            this.dgvAwayPlayer.Name = "dgvAwayPlayer";
            this.dgvAwayPlayer.RowHeadersWidth = 51;
            this.dgvAwayPlayer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAwayPlayer.Size = new System.Drawing.Size(655, 535);
            this.dgvAwayPlayer.TabIndex = 5;
            this.dgvAwayPlayer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvAwayPlayer_MouseDown);
            this.dgvAwayPlayer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvAwayPlayer_MouseMove);
            this.dgvAwayPlayer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgvAwayPlayer_MouseUp);
            // 
            // btnAddHomePlayer
            // 
            this.btnAddHomePlayer.BackColor = System.Drawing.Color.LightGray;
            this.btnAddHomePlayer.FlatAppearance.BorderSize = 0;
            this.btnAddHomePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddHomePlayer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddHomePlayer.Location = new System.Drawing.Point(563, 865);
            this.btnAddHomePlayer.Name = "btnAddHomePlayer";
            this.btnAddHomePlayer.Size = new System.Drawing.Size(183, 30);
            this.btnAddHomePlayer.TabIndex = 335;
            this.btnAddHomePlayer.Text = "LƯU CẦU THỦ MỚI";
            this.btnAddHomePlayer.UseVisualStyleBackColor = false;
            this.btnAddHomePlayer.Visible = false;
            this.btnAddHomePlayer.Click += new System.EventHandler(this.btnAddHomePlayer_Click);
            // 
            // btnAddAwayPlayer
            // 
            this.btnAddAwayPlayer.BackColor = System.Drawing.Color.LightGray;
            this.btnAddAwayPlayer.FlatAppearance.BorderSize = 0;
            this.btnAddAwayPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAwayPlayer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddAwayPlayer.Location = new System.Drawing.Point(1253, 865);
            this.btnAddAwayPlayer.Name = "btnAddAwayPlayer";
            this.btnAddAwayPlayer.Size = new System.Drawing.Size(183, 30);
            this.btnAddAwayPlayer.TabIndex = 336;
            this.btnAddAwayPlayer.Text = "LƯU CẦU THỦ MỚI";
            this.btnAddAwayPlayer.UseVisualStyleBackColor = false;
            this.btnAddAwayPlayer.Visible = false;
            this.btnAddAwayPlayer.Click += new System.EventHandler(this.btnAddAwayPlayer_Click);
            // 
            // btnSaveAwayPlayer
            // 
            this.btnSaveAwayPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(182)))), ((int)(((byte)(70)))));
            this.btnSaveAwayPlayer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSaveAwayPlayer.FlatAppearance.BorderSize = 0;
            this.btnSaveAwayPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAwayPlayer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSaveAwayPlayer.ForeColor = System.Drawing.Color.White;
            this.btnSaveAwayPlayer.Location = new System.Drawing.Point(1078, 865);
            this.btnSaveAwayPlayer.Name = "btnSaveAwayPlayer";
            this.btnSaveAwayPlayer.Size = new System.Drawing.Size(121, 30);
            this.btnSaveAwayPlayer.TabIndex = 32;
            this.btnSaveAwayPlayer.Text = "SAVE";
            this.btnSaveAwayPlayer.UseVisualStyleBackColor = false;
            this.btnSaveAwayPlayer.Click += new System.EventHandler(this.btnSaveAwayPlayer_Click);
            // 
            // btnSaveHomePlayer
            // 
            this.btnSaveHomePlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(182)))), ((int)(((byte)(70)))));
            this.btnSaveHomePlayer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSaveHomePlayer.FlatAppearance.BorderSize = 0;
            this.btnSaveHomePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveHomePlayer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSaveHomePlayer.ForeColor = System.Drawing.Color.White;
            this.btnSaveHomePlayer.Location = new System.Drawing.Point(387, 865);
            this.btnSaveHomePlayer.Name = "btnSaveHomePlayer";
            this.btnSaveHomePlayer.Size = new System.Drawing.Size(121, 30);
            this.btnSaveHomePlayer.TabIndex = 337;
            this.btnSaveHomePlayer.Text = "SAVE";
            this.btnSaveHomePlayer.UseVisualStyleBackColor = false;
            this.btnSaveHomePlayer.Click += new System.EventHandler(this.btnSaveHomePlayer_Click);
            // 
            // btnSortHomePlayer
            // 
            this.btnSortHomePlayer.BackColor = System.Drawing.Color.LightGray;
            this.btnSortHomePlayer.FlatAppearance.BorderSize = 0;
            this.btnSortHomePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortHomePlayer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSortHomePlayer.Location = new System.Drawing.Point(271, 865);
            this.btnSortHomePlayer.Name = "btnSortHomePlayer";
            this.btnSortHomePlayer.Size = new System.Drawing.Size(110, 30);
            this.btnSortHomePlayer.TabIndex = 338;
            this.btnSortHomePlayer.Text = "SORT";
            this.btnSortHomePlayer.UseVisualStyleBackColor = false;
            this.btnSortHomePlayer.Click += new System.EventHandler(this.btnSortHomePlayer_Click);
            // 
            // btnSortAwayPlayer
            // 
            this.btnSortAwayPlayer.BackColor = System.Drawing.Color.LightGray;
            this.btnSortAwayPlayer.FlatAppearance.BorderSize = 0;
            this.btnSortAwayPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortAwayPlayer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSortAwayPlayer.Location = new System.Drawing.Point(962, 865);
            this.btnSortAwayPlayer.Name = "btnSortAwayPlayer";
            this.btnSortAwayPlayer.Size = new System.Drawing.Size(110, 30);
            this.btnSortAwayPlayer.TabIndex = 339;
            this.btnSortAwayPlayer.Text = "SORT";
            this.btnSortAwayPlayer.UseVisualStyleBackColor = false;
            this.btnSortAwayPlayer.Click += new System.EventHandler(this.btnSortAwayPlayer_Click);
            // 
            // FrmDataImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1670, 950);
            this.Controls.Add(this.btnSortAwayPlayer);
            this.Controls.Add(this.btnSortHomePlayer);
            this.Controls.Add(this.btnSaveHomePlayer);
            this.Controls.Add(this.btnSaveAwayPlayer);
            this.Controls.Add(this.btnAddAwayPlayer);
            this.Controls.Add(this.btnAddHomePlayer);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDataImport";
            this.Text = "Data Import";
            this.Load += new System.EventHandler(this.FrmDataImport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player_AwayColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player_HomeColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAwayLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHomeLogo)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHomePlayer)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAwayPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbbHomeTactic;
        private System.Windows.Forms.ComboBox cbbAwayTactic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox Player_HomeColor;
        private System.Windows.Forms.PictureBox Player_AwayColor;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvHomePlayer;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvAwayPlayer;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelTimeUpdated;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picHomeLogo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox picAwayLogo;
        private System.Windows.Forms.ComboBox cbbHomeTeam;
        private System.Windows.Forms.ComboBox cbbAwayTeam;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAddHomePlayer;
        private System.Windows.Forms.Button btnAddAwayPlayer;
        private System.Windows.Forms.Button btnSaveAwayPlayer;
        private System.Windows.Forms.Button btnSaveHomePlayer;
        private System.Windows.Forms.Button btnSortHomePlayer;
        private System.Windows.Forms.Button btnSortAwayPlayer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbbShirtAway;
        private System.Windows.Forms.ComboBox cbbShirtHome;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSaveTeam;
    }
}