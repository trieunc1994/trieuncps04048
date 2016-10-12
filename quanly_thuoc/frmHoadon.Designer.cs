namespace quanly_thuoc
{
    partial class frmHoadon
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtngay = new System.Windows.Forms.DateTimePicker();
            this.luoi_thuoc = new System.Windows.Forms.DataGridView();
            this.btcuoi = new System.Windows.Forms.Button();
            this.bttruoc = new System.Windows.Forms.Button();
            this.btsau = new System.Windows.Forms.Button();
            this.btdau = new System.Windows.Forms.Button();
            this.txtvitri = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtchuandoan = new System.Windows.Forms.TextBox();
            this.btLuu = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.gr = new System.Windows.Forms.GroupBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHuongdan = new System.Windows.Forms.TextBox();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.cbthuoc = new System.Windows.Forms.ComboBox();
            this.btxoa = new System.Windows.Forms.Button();
            this.btBo = new System.Windows.Forms.Button();
            this.btDEL = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.dtngaysinh = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.luoi_thuoc)).BeginInit();
            this.gr.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Ngày ra toa :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Mã hóa đơn :";
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(98, 51);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(100, 20);
            this.txtma.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 33);
            this.label1.TabIndex = 23;
            this.label1.Text = "Hóa đơn ra toa thuốc";
            // 
            // dtngay
            // 
            this.dtngay.CustomFormat = "dd/MM/yyyy";
            this.dtngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtngay.Location = new System.Drawing.Point(284, 51);
            this.dtngay.Name = "dtngay";
            this.dtngay.Size = new System.Drawing.Size(116, 20);
            this.dtngay.TabIndex = 24;
            // 
            // luoi_thuoc
            // 
            this.luoi_thuoc.AllowUserToAddRows = false;
            this.luoi_thuoc.AllowUserToDeleteRows = false;
            this.luoi_thuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.luoi_thuoc.Location = new System.Drawing.Point(12, 130);
            this.luoi_thuoc.MultiSelect = false;
            this.luoi_thuoc.Name = "luoi_thuoc";
            this.luoi_thuoc.ReadOnly = true;
            this.luoi_thuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.luoi_thuoc.Size = new System.Drawing.Size(545, 127);
            this.luoi_thuoc.TabIndex = 25;
            // 
            // btcuoi
            // 
            this.btcuoi.Location = new System.Drawing.Point(247, 347);
            this.btcuoi.Name = "btcuoi";
            this.btcuoi.Size = new System.Drawing.Size(37, 25);
            this.btcuoi.TabIndex = 29;
            this.btcuoi.Text = ">>";
            this.btcuoi.UseVisualStyleBackColor = true;
            // 
            // bttruoc
            // 
            this.bttruoc.Location = new System.Drawing.Point(204, 347);
            this.bttruoc.Name = "bttruoc";
            this.bttruoc.Size = new System.Drawing.Size(37, 25);
            this.bttruoc.TabIndex = 28;
            this.bttruoc.Text = ">";
            this.bttruoc.UseVisualStyleBackColor = true;
            this.bttruoc.Click += new System.EventHandler(this.bttruoc_Click);
            // 
            // btsau
            // 
            this.btsau.Location = new System.Drawing.Point(55, 347);
            this.btsau.Name = "btsau";
            this.btsau.Size = new System.Drawing.Size(37, 25);
            this.btsau.TabIndex = 27;
            this.btsau.Text = "<";
            this.btsau.UseVisualStyleBackColor = true;
            this.btsau.Click += new System.EventHandler(this.btsau_Click);
            // 
            // btdau
            // 
            this.btdau.Location = new System.Drawing.Point(12, 347);
            this.btdau.Name = "btdau";
            this.btdau.Size = new System.Drawing.Size(37, 25);
            this.btdau.TabIndex = 26;
            this.btdau.Text = "<<";
            this.btdau.UseVisualStyleBackColor = true;
            // 
            // txtvitri
            // 
            this.txtvitri.Location = new System.Drawing.Point(98, 350);
            this.txtvitri.Name = "txtvitri";
            this.txtvitri.Size = new System.Drawing.Size(100, 20);
            this.txtvitri.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Chuẩn đoán :";
            // 
            // txtchuandoan
            // 
            this.txtchuandoan.Location = new System.Drawing.Point(284, 77);
            this.txtchuandoan.Name = "txtchuandoan";
            this.txtchuandoan.Size = new System.Drawing.Size(272, 20);
            this.txtchuandoan.TabIndex = 31;
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(441, 347);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(64, 25);
            this.btLuu.TabIndex = 34;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Visible = false;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(303, 347);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(62, 25);
            this.btThem.TabIndex = 33;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // gr
            // 
            this.gr.Controls.Add(this.btDEL);
            this.gr.Controls.Add(this.btAdd);
            this.gr.Controls.Add(this.label6);
            this.gr.Controls.Add(this.label5);
            this.gr.Controls.Add(this.txtHuongdan);
            this.gr.Controls.Add(this.txtDVT);
            this.gr.Controls.Add(this.txtSoluong);
            this.gr.Controls.Add(this.cbthuoc);
            this.gr.Enabled = false;
            this.gr.Location = new System.Drawing.Point(12, 263);
            this.gr.Name = "gr";
            this.gr.Size = new System.Drawing.Size(545, 78);
            this.gr.TabIndex = 43;
            this.gr.TabStop = false;
            this.gr.Text = "Thêm thuốc vào hóa đơn";
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(427, 19);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(56, 46);
            this.btAdd.TabIndex = 49;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Số lượng/ĐVT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Tên thuốc";
            // 
            // txtHuongdan
            // 
            this.txtHuongdan.Location = new System.Drawing.Point(208, 19);
            this.txtHuongdan.Multiline = true;
            this.txtHuongdan.Name = "txtHuongdan";
            this.txtHuongdan.Size = new System.Drawing.Size(213, 46);
            this.txtHuongdan.TabIndex = 46;
            // 
            // txtDVT
            // 
            this.txtDVT.Location = new System.Drawing.Point(134, 45);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(68, 20);
            this.txtDVT.TabIndex = 45;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(86, 45);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(42, 20);
            this.txtSoluong.TabIndex = 44;
            // 
            // cbthuoc
            // 
            this.cbthuoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbthuoc.FormattingEnabled = true;
            this.cbthuoc.Location = new System.Drawing.Point(70, 19);
            this.cbthuoc.Name = "cbthuoc";
            this.cbthuoc.Size = new System.Drawing.Size(132, 21);
            this.cbthuoc.TabIndex = 43;
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(371, 347);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(62, 25);
            this.btxoa.TabIndex = 44;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btBo
            // 
            this.btBo.Location = new System.Drawing.Point(371, 347);
            this.btBo.Name = "btBo";
            this.btBo.Size = new System.Drawing.Size(64, 25);
            this.btBo.TabIndex = 45;
            this.btBo.Text = "Hủy";
            this.btBo.UseVisualStyleBackColor = true;
            this.btBo.Visible = false;
            this.btBo.Click += new System.EventHandler(this.btBo_Click);
            // 
            // btDEL
            // 
            this.btDEL.Location = new System.Drawing.Point(489, 19);
            this.btDEL.Name = "btDEL";
            this.btDEL.Size = new System.Drawing.Size(49, 46);
            this.btDEL.TabIndex = 50;
            this.btDEL.Text = "DEL";
            this.btDEL.UseVisualStyleBackColor = true;
            this.btDEL.Click += new System.EventHandler(this.btDEL_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Bệnh nhân :";
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(91, 77);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(107, 20);
            this.txthoten.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "Địa chỉ :";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(72, 103);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(126, 20);
            this.txtdiachi.TabIndex = 48;
            // 
            // dtngaysinh
            // 
            this.dtngaysinh.CustomFormat = "dd/MM/yyyy";
            this.dtngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtngaysinh.Location = new System.Drawing.Point(440, 104);
            this.dtngaysinh.Name = "dtngaysinh";
            this.dtngaysinh.Size = new System.Drawing.Size(116, 20);
            this.dtngaysinh.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(362, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "Ngày sinh :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(203, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 53;
            this.label10.Text = "SĐT :";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(244, 104);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(112, 20);
            this.txtSDT.TabIndex = 52;
            // 
            // frmHoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 379);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.dtngaysinh);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txthoten);
            this.Controls.Add(this.btBo);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.gr);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtchuandoan);
            this.Controls.Add(this.txtvitri);
            this.Controls.Add(this.btcuoi);
            this.Controls.Add(this.bttruoc);
            this.Controls.Add(this.btsau);
            this.Controls.Add(this.btdau);
            this.Controls.Add(this.luoi_thuoc);
            this.Controls.Add(this.dtngay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtma);
            this.Name = "frmHoadon";
            this.Text = "Ra toa thuốc";
            this.Load += new System.EventHandler(this.frmHoadon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.luoi_thuoc)).EndInit();
            this.gr.ResumeLayout(false);
            this.gr.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtngay;
        private System.Windows.Forms.DataGridView luoi_thuoc;
        private System.Windows.Forms.Button btcuoi;
        private System.Windows.Forms.Button bttruoc;
        private System.Windows.Forms.Button btsau;
        private System.Windows.Forms.Button btdau;
        private System.Windows.Forms.TextBox txtvitri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtchuandoan;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.GroupBox gr;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHuongdan;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.ComboBox cbthuoc;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btBo;
        private System.Windows.Forms.Button btDEL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.DateTimePicker dtngaysinh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSDT;
    }
}