namespace VLeague.src.menu
{
    partial class FrmSettingNews
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
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.logBoxKarisma = new System.Windows.Forms.ListBox();
            this.groupSetting = new System.Windows.Forms.GroupBox();
            this.btnConnectDB = new System.Windows.Forms.Button();
            this.btnOpenConfig = new System.Windows.Forms.Button();
            this.btnDataBrowser = new System.Windows.Forms.Button();
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.btnDisconnectKarisma = new System.Windows.Forms.Button();
            this.btnConnectKarisma = new System.Windows.Forms.Button();
            this.btnWorkingFolderBrowse = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIpAddress = new System.Windows.Forms.TextBox();
            this.label85 = new System.Windows.Forms.Label();
            this.label86 = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.label88 = new System.Windows.Forms.Label();
            this.txtWorkingFolder = new System.Windows.Forms.TextBox();
            this.setBackground1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label24.Location = new System.Drawing.Point(276, 106);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(187, 25);
            this.label24.TabIndex = 334;
            this.label24.Text = "CẤU HÌNH TIN TỨC";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnClearLog);
            this.groupBox1.Controls.Add(this.logBoxKarisma);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(365, 501);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(885, 213);
            this.groupBox1.TabIndex = 333;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "STATUS KARISMA";
            // 
            // btnClearLog
            // 
            this.btnClearLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(182)))), ((int)(((byte)(213)))));
            this.btnClearLog.FlatAppearance.BorderSize = 0;
            this.btnClearLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnClearLog.ForeColor = System.Drawing.Color.White;
            this.btnClearLog.Location = new System.Drawing.Point(759, 217);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(95, 24);
            this.btnClearLog.TabIndex = 17;
            this.btnClearLog.Text = "Clear";
            this.btnClearLog.UseVisualStyleBackColor = false;
            // 
            // logBoxKarisma
            // 
            this.logBoxKarisma.BackColor = System.Drawing.SystemColors.InfoText;
            this.logBoxKarisma.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.logBoxKarisma.ForeColor = System.Drawing.SystemColors.Info;
            this.logBoxKarisma.FormattingEnabled = true;
            this.logBoxKarisma.HorizontalScrollbar = true;
            this.logBoxKarisma.ItemHeight = 15;
            this.logBoxKarisma.Location = new System.Drawing.Point(15, 43);
            this.logBoxKarisma.Name = "logBoxKarisma";
            this.logBoxKarisma.Size = new System.Drawing.Size(848, 139);
            this.logBoxKarisma.TabIndex = 14;
            // 
            // groupSetting
            // 
            this.groupSetting.BackColor = System.Drawing.Color.White;
            this.groupSetting.Controls.Add(this.btnConnectDB);
            this.groupSetting.Controls.Add(this.btnOpenConfig);
            this.groupSetting.Controls.Add(this.btnDataBrowser);
            this.groupSetting.Controls.Add(this.btnSaveConfig);
            this.groupSetting.Controls.Add(this.btnDisconnectKarisma);
            this.groupSetting.Controls.Add(this.btnConnectKarisma);
            this.groupSetting.Controls.Add(this.btnWorkingFolderBrowse);
            this.groupSetting.Controls.Add(this.txtData);
            this.groupSetting.Controls.Add(this.txtPort);
            this.groupSetting.Controls.Add(this.txtIpAddress);
            this.groupSetting.Controls.Add(this.label85);
            this.groupSetting.Controls.Add(this.label86);
            this.groupSetting.Controls.Add(this.label87);
            this.groupSetting.Controls.Add(this.label88);
            this.groupSetting.Controls.Add(this.txtWorkingFolder);
            this.groupSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupSetting.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupSetting.Location = new System.Drawing.Point(365, 165);
            this.groupSetting.Name = "groupSetting";
            this.groupSetting.Size = new System.Drawing.Size(885, 305);
            this.groupSetting.TabIndex = 332;
            this.groupSetting.TabStop = false;
            this.groupSetting.Text = "CONNECTION";
            // 
            // btnConnectDB
            // 
            this.btnConnectDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(182)))), ((int)(((byte)(213)))));
            this.btnConnectDB.FlatAppearance.BorderSize = 0;
            this.btnConnectDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnectDB.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnConnectDB.ForeColor = System.Drawing.Color.White;
            this.btnConnectDB.Location = new System.Drawing.Point(717, 153);
            this.btnConnectDB.Name = "btnConnectDB";
            this.btnConnectDB.Size = new System.Drawing.Size(141, 41);
            this.btnConnectDB.TabIndex = 201;
            this.btnConnectDB.Text = "Connect DB";
            this.btnConnectDB.UseVisualStyleBackColor = false;
            this.btnConnectDB.Click += new System.EventHandler(this.btnConnectDB_Click);
            // 
            // btnOpenConfig
            // 
            this.btnOpenConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(182)))), ((int)(((byte)(213)))));
            this.btnOpenConfig.FlatAppearance.BorderSize = 0;
            this.btnOpenConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenConfig.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnOpenConfig.ForeColor = System.Drawing.Color.White;
            this.btnOpenConfig.Location = new System.Drawing.Point(190, 241);
            this.btnOpenConfig.Name = "btnOpenConfig";
            this.btnOpenConfig.Size = new System.Drawing.Size(150, 36);
            this.btnOpenConfig.TabIndex = 200;
            this.btnOpenConfig.Text = "Open Config File";
            this.btnOpenConfig.UseVisualStyleBackColor = false;
            this.btnOpenConfig.Click += new System.EventHandler(this.btnOpenConfig_Click);
            // 
            // btnDataBrowser
            // 
            this.btnDataBrowser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(182)))), ((int)(((byte)(213)))));
            this.btnDataBrowser.FlatAppearance.BorderSize = 0;
            this.btnDataBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDataBrowser.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDataBrowser.ForeColor = System.Drawing.Color.White;
            this.btnDataBrowser.Location = new System.Drawing.Point(616, 196);
            this.btnDataBrowser.Name = "btnDataBrowser";
            this.btnDataBrowser.Size = new System.Drawing.Size(42, 26);
            this.btnDataBrowser.TabIndex = 190;
            this.btnDataBrowser.Text = "...";
            this.btnDataBrowser.UseVisualStyleBackColor = false;
            this.btnDataBrowser.Click += new System.EventHandler(this.btnDataBrowser_Click);
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(182)))), ((int)(((byte)(213)))));
            this.btnSaveConfig.FlatAppearance.BorderSize = 0;
            this.btnSaveConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveConfig.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSaveConfig.ForeColor = System.Drawing.Color.White;
            this.btnSaveConfig.Location = new System.Drawing.Point(356, 241);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(150, 36);
            this.btnSaveConfig.TabIndex = 189;
            this.btnSaveConfig.Text = "Save Config";
            this.btnSaveConfig.UseVisualStyleBackColor = false;
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // btnDisconnectKarisma
            // 
            this.btnDisconnectKarisma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(182)))), ((int)(((byte)(213)))));
            this.btnDisconnectKarisma.FlatAppearance.BorderSize = 0;
            this.btnDisconnectKarisma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisconnectKarisma.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDisconnectKarisma.ForeColor = System.Drawing.Color.White;
            this.btnDisconnectKarisma.Location = new System.Drawing.Point(717, 86);
            this.btnDisconnectKarisma.Name = "btnDisconnectKarisma";
            this.btnDisconnectKarisma.Size = new System.Drawing.Size(141, 42);
            this.btnDisconnectKarisma.TabIndex = 5;
            this.btnDisconnectKarisma.Text = "Disconnect";
            this.btnDisconnectKarisma.UseVisualStyleBackColor = false;
            this.btnDisconnectKarisma.Click += new System.EventHandler(this.btnDisconnectKarisma_Click);
            // 
            // btnConnectKarisma
            // 
            this.btnConnectKarisma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(182)))), ((int)(((byte)(213)))));
            this.btnConnectKarisma.FlatAppearance.BorderSize = 0;
            this.btnConnectKarisma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnectKarisma.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnConnectKarisma.ForeColor = System.Drawing.Color.White;
            this.btnConnectKarisma.Location = new System.Drawing.Point(717, 43);
            this.btnConnectKarisma.Name = "btnConnectKarisma";
            this.btnConnectKarisma.Size = new System.Drawing.Size(141, 41);
            this.btnConnectKarisma.TabIndex = 5;
            this.btnConnectKarisma.Text = "Connect";
            this.btnConnectKarisma.UseVisualStyleBackColor = false;
            this.btnConnectKarisma.Click += new System.EventHandler(this.btnConnectKarisma_Click);
            // 
            // btnWorkingFolderBrowse
            // 
            this.btnWorkingFolderBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(182)))), ((int)(((byte)(213)))));
            this.btnWorkingFolderBrowse.FlatAppearance.BorderSize = 0;
            this.btnWorkingFolderBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkingFolderBrowse.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnWorkingFolderBrowse.ForeColor = System.Drawing.Color.White;
            this.btnWorkingFolderBrowse.Location = new System.Drawing.Point(616, 156);
            this.btnWorkingFolderBrowse.Name = "btnWorkingFolderBrowse";
            this.btnWorkingFolderBrowse.Size = new System.Drawing.Size(42, 26);
            this.btnWorkingFolderBrowse.TabIndex = 16;
            this.btnWorkingFolderBrowse.Text = "...";
            this.btnWorkingFolderBrowse.UseVisualStyleBackColor = false;
            this.btnWorkingFolderBrowse.Click += new System.EventHandler(this.btnWorkingFolderBrowse_Click);
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtData.Location = new System.Drawing.Point(127, 196);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(479, 25);
            this.txtData.TabIndex = 188;
            // 
            // txtPort
            // 
            this.txtPort.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPort.Location = new System.Drawing.Point(128, 92);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(479, 25);
            this.txtPort.TabIndex = 4;
            // 
            // txtIpAddress
            // 
            this.txtIpAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtIpAddress.Location = new System.Drawing.Point(127, 50);
            this.txtIpAddress.Name = "txtIpAddress";
            this.txtIpAddress.Size = new System.Drawing.Size(479, 25);
            this.txtIpAddress.TabIndex = 4;
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label85.Location = new System.Drawing.Point(20, 95);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(37, 19);
            this.label85.TabIndex = 3;
            this.label85.Text = "Port:";
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label86.Location = new System.Drawing.Point(19, 201);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(41, 19);
            this.label86.TabIndex = 2;
            this.label86.Text = "Data:";
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label87.Location = new System.Drawing.Point(19, 52);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(77, 19);
            this.label87.TabIndex = 2;
            this.label87.Text = "IP Address:";
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label88.Location = new System.Drawing.Point(19, 160);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(105, 19);
            this.label88.TabIndex = 6;
            this.label88.Text = "Working Folder:";
            // 
            // txtWorkingFolder
            // 
            this.txtWorkingFolder.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtWorkingFolder.Location = new System.Drawing.Point(127, 156);
            this.txtWorkingFolder.Name = "txtWorkingFolder";
            this.txtWorkingFolder.Size = new System.Drawing.Size(479, 25);
            this.txtWorkingFolder.TabIndex = 7;
            // 
            // setBackground1
            // 
            this.setBackground1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.setBackground1.FlatAppearance.BorderSize = 0;
            this.setBackground1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setBackground1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.setBackground1.ForeColor = System.Drawing.Color.White;
            this.setBackground1.Location = new System.Drawing.Point(1322, 175);
            this.setBackground1.Name = "setBackground1";
            this.setBackground1.Size = new System.Drawing.Size(141, 41);
            this.setBackground1.TabIndex = 335;
            this.setBackground1.Text = "Set Background 1";
            this.setBackground1.UseVisualStyleBackColor = false;
            this.setBackground1.Click += new System.EventHandler(this.setBackground1_Click);
            // 
            // FrmSettingNews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1670, 950);
            this.Controls.Add(this.setBackground1);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupSetting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSettingNews";
            this.Text = "FrmSettingNews";
            this.Load += new System.EventHandler(this.FrmSettingNews_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupSetting.ResumeLayout(false);
            this.groupSetting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.ListBox logBoxKarisma;
        private System.Windows.Forms.GroupBox groupSetting;
        private System.Windows.Forms.Button btnConnectDB;
        private System.Windows.Forms.Button btnOpenConfig;
        private System.Windows.Forms.Button btnDataBrowser;
        private System.Windows.Forms.Button btnSaveConfig;
        private System.Windows.Forms.Button btnDisconnectKarisma;
        private System.Windows.Forms.Button btnConnectKarisma;
        private System.Windows.Forms.Button btnWorkingFolderBrowse;
        public System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIpAddress;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.Label label88;
        public System.Windows.Forms.TextBox txtWorkingFolder;
        private System.Windows.Forms.Button setBackground1;
    }
}