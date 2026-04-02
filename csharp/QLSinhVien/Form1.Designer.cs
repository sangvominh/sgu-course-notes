namespace QLSinhVien
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            txtHoTen = new TextBox();
            txtMSSV = new TextBox();
            label3 = new Label();
            label4 = new Label();
            dtpNS = new DateTimePicker();
            TxtDienThoai = new TextBox();
            label5 = new Label();
            txtDiaChi = new TextBox();
            label6 = new Label();
            txtNienKhoa = new TextBox();
            label7 = new Label();
            groupBox1 = new GroupBox();
            raDaiHoc = new RadioButton();
            raBang2 = new RadioButton();
            raCaoDang = new RadioButton();
            label8 = new Label();
            cboCN = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            txtBang1 = new TextBox();
            txtCty = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnReset = new Button();
            btnThoat = new Button();
            lvwSinhVien = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lvwSinhVien).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(162, 9);
            label1.Name = "label1";
            label1.Size = new Size(399, 41);
            label1.TabIndex = 0;
            label1.Text = "Quản lý thông tin sinh viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 88);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 1;
            label2.Text = "Họ tên";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(128, 85);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(210, 27);
            txtHoTen.TabIndex = 2;
            txtHoTen.TextChanged += textBox1_TextChanged;
            // 
            // txtMSSV
            // 
            txtMSSV.Location = new Point(128, 118);
            txtMSSV.Name = "txtMSSV";
            txtMSSV.Size = new Size(141, 27);
            txtMSSV.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 121);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 3;
            label3.Text = "Mã số SV";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 155);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 5;
            label4.Text = "Ngày sinh";
            // 
            // dtpNS
            // 
            dtpNS.Location = new Point(128, 155);
            dtpNS.Name = "dtpNS";
            dtpNS.Size = new Size(171, 27);
            dtpNS.TabIndex = 6;
            // 
            // TxtDienThoai
            // 
            TxtDienThoai.Location = new Point(496, 118);
            TxtDienThoai.Name = "TxtDienThoai";
            TxtDienThoai.Size = new Size(141, 27);
            TxtDienThoai.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(399, 121);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 9;
            label5.Text = "Điện thoại";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(496, 85);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(210, 27);
            txtDiaChi.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(399, 88);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 7;
            label6.Text = "Địa chỉ";
            // 
            // txtNienKhoa
            // 
            txtNienKhoa.Location = new Point(496, 157);
            txtNienKhoa.Name = "txtNienKhoa";
            txtNienKhoa.Size = new Size(141, 27);
            txtNienKhoa.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(399, 160);
            label7.Name = "label7";
            label7.Size = new Size(76, 20);
            label7.TabIndex = 11;
            label7.Text = "Niên khóa";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCty);
            groupBox1.Controls.Add(txtBang1);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(cboCN);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(raCaoDang);
            groupBox1.Controls.Add(raBang2);
            groupBox1.Controls.Add(raDaiHoc);
            groupBox1.Location = new Point(28, 206);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(678, 143);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Loại hình";
            // 
            // raDaiHoc
            // 
            raDaiHoc.AutoSize = true;
            raDaiHoc.Location = new Point(61, 26);
            raDaiHoc.Name = "raDaiHoc";
            raDaiHoc.Size = new Size(81, 24);
            raDaiHoc.TabIndex = 0;
            raDaiHoc.TabStop = true;
            raDaiHoc.Text = "Đại học";
            raDaiHoc.UseVisualStyleBackColor = true;
            // 
            // raBang2
            // 
            raBang2.AutoSize = true;
            raBang2.Location = new Point(269, 26);
            raBang2.Name = "raBang2";
            raBang2.Size = new Size(88, 24);
            raBang2.TabIndex = 1;
            raBang2.TabStop = true;
            raBang2.Text = "Bằng hai";
            raBang2.UseVisualStyleBackColor = true;
            // 
            // raCaoDang
            // 
            raCaoDang.AutoSize = true;
            raCaoDang.Location = new Point(492, 26);
            raCaoDang.Name = "raCaoDang";
            raCaoDang.Size = new Size(94, 24);
            raCaoDang.TabIndex = 2;
            raCaoDang.TabStop = true;
            raCaoDang.Text = "Cao đẳng";
            raCaoDang.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 62);
            label8.Name = "label8";
            label8.Size = new Size(102, 20);
            label8.TabIndex = 14;
            label8.Text = "Chuyên ngành";
            // 
            // cboCN
            // 
            cboCN.FormattingEnabled = true;
            cboCN.Location = new Point(23, 93);
            cboCN.Name = "cboCN";
            cboCN.Size = new Size(151, 28);
            cboCN.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(227, 65);
            label9.Name = "label9";
            label9.Size = new Size(55, 20);
            label9.TabIndex = 16;
            label9.Text = "Bằng 1";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(227, 101);
            label10.Name = "label10";
            label10.Size = new Size(68, 20);
            label10.TabIndex = 17;
            label10.Text = "Công tác";
            // 
            // txtBang1
            // 
            txtBang1.Location = new Point(308, 62);
            txtBang1.Name = "txtBang1";
            txtBang1.Size = new Size(141, 27);
            txtBang1.TabIndex = 14;
            // 
            // txtCty
            // 
            txtCty.Location = new Point(308, 98);
            txtCty.Name = "txtCty";
            txtCty.Size = new Size(141, 27);
            txtCty.TabIndex = 18;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(31, 355);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 14;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(162, 355);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 15;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(297, 355);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 16;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(612, 355);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 17;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(612, 714);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 18;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // lvwSinhVien
            // 
            lvwSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            lvwSinhVien.Location = new Point(31, 409);
            lvwSinhVien.Name = "lvwSinhVien";
            lvwSinhVien.RowHeadersWidth = 51;
            lvwSinhVien.Size = new Size(675, 299);
            lvwSinhVien.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 755);
            Controls.Add(lvwSinhVien);
            Controls.Add(btnThoat);
            Controls.Add(btnReset);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(groupBox1);
            Controls.Add(txtNienKhoa);
            Controls.Add(label7);
            Controls.Add(TxtDienThoai);
            Controls.Add(label5);
            Controls.Add(txtDiaChi);
            Controls.Add(label6);
            Controls.Add(dtpNS);
            Controls.Add(label4);
            Controls.Add(txtMSSV);
            Controls.Add(label3);
            Controls.Add(txtHoTen);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Quản Lý Sinh Viên";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lvwSinhVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtHoTen;
        private TextBox txtMSSV;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpNS;
        private TextBox TxtDienThoai;
        private Label label5;
        private TextBox txtDiaChi;
        private Label label6;
        private TextBox txtNienKhoa;
        private Label label7;
        private GroupBox groupBox1;
        private ComboBox cboCN;
        private Label label8;
        private RadioButton raCaoDang;
        private RadioButton raBang2;
        private RadioButton raDaiHoc;
        private TextBox txtCty;
        private TextBox txtBang1;
        private Label label10;
        private Label label9;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnReset;
        private Button btnThoat;
        private DataGridView lvwSinhVien;
    }
}
