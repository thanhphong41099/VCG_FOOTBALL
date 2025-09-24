namespace VLeague.src.menu
{
    partial class FrmNews
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNews));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoaHet = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnXemTruocBangChuCuoi = new System.Windows.Forms.Button();
            this.btnXoaBangChuCuoi = new System.Windows.Forms.Button();
            this.btnHienBangChuCuoi = new System.Windows.Forms.Button();
            this.btnXoaHotline = new System.Windows.Forms.Button();
            this.btnHienHotline = new System.Windows.Forms.Button();
            this.btnXoaBreakingNews = new System.Windows.Forms.Button();
            this.btnHienBreakingNews = new System.Windows.Forms.Button();
            this.btnXoaLive = new System.Windows.Forms.Button();
            this.btnHienLive = new System.Windows.Forms.Button();
            this.btnTimeNow = new System.Windows.Forms.Button();
            this.timeNow = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnChayHinhCat = new System.Windows.Forms.Button();
            this.picPreviewTinTuc = new System.Windows.Forms.PictureBox();
            this.picPreviewPhatBieu = new System.Windows.Forms.PictureBox();
            this.panelNews = new System.Windows.Forms.Panel();
            this.chaychungang1 = new VLeague.src.menu.chaychungang();
            this.newsControl1 = new VLeague.src.menu.NewsControl();
            this.chaychudung1 = new VLeague.src.menu.chaychudung();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreviewTinTuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreviewPhatBieu)).BeginInit();
            this.panelNews.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(110)))), ((int)(((byte)(180)))));
            this.panel1.Controls.Add(this.btnXoaHet);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(1110, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 93);
            this.panel1.TabIndex = 392;
            // 
            // btnXoaHet
            // 
            this.btnXoaHet.AutoEllipsis = true;
            this.btnXoaHet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnXoaHet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXoaHet.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnXoaHet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnXoaHet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnXoaHet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaHet.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaHet.ForeColor = System.Drawing.Color.White;
            this.btnXoaHet.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaHet.Image")));
            this.btnXoaHet.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaHet.Location = new System.Drawing.Point(63, 9);
            this.btnXoaHet.Margin = new System.Windows.Forms.Padding(0);
            this.btnXoaHet.Name = "btnXoaHet";
            this.btnXoaHet.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnXoaHet.Size = new System.Drawing.Size(112, 67);
            this.btnXoaHet.TabIndex = 362;
            this.btnXoaHet.Text = "Xóa hết";
            this.btnXoaHet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaHet.UseVisualStyleBackColor = false;
            this.btnXoaHet.Click += new System.EventHandler(this.btnXoaHet_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(1448, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 15);
            this.label13.TabIndex = 381;
            this.label13.Text = "BẢNG CHỮ CUỐI";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(110)))), ((int)(((byte)(180)))));
            this.panel7.Controls.Add(this.btnXemTruocBangChuCuoi);
            this.panel7.Controls.Add(this.btnXoaBangChuCuoi);
            this.panel7.Controls.Add(this.btnHienBangChuCuoi);
            this.panel7.ForeColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(1382, 110);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(230, 93);
            this.panel7.TabIndex = 391;
            // 
            // btnXemTruocBangChuCuoi
            // 
            this.btnXemTruocBangChuCuoi.AutoEllipsis = true;
            this.btnXemTruocBangChuCuoi.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnXemTruocBangChuCuoi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnXemTruocBangChuCuoi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnXemTruocBangChuCuoi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnXemTruocBangChuCuoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemTruocBangChuCuoi.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemTruocBangChuCuoi.ForeColor = System.Drawing.Color.White;
            this.btnXemTruocBangChuCuoi.Image = ((System.Drawing.Image)(resources.GetObject("btnXemTruocBangChuCuoi.Image")));
            this.btnXemTruocBangChuCuoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemTruocBangChuCuoi.Location = new System.Drawing.Point(37, 9);
            this.btnXemTruocBangChuCuoi.Margin = new System.Windows.Forms.Padding(0);
            this.btnXemTruocBangChuCuoi.Name = "btnXemTruocBangChuCuoi";
            this.btnXemTruocBangChuCuoi.Size = new System.Drawing.Size(160, 30);
            this.btnXemTruocBangChuCuoi.TabIndex = 140;
            this.btnXemTruocBangChuCuoi.Text = "Xem trước";
            this.btnXemTruocBangChuCuoi.UseVisualStyleBackColor = false;
            this.btnXemTruocBangChuCuoi.Click += new System.EventHandler(this.btnXemTruocBangChuCuoi_Click);
            // 
            // btnXoaBangChuCuoi
            // 
            this.btnXoaBangChuCuoi.AutoEllipsis = true;
            this.btnXoaBangChuCuoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnXoaBangChuCuoi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnXoaBangChuCuoi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnXoaBangChuCuoi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnXoaBangChuCuoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaBangChuCuoi.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaBangChuCuoi.ForeColor = System.Drawing.Color.White;
            this.btnXoaBangChuCuoi.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoaBangChuCuoi.Location = new System.Drawing.Point(117, 46);
            this.btnXoaBangChuCuoi.Margin = new System.Windows.Forms.Padding(0);
            this.btnXoaBangChuCuoi.Name = "btnXoaBangChuCuoi";
            this.btnXoaBangChuCuoi.Size = new System.Drawing.Size(80, 30);
            this.btnXoaBangChuCuoi.TabIndex = 139;
            this.btnXoaBangChuCuoi.Text = "Xóa";
            this.btnXoaBangChuCuoi.UseVisualStyleBackColor = false;
            this.btnXoaBangChuCuoi.Click += new System.EventHandler(this.btnXoaBangChuCuoi_Click);
            // 
            // btnHienBangChuCuoi
            // 
            this.btnHienBangChuCuoi.AutoEllipsis = true;
            this.btnHienBangChuCuoi.BackColor = System.Drawing.Color.LimeGreen;
            this.btnHienBangChuCuoi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHienBangChuCuoi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHienBangChuCuoi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnHienBangChuCuoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHienBangChuCuoi.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienBangChuCuoi.ForeColor = System.Drawing.Color.White;
            this.btnHienBangChuCuoi.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHienBangChuCuoi.Location = new System.Drawing.Point(37, 46);
            this.btnHienBangChuCuoi.Margin = new System.Windows.Forms.Padding(0);
            this.btnHienBangChuCuoi.Name = "btnHienBangChuCuoi";
            this.btnHienBangChuCuoi.Size = new System.Drawing.Size(80, 30);
            this.btnHienBangChuCuoi.TabIndex = 138;
            this.btnHienBangChuCuoi.Text = "Hiện";
            this.btnHienBangChuCuoi.UseVisualStyleBackColor = false;
            this.btnHienBangChuCuoi.Click += new System.EventHandler(this.btnHienBangChuCuoi_Click);
            // 
            // btnXoaHotline
            // 
            this.btnXoaHotline.AutoEllipsis = true;
            this.btnXoaHotline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnXoaHotline.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnXoaHotline.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnXoaHotline.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnXoaHotline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaHotline.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaHotline.ForeColor = System.Drawing.Color.White;
            this.btnXoaHotline.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoaHotline.Location = new System.Drawing.Point(1382, 255);
            this.btnXoaHotline.Margin = new System.Windows.Forms.Padding(0);
            this.btnXoaHotline.Name = "btnXoaHotline";
            this.btnXoaHotline.Size = new System.Drawing.Size(100, 30);
            this.btnXoaHotline.TabIndex = 389;
            this.btnXoaHotline.Text = "Xóa";
            this.btnXoaHotline.UseVisualStyleBackColor = false;
            this.btnXoaHotline.Click += new System.EventHandler(this.btnXoaHotline_Click);
            // 
            // btnHienHotline
            // 
            this.btnHienHotline.AutoEllipsis = true;
            this.btnHienHotline.BackColor = System.Drawing.Color.LimeGreen;
            this.btnHienHotline.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHienHotline.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHienHotline.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnHienHotline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHienHotline.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienHotline.ForeColor = System.Drawing.Color.White;
            this.btnHienHotline.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHienHotline.Location = new System.Drawing.Point(1382, 219);
            this.btnHienHotline.Margin = new System.Windows.Forms.Padding(0);
            this.btnHienHotline.Name = "btnHienHotline";
            this.btnHienHotline.Size = new System.Drawing.Size(100, 30);
            this.btnHienHotline.TabIndex = 388;
            this.btnHienHotline.Text = "Hotline";
            this.btnHienHotline.UseVisualStyleBackColor = false;
            this.btnHienHotline.Click += new System.EventHandler(this.btnHienHotline_Click);
            // 
            // btnXoaBreakingNews
            // 
            this.btnXoaBreakingNews.AutoEllipsis = true;
            this.btnXoaBreakingNews.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnXoaBreakingNews.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnXoaBreakingNews.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnXoaBreakingNews.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnXoaBreakingNews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaBreakingNews.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaBreakingNews.ForeColor = System.Drawing.Color.White;
            this.btnXoaBreakingNews.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoaBreakingNews.Location = new System.Drawing.Point(1241, 255);
            this.btnXoaBreakingNews.Margin = new System.Windows.Forms.Padding(0);
            this.btnXoaBreakingNews.Name = "btnXoaBreakingNews";
            this.btnXoaBreakingNews.Size = new System.Drawing.Size(100, 30);
            this.btnXoaBreakingNews.TabIndex = 387;
            this.btnXoaBreakingNews.Text = "Xóa";
            this.btnXoaBreakingNews.UseVisualStyleBackColor = false;
            this.btnXoaBreakingNews.Click += new System.EventHandler(this.btnXoaBreakingNews_Click);
            // 
            // btnHienBreakingNews
            // 
            this.btnHienBreakingNews.AutoEllipsis = true;
            this.btnHienBreakingNews.BackColor = System.Drawing.Color.LimeGreen;
            this.btnHienBreakingNews.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHienBreakingNews.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHienBreakingNews.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnHienBreakingNews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHienBreakingNews.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienBreakingNews.ForeColor = System.Drawing.Color.White;
            this.btnHienBreakingNews.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHienBreakingNews.Location = new System.Drawing.Point(1241, 219);
            this.btnHienBreakingNews.Margin = new System.Windows.Forms.Padding(0);
            this.btnHienBreakingNews.Name = "btnHienBreakingNews";
            this.btnHienBreakingNews.Size = new System.Drawing.Size(100, 30);
            this.btnHienBreakingNews.TabIndex = 386;
            this.btnHienBreakingNews.Text = "Breaking News";
            this.btnHienBreakingNews.UseVisualStyleBackColor = false;
            this.btnHienBreakingNews.Click += new System.EventHandler(this.btnHienBreakingNews_Click);
            // 
            // btnXoaLive
            // 
            this.btnXoaLive.AutoEllipsis = true;
            this.btnXoaLive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnXoaLive.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnXoaLive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnXoaLive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnXoaLive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaLive.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLive.ForeColor = System.Drawing.Color.White;
            this.btnXoaLive.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoaLive.Location = new System.Drawing.Point(1110, 255);
            this.btnXoaLive.Margin = new System.Windows.Forms.Padding(0);
            this.btnXoaLive.Name = "btnXoaLive";
            this.btnXoaLive.Size = new System.Drawing.Size(100, 30);
            this.btnXoaLive.TabIndex = 385;
            this.btnXoaLive.Text = "Xóa";
            this.btnXoaLive.UseVisualStyleBackColor = false;
            this.btnXoaLive.Click += new System.EventHandler(this.btnXoaLive_Click);
            // 
            // btnHienLive
            // 
            this.btnHienLive.AutoEllipsis = true;
            this.btnHienLive.BackColor = System.Drawing.Color.LimeGreen;
            this.btnHienLive.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHienLive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHienLive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnHienLive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHienLive.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienLive.ForeColor = System.Drawing.Color.White;
            this.btnHienLive.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHienLive.Location = new System.Drawing.Point(1110, 219);
            this.btnHienLive.Margin = new System.Windows.Forms.Padding(0);
            this.btnHienLive.Name = "btnHienLive";
            this.btnHienLive.Size = new System.Drawing.Size(100, 30);
            this.btnHienLive.TabIndex = 384;
            this.btnHienLive.Text = "Hiện Live";
            this.btnHienLive.UseVisualStyleBackColor = false;
            this.btnHienLive.Click += new System.EventHandler(this.btnHienLive_Click);
            // 
            // btnTimeNow
            // 
            this.btnTimeNow.BackColor = System.Drawing.Color.White;
            this.btnTimeNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimeNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnTimeNow.Location = new System.Drawing.Point(1110, 36);
            this.btnTimeNow.Name = "btnTimeNow";
            this.btnTimeNow.Size = new System.Drawing.Size(230, 50);
            this.btnTimeNow.TabIndex = 394;
            this.btnTimeNow.Text = "Time";
            this.btnTimeNow.UseVisualStyleBackColor = false;
            // 
            // timeNow
            // 
            this.timeNow.Tick += new System.EventHandler(this.timeNow_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1449, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 36);
            this.pictureBox1.TabIndex = 393;
            this.pictureBox1.TabStop = false;
            // 
            // btnChayHinhCat
            // 
            this.btnChayHinhCat.AutoEllipsis = true;
            this.btnChayHinhCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnChayHinhCat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnChayHinhCat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnChayHinhCat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnChayHinhCat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnChayHinhCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChayHinhCat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChayHinhCat.ForeColor = System.Drawing.Color.White;
            this.btnChayHinhCat.Image = ((System.Drawing.Image)(resources.GetObject("btnChayHinhCat.Image")));
            this.btnChayHinhCat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChayHinhCat.Location = new System.Drawing.Point(1501, 219);
            this.btnChayHinhCat.Margin = new System.Windows.Forms.Padding(0);
            this.btnChayHinhCat.Name = "btnChayHinhCat";
            this.btnChayHinhCat.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnChayHinhCat.Size = new System.Drawing.Size(112, 66);
            this.btnChayHinhCat.TabIndex = 390;
            this.btnChayHinhCat.Text = "Hình cắt";
            this.btnChayHinhCat.UseVisualStyleBackColor = false;
            this.btnChayHinhCat.Click += new System.EventHandler(this.btnChayHinhCat_Click);
            // 
            // picPreviewTinTuc
            // 
            this.picPreviewTinTuc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPreviewTinTuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPreviewTinTuc.Image = ((System.Drawing.Image)(resources.GetObject("picPreviewTinTuc.Image")));
            this.picPreviewTinTuc.Location = new System.Drawing.Point(1110, 308);
            this.picPreviewTinTuc.Name = "picPreviewTinTuc";
            this.picPreviewTinTuc.Size = new System.Drawing.Size(503, 273);
            this.picPreviewTinTuc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPreviewTinTuc.TabIndex = 383;
            this.picPreviewTinTuc.TabStop = false;
            // 
            // picPreviewPhatBieu
            // 
            this.picPreviewPhatBieu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPreviewPhatBieu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPreviewPhatBieu.Image = ((System.Drawing.Image)(resources.GetObject("picPreviewPhatBieu.Image")));
            this.picPreviewPhatBieu.Location = new System.Drawing.Point(1110, 605);
            this.picPreviewPhatBieu.Name = "picPreviewPhatBieu";
            this.picPreviewPhatBieu.Size = new System.Drawing.Size(503, 273);
            this.picPreviewPhatBieu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPreviewPhatBieu.TabIndex = 382;
            this.picPreviewPhatBieu.TabStop = false;
            // 
            // panelNews
            // 
            this.panelNews.BackColor = System.Drawing.Color.LightGray;
            this.panelNews.Controls.Add(this.chaychudung1);
            this.panelNews.Controls.Add(this.chaychungang1);
            this.panelNews.Controls.Add(this.newsControl1);
            this.panelNews.Location = new System.Drawing.Point(54, 36);
            this.panelNews.Name = "panelNews";
            this.panelNews.Size = new System.Drawing.Size(1017, 870);
            this.panelNews.TabIndex = 398;
            // 
            // chaychungang1
            // 
            this.chaychungang1.BackColor = System.Drawing.SystemColors.Control;
            this.chaychungang1.Location = new System.Drawing.Point(0, 1);
            this.chaychungang1.Name = "chaychungang1";
            this.chaychungang1.Size = new System.Drawing.Size(1017, 870);
            this.chaychungang1.TabIndex = 1;
            this.chaychungang1.Visible = false;
            // 
            // newsControl1
            // 
            this.newsControl1.BackColor = System.Drawing.SystemColors.Control;
            this.newsControl1.Location = new System.Drawing.Point(0, 0);
            this.newsControl1.Name = "newsControl1";
            this.newsControl1.Size = new System.Drawing.Size(1017, 870);
            this.newsControl1.TabIndex = 0;
            // 
            // chaychudung1
            // 
            this.chaychudung1.Location = new System.Drawing.Point(0, 0);
            this.chaychudung1.Name = "chaychudung1";
            this.chaychudung1.Size = new System.Drawing.Size(1111, 970);
            this.chaychudung1.TabIndex = 2;
            // 
            // FrmNews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1700, 1000);
            this.Controls.Add(this.panelNews);
            this.Controls.Add(this.btnTimeNow);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.btnChayHinhCat);
            this.Controls.Add(this.btnXoaHotline);
            this.Controls.Add(this.btnHienHotline);
            this.Controls.Add(this.btnXoaBreakingNews);
            this.Controls.Add(this.btnHienBreakingNews);
            this.Controls.Add(this.btnXoaLive);
            this.Controls.Add(this.btnHienLive);
            this.Controls.Add(this.picPreviewTinTuc);
            this.Controls.Add(this.picPreviewPhatBieu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNews";
            this.Text = "FrmNews";
            this.Load += new System.EventHandler(this.FrmNews_Load);
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreviewTinTuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreviewPhatBieu)).EndInit();
            this.panelNews.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnXoaHet;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.Button btnXemTruocBangChuCuoi;
        public System.Windows.Forms.Button btnXoaBangChuCuoi;
        public System.Windows.Forms.Button btnHienBangChuCuoi;
        public System.Windows.Forms.Button btnChayHinhCat;
        public System.Windows.Forms.Button btnXoaHotline;
        public System.Windows.Forms.Button btnHienHotline;
        public System.Windows.Forms.Button btnXoaBreakingNews;
        public System.Windows.Forms.Button btnHienBreakingNews;
        public System.Windows.Forms.Button btnXoaLive;
        public System.Windows.Forms.Button btnHienLive;
        public System.Windows.Forms.PictureBox picPreviewTinTuc;
        public System.Windows.Forms.PictureBox picPreviewPhatBieu;
        private System.Windows.Forms.Button btnTimeNow;
        private System.Windows.Forms.Timer timeNow;
        private System.Windows.Forms.Panel panelNews;
        private NewsControl newsControl1;
        private chaychungang chaychungang1;
        private chaychudung chaychudung1;
    }
}