namespace nhom_9
{
    partial class frm_dat_lich
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_tao_moi = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dtp_thoigian = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.rad_hoanthanh = new System.Windows.Forms.RadioButton();
            this.btn_luu_lich = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_noidung = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tieude = new System.Windows.Forms.TextBox();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.dgv_danhsach = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thôngBáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thờiGianThôngBáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sốLầnThôngBáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tùyChỉnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpThờiGiờToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lầnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoTheoNgàyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoTheoTuầnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsach)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Cyan;
            this.splitContainer1.Panel1.Controls.Add(this.btn_tao_moi);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(828, 526);
            this.splitContainer1.SplitterDistance = 212;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_tao_moi
            // 
            this.btn_tao_moi.Location = new System.Drawing.Point(12, 18);
            this.btn_tao_moi.Name = "btn_tao_moi";
            this.btn_tao_moi.Size = new System.Drawing.Size(94, 29);
            this.btn_tao_moi.TabIndex = 0;
            this.btn_tao_moi.Text = "Tạo mới";
            this.btn_tao_moi.UseVisualStyleBackColor = true;
            this.btn_tao_moi.Click += new System.EventHandler(this.btn_tao_moi_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.splitContainer2.Panel1.Controls.Add(this.dtp_thoigian);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.rad_hoanthanh);
            this.splitContainer2.Panel1.Controls.Add(this.btn_luu_lich);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.txt_noidung);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.txt_tieude);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.splitContainer2.Panel2.Controls.Add(this.btn_timkiem);
            this.splitContainer2.Panel2.Controls.Add(this.label3);
            this.splitContainer2.Panel2.Controls.Add(this.txt_timkiem);
            this.splitContainer2.Panel2.Controls.Add(this.dgv_danhsach);
            this.splitContainer2.Size = new System.Drawing.Size(612, 526);
            this.splitContainer2.SplitterDistance = 257;
            this.splitContainer2.TabIndex = 0;
            // 
            // dtp_thoigian
            // 
            this.dtp_thoigian.CustomFormat = "HH:mm  dd/MM/yyyy";
            this.dtp_thoigian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_thoigian.Location = new System.Drawing.Point(87, 219);
            this.dtp_thoigian.Name = "dtp_thoigian";
            this.dtp_thoigian.Size = new System.Drawing.Size(397, 27);
            this.dtp_thoigian.TabIndex = 10;
            this.dtp_thoigian.Value = new System.DateTime(2023, 11, 12, 20, 13, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Thời gian:";
            // 
            // rad_hoanthanh
            // 
            this.rad_hoanthanh.AutoSize = true;
            this.rad_hoanthanh.Location = new System.Drawing.Point(499, 14);
            this.rad_hoanthanh.Name = "rad_hoanthanh";
            this.rad_hoanthanh.Size = new System.Drawing.Size(107, 24);
            this.rad_hoanthanh.TabIndex = 7;
            this.rad_hoanthanh.TabStop = true;
            this.rad_hoanthanh.Text = "Hoàn thành";
            this.rad_hoanthanh.UseVisualStyleBackColor = true;
            // 
            // btn_luu_lich
            // 
            this.btn_luu_lich.Location = new System.Drawing.Point(499, 220);
            this.btn_luu_lich.Name = "btn_luu_lich";
            this.btn_luu_lich.Size = new System.Drawing.Size(94, 29);
            this.btn_luu_lich.TabIndex = 6;
            this.btn_luu_lich.Text = "Lưu lịch";
            this.btn_luu_lich.UseVisualStyleBackColor = true;
            this.btn_luu_lich.Click += new System.EventHandler(this.btn_luu_lich_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nội dung :";
            // 
            // txt_noidung
            // 
            this.txt_noidung.Location = new System.Drawing.Point(87, 55);
            this.txt_noidung.Multiline = true;
            this.txt_noidung.Name = "txt_noidung";
            this.txt_noidung.Size = new System.Drawing.Size(397, 135);
            this.txt_noidung.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tiêu đề :";
            // 
            // txt_tieude
            // 
            this.txt_tieude.Location = new System.Drawing.Point(87, 11);
            this.txt_tieude.Name = "txt_tieude";
            this.txt_tieude.Size = new System.Drawing.Size(397, 27);
            this.txt_tieude.TabIndex = 0;
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(499, 18);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(94, 29);
            this.btn_timkiem.TabIndex = 3;
            this.btn_timkiem.Text = "SREACH";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tìm kiếm";
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(87, 18);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(397, 27);
            this.txt_timkiem.TabIndex = 1;
            // 
            // dgv_danhsach
            // 
            this.dgv_danhsach.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_danhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_danhsach.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgv_danhsach.Location = new System.Drawing.Point(12, 51);
            this.dgv_danhsach.Name = "dgv_danhsach";
            this.dgv_danhsach.RowHeadersWidth = 51;
            this.dgv_danhsach.Size = new System.Drawing.Size(575, 171);
            this.dgv_danhsach.TabIndex = 0;
            this.dgv_danhsach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_danhsach_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngBáoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(212, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thôngBáoToolStripMenuItem
            // 
            this.thôngBáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thờiGianThôngBáoToolStripMenuItem,
            this.sốLầnThôngBáoToolStripMenuItem});
            this.thôngBáoToolStripMenuItem.Name = "thôngBáoToolStripMenuItem";
            this.thôngBáoToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.thôngBáoToolStripMenuItem.Text = "thông báo";
            // 
            // thờiGianThôngBáoToolStripMenuItem
            // 
            this.thờiGianThôngBáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pToolStripMenuItem,
            this.pToolStripMenuItem1,
            this.hToolStripMenuItem,
            this.tùyChỉnhToolStripMenuItem});
            this.thờiGianThôngBáoToolStripMenuItem.Name = "thờiGianThôngBáoToolStripMenuItem";
            this.thờiGianThôngBáoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thờiGianThôngBáoToolStripMenuItem.Text = "thời gian thông báo";
            // 
            // sốLầnThôngBáoToolStripMenuItem
            // 
            this.sốLầnThôngBáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lầnToolStripMenuItem,
            this.báoTheoNgàyToolStripMenuItem,
            this.báoTheoTuầnToolStripMenuItem});
            this.sốLầnThôngBáoToolStripMenuItem.Name = "sốLầnThôngBáoToolStripMenuItem";
            this.sốLầnThôngBáoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sốLầnThôngBáoToolStripMenuItem.Text = "số lần thông báo";
            // 
            // pToolStripMenuItem
            // 
            this.pToolStripMenuItem.Name = "pToolStripMenuItem";
            this.pToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pToolStripMenuItem.Text = "trước 15p";
            // 
            // pToolStripMenuItem1
            // 
            this.pToolStripMenuItem1.Name = "pToolStripMenuItem1";
            this.pToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.pToolStripMenuItem1.Text = "trước 30p";
            // 
            // hToolStripMenuItem
            // 
            this.hToolStripMenuItem.Name = "hToolStripMenuItem";
            this.hToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.hToolStripMenuItem.Text = "trước 1h";
            this.hToolStripMenuItem.Click += new System.EventHandler(this.hToolStripMenuItem_Click);
            // 
            // tùyChỉnhToolStripMenuItem
            // 
            this.tùyChỉnhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpThờiGiờToolStripMenuItem});
            this.tùyChỉnhToolStripMenuItem.Name = "tùyChỉnhToolStripMenuItem";
            this.tùyChỉnhToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tùyChỉnhToolStripMenuItem.Text = "tùy chỉnh";
            // 
            // nhậpThờiGiờToolStripMenuItem
            // 
            this.nhậpThờiGiờToolStripMenuItem.Name = "nhậpThờiGiờToolStripMenuItem";
            this.nhậpThờiGiờToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nhậpThờiGiờToolStripMenuItem.Text = "nhập thời giờ";
            // 
            // lầnToolStripMenuItem
            // 
            this.lầnToolStripMenuItem.Name = "lầnToolStripMenuItem";
            this.lầnToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.lầnToolStripMenuItem.Text = "1 lần";
            // 
            // báoTheoNgàyToolStripMenuItem
            // 
            this.báoTheoNgàyToolStripMenuItem.Name = "báoTheoNgàyToolStripMenuItem";
            this.báoTheoNgàyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.báoTheoNgàyToolStripMenuItem.Text = "báo theo ngày";
            // 
            // báoTheoTuầnToolStripMenuItem
            // 
            this.báoTheoTuầnToolStripMenuItem.Name = "báoTheoTuầnToolStripMenuItem";
            this.báoTheoTuầnToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.báoTheoTuầnToolStripMenuItem.Text = "báo theo tuần";
            // 
            // frm_dat_lich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(828, 526);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_dat_lich";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt lịch";
            this.Load += new System.EventHandler(this.frm_dat_lich_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsach)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private TextBox txt_noidung;
        private Label label1;
        private Button btn_luu_lich;
        private Label label4;
        private TextBox txt_tieude;
        private DataGridView dgv_danhsach;
        private Label label2;
        private RadioButton rad_hoanthanh;
        private Button btn_tao_moi;
        private Button btn_timkiem;
        private Label label3;
        private TextBox txt_timkiem;
        private DateTimePicker dtp_thoigian;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem thôngBáoToolStripMenuItem;
        private ToolStripMenuItem thờiGianThôngBáoToolStripMenuItem;
        private ToolStripMenuItem pToolStripMenuItem;
        private ToolStripMenuItem pToolStripMenuItem1;
        private ToolStripMenuItem hToolStripMenuItem;
        private ToolStripMenuItem tùyChỉnhToolStripMenuItem;
        private ToolStripMenuItem nhậpThờiGiờToolStripMenuItem;
        private ToolStripMenuItem sốLầnThôngBáoToolStripMenuItem;
        private ToolStripMenuItem lầnToolStripMenuItem;
        private ToolStripMenuItem báoTheoNgàyToolStripMenuItem;
        private ToolStripMenuItem báoTheoTuầnToolStripMenuItem;
    }
}