﻿
namespace TrungTamTinHoc
{
    partial class fGiaoVu
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel24 = new System.Windows.Forms.Panel();
            this.cb_LoaiLop = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.tb_namhoc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.tb_hocky = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.dtgv_lophoc = new System.Windows.Forms.DataGridView();
            this.btn_timkiemLop = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.tb_tenMH = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.bt_Load = new System.Windows.Forms.Button();
            this.bt_NhapDiem = new System.Windows.Forms.Button();
            this.panel25 = new System.Windows.Forms.Panel();
            this.dtgv_nhapdiem = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.id_lop = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_Loai = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel24.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_lophoc)).BeginInit();
            this.panel13.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_nhapdiem)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(947, 681);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(939, 652);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mở lớp";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel24);
            this.tabPage2.Controls.Add(this.panel16);
            this.tabPage2.Controls.Add(this.panel15);
            this.tabPage2.Controls.Add(this.panel14);
            this.tabPage2.Controls.Add(this.btn_timkiemLop);
            this.tabPage2.Controls.Add(this.panel13);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(939, 652);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tìm kiếm lớp";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel24
            // 
            this.panel24.Controls.Add(this.cb_LoaiLop);
            this.panel24.Controls.Add(this.label15);
            this.panel24.Location = new System.Drawing.Point(658, 112);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(234, 66);
            this.panel24.TabIndex = 22;
            // 
            // cb_LoaiLop
            // 
            this.cb_LoaiLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_LoaiLop.FormattingEnabled = true;
            this.cb_LoaiLop.Items.AddRange(new object[] {
            "Chuyên đề",
            "Học phần"});
            this.cb_LoaiLop.Location = new System.Drawing.Point(84, 18);
            this.cb_LoaiLop.Name = "cb_LoaiLop";
            this.cb_LoaiLop.Size = new System.Drawing.Size(123, 28);
            this.cb_LoaiLop.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(3, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 33);
            this.label15.TabIndex = 3;
            this.label15.Text = "Loại:";
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.tb_namhoc);
            this.panel16.Controls.Add(this.label10);
            this.panel16.Location = new System.Drawing.Point(6, 151);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(646, 66);
            this.panel16.TabIndex = 21;
            // 
            // tb_namhoc
            // 
            this.tb_namhoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_namhoc.Location = new System.Drawing.Point(238, 18);
            this.tb_namhoc.Multiline = true;
            this.tb_namhoc.Name = "tb_namhoc";
            this.tb_namhoc.Size = new System.Drawing.Size(327, 36);
            this.tb_namhoc.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 33);
            this.label10.TabIndex = 3;
            this.label10.Text = "Năm học:";
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.tb_hocky);
            this.panel15.Controls.Add(this.label9);
            this.panel15.Location = new System.Drawing.Point(6, 78);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(646, 66);
            this.panel15.TabIndex = 20;
            // 
            // tb_hocky
            // 
            this.tb_hocky.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_hocky.Location = new System.Drawing.Point(238, 18);
            this.tb_hocky.Multiline = true;
            this.tb_hocky.Name = "tb_hocky";
            this.tb_hocky.Size = new System.Drawing.Size(327, 36);
            this.tb_hocky.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 33);
            this.label9.TabIndex = 3;
            this.label9.Text = "Học kỳ:";
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.dtgv_lophoc);
            this.panel14.Location = new System.Drawing.Point(6, 233);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(646, 382);
            this.panel14.TabIndex = 19;
            // 
            // dtgv_lophoc
            // 
            this.dtgv_lophoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_lophoc.Location = new System.Drawing.Point(3, 12);
            this.dtgv_lophoc.Name = "dtgv_lophoc";
            this.dtgv_lophoc.RowHeadersWidth = 51;
            this.dtgv_lophoc.RowTemplate.Height = 24;
            this.dtgv_lophoc.Size = new System.Drawing.Size(640, 362);
            this.dtgv_lophoc.TabIndex = 0;
            // 
            // btn_timkiemLop
            // 
            this.btn_timkiemLop.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiemLop.Location = new System.Drawing.Point(689, 332);
            this.btn_timkiemLop.Name = "btn_timkiemLop";
            this.btn_timkiemLop.Size = new System.Drawing.Size(176, 64);
            this.btn_timkiemLop.TabIndex = 18;
            this.btn_timkiemLop.Text = "Tìm kiếm";
            this.btn_timkiemLop.UseVisualStyleBackColor = true;
            this.btn_timkiemLop.Click += new System.EventHandler(this.btn_timkiemLop_Click);
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.tb_tenMH);
            this.panel13.Controls.Add(this.label8);
            this.panel13.Location = new System.Drawing.Point(6, 6);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(646, 66);
            this.panel13.TabIndex = 17;
            // 
            // tb_tenMH
            // 
            this.tb_tenMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tenMH.Location = new System.Drawing.Point(238, 18);
            this.tb_tenMH.Multiline = true;
            this.tb_tenMH.Name = "tb_tenMH";
            this.tb_tenMH.Size = new System.Drawing.Size(327, 36);
            this.tb_tenMH.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 33);
            this.label8.TabIndex = 3;
            this.label8.Text = "Tên môn học:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.bt_Load);
            this.tabPage3.Controls.Add(this.bt_NhapDiem);
            this.tabPage3.Controls.Add(this.panel25);
            this.tabPage3.Controls.Add(this.flowLayoutPanel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(939, 652);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Nhập điểm học viên";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // bt_Load
            // 
            this.bt_Load.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Load.Location = new System.Drawing.Point(719, 145);
            this.bt_Load.Name = "bt_Load";
            this.bt_Load.Size = new System.Drawing.Size(176, 74);
            this.bt_Load.TabIndex = 16;
            this.bt_Load.Text = "Load";
            this.bt_Load.UseVisualStyleBackColor = true;
            this.bt_Load.Click += new System.EventHandler(this.bt_Load_Click);
            // 
            // bt_NhapDiem
            // 
            this.bt_NhapDiem.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_NhapDiem.Location = new System.Drawing.Point(719, 366);
            this.bt_NhapDiem.Name = "bt_NhapDiem";
            this.bt_NhapDiem.Size = new System.Drawing.Size(176, 74);
            this.bt_NhapDiem.TabIndex = 15;
            this.bt_NhapDiem.Text = "Nhập điểm";
            this.bt_NhapDiem.UseVisualStyleBackColor = true;
            this.bt_NhapDiem.Click += new System.EventHandler(this.bt_NhapDiem_Click);
            // 
            // panel25
            // 
            this.panel25.Controls.Add(this.dtgv_nhapdiem);
            this.panel25.Location = new System.Drawing.Point(9, 98);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(691, 529);
            this.panel25.TabIndex = 14;
            // 
            // dtgv_nhapdiem
            // 
            this.dtgv_nhapdiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_nhapdiem.Location = new System.Drawing.Point(3, 3);
            this.dtgv_nhapdiem.Name = "dtgv_nhapdiem";
            this.dtgv_nhapdiem.RowHeadersWidth = 51;
            this.dtgv_nhapdiem.RowTemplate.Height = 24;
            this.dtgv_nhapdiem.Size = new System.Drawing.Size(674, 523);
            this.dtgv_nhapdiem.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel19);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(897, 86);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.id_lop);
            this.panel19.Controls.Add(this.label13);
            this.panel19.Location = new System.Drawing.Point(3, 3);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(646, 76);
            this.panel19.TabIndex = 12;
            // 
            // id_lop
            // 
            this.id_lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_lop.Location = new System.Drawing.Point(218, 18);
            this.id_lop.Multiline = true;
            this.id_lop.Name = "id_lop";
            this.id_lop.Size = new System.Drawing.Size(327, 36);
            this.id_lop.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(30, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 33);
            this.label13.TabIndex = 3;
            this.label13.Text = "ID lớp:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cb_Loai);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(655, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 76);
            this.panel1.TabIndex = 17;
            // 
            // cb_Loai
            // 
            this.cb_Loai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Loai.FormattingEnabled = true;
            this.cb_Loai.Items.AddRange(new object[] {
            "Chuyên đề",
            "Học phần"});
            this.cb_Loai.Location = new System.Drawing.Point(84, 18);
            this.cb_Loai.Name = "cb_Loai";
            this.cb_Loai.Size = new System.Drawing.Size(123, 28);
            this.cb_Loai.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Loại:";
            // 
            // fGiaoVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 676);
            this.Controls.Add(this.tabControl1);
            this.Name = "fGiaoVu";
            this.Text = "fGiaoVu";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel24.ResumeLayout(false);
            this.panel24.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_lophoc)).EndInit();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel25.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_nhapdiem)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.ComboBox cb_LoaiLop;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.TextBox tb_namhoc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.TextBox tb_hocky;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.DataGridView dtgv_lophoc;
        private System.Windows.Forms.Button btn_timkiemLop;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.TextBox tb_tenMH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.TextBox id_lop;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cb_Loai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.DataGridView dtgv_nhapdiem;
        private System.Windows.Forms.Button bt_NhapDiem;
        private System.Windows.Forms.Button bt_Load;
    }
}