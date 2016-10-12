namespace quanly_thuoc
{
    partial class frm_thuoc
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
            this.txtma = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.btdau = new System.Windows.Forms.Button();
            this.btsau = new System.Windows.Forms.Button();
            this.btcuoi = new System.Windows.Forms.Button();
            this.bttruoc = new System.Windows.Forms.Button();
            this.luoi = new System.Windows.Forms.DataGridView();
            this.them = new System.Windows.Forms.Button();
            this.btluu = new System.Windows.Forms.Button();
            this.btbo = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btluusua = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.cbquocgia = new System.Windows.Forms.ComboBox();
            this.bttim = new System.Windows.Forms.Button();
            this.txttim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCongdung = new System.Windows.Forms.TextBox();
            this.txtthanhphan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.luoi)).BeginInit();
            this.SuspendLayout();
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(92, 78);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(196, 20);
            this.txtma.TabIndex = 0;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(92, 104);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(196, 20);
            this.txtten.TabIndex = 1;
            // 
            // btdau
            // 
            this.btdau.Location = new System.Drawing.Point(22, 228);
            this.btdau.Name = "btdau";
            this.btdau.Size = new System.Drawing.Size(52, 29);
            this.btdau.TabIndex = 2;
            this.btdau.Text = "<<";
            this.btdau.UseVisualStyleBackColor = true;
            this.btdau.Click += new System.EventHandler(this.btdau_Click);
            // 
            // btsau
            // 
            this.btsau.Location = new System.Drawing.Point(80, 228);
            this.btsau.Name = "btsau";
            this.btsau.Size = new System.Drawing.Size(52, 29);
            this.btsau.TabIndex = 3;
            this.btsau.Text = "<";
            this.btsau.UseVisualStyleBackColor = true;
            this.btsau.Click += new System.EventHandler(this.btsau_Click);
            // 
            // btcuoi
            // 
            this.btcuoi.Location = new System.Drawing.Point(236, 228);
            this.btcuoi.Name = "btcuoi";
            this.btcuoi.Size = new System.Drawing.Size(52, 29);
            this.btcuoi.TabIndex = 5;
            this.btcuoi.Text = ">>";
            this.btcuoi.UseVisualStyleBackColor = true;
            this.btcuoi.Click += new System.EventHandler(this.btcuoi_Click);
            // 
            // bttruoc
            // 
            this.bttruoc.Location = new System.Drawing.Point(178, 228);
            this.bttruoc.Name = "bttruoc";
            this.bttruoc.Size = new System.Drawing.Size(52, 29);
            this.bttruoc.TabIndex = 4;
            this.bttruoc.Text = ">";
            this.bttruoc.UseVisualStyleBackColor = true;
            this.bttruoc.Click += new System.EventHandler(this.bttruoc_Click);
            // 
            // luoi
            // 
            this.luoi.AllowUserToAddRows = false;
            this.luoi.AllowUserToDeleteRows = false;
            this.luoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.luoi.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.luoi.Location = new System.Drawing.Point(19, 263);
            this.luoi.MultiSelect = false;
            this.luoi.Name = "luoi";
            this.luoi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.luoi.Size = new System.Drawing.Size(529, 134);
            this.luoi.TabIndex = 6;
            this.luoi.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.luoi_CellMouseClick);
            this.luoi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.luoi_CellContentClick);
            // 
            // them
            // 
            this.them.Location = new System.Drawing.Point(319, 228);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(76, 29);
            this.them.TabIndex = 7;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // btluu
            // 
            this.btluu.Location = new System.Drawing.Point(401, 228);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(77, 29);
            this.btluu.TabIndex = 8;
            this.btluu.Text = "Lưu";
            this.btluu.UseVisualStyleBackColor = true;
            this.btluu.Visible = false;
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // btbo
            // 
            this.btbo.Location = new System.Drawing.Point(484, 228);
            this.btbo.Name = "btbo";
            this.btbo.Size = new System.Drawing.Size(64, 29);
            this.btbo.TabIndex = 9;
            this.btbo.Text = "Bỏ";
            this.btbo.UseVisualStyleBackColor = true;
            this.btbo.Visible = false;
            this.btbo.Click += new System.EventHandler(this.btbo_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(484, 228);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(64, 29);
            this.btXoa.TabIndex = 10;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btluusua
            // 
            this.btluusua.Location = new System.Drawing.Point(401, 228);
            this.btluusua.Name = "btluusua";
            this.btluusua.Size = new System.Drawing.Size(77, 29);
            this.btluusua.TabIndex = 12;
            this.btluusua.Text = "Lưu";
            this.btluusua.UseVisualStyleBackColor = true;
            this.btluusua.Visible = false;
            this.btluusua.Click += new System.EventHandler(this.btluusua_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(401, 228);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(77, 29);
            this.btSua.TabIndex = 11;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // cbquocgia
            // 
            this.cbquocgia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbquocgia.FormattingEnabled = true;
            this.cbquocgia.Location = new System.Drawing.Point(92, 133);
            this.cbquocgia.Name = "cbquocgia";
            this.cbquocgia.Size = new System.Drawing.Size(97, 21);
            this.cbquocgia.TabIndex = 13;
            this.cbquocgia.SelectedIndexChanged += new System.EventHandler(this.cbquocgia_SelectedIndexChanged);
            // 
            // bttim
            // 
            this.bttim.Location = new System.Drawing.Point(498, 36);
            this.bttim.Name = "bttim";
            this.bttim.Size = new System.Drawing.Size(53, 24);
            this.bttim.TabIndex = 14;
            this.bttim.Text = "Tìm";
            this.bttim.UseVisualStyleBackColor = true;
            this.bttim.Click += new System.EventHandler(this.bttim_Click);
            // 
            // txttim
            // 
            this.txttim.Location = new System.Drawing.Point(319, 39);
            this.txttim.Name = "txttim";
            this.txttim.Size = new System.Drawing.Size(173, 20);
            this.txttim.TabIndex = 15;
            this.txttim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttim_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 33);
            this.label1.TabIndex = 16;
            this.label1.Text = "Quản lý Thuốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mã thuốc :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tên thuốc :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Xuất xứ :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Công dụng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(316, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Thành phần :";
            // 
            // txtCongdung
            // 
            this.txtCongdung.Location = new System.Drawing.Point(22, 161);
            this.txtCongdung.Multiline = true;
            this.txtCongdung.Name = "txtCongdung";
            this.txtCongdung.Size = new System.Drawing.Size(526, 59);
            this.txtCongdung.TabIndex = 21;
            // 
            // txtthanhphan
            // 
            this.txtthanhphan.Location = new System.Drawing.Point(319, 78);
            this.txtthanhphan.Multiline = true;
            this.txtthanhphan.Name = "txtthanhphan";
            this.txtthanhphan.Size = new System.Drawing.Size(229, 61);
            this.txtthanhphan.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(318, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(236, 14);
            this.label7.TabIndex = 24;
            this.label7.Text = "Tìm kiếm                                            ";
            // 
            // frm_thuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 409);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCongdung);
            this.Controls.Add(this.txtthanhphan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttim);
            this.Controls.Add(this.bttim);
            this.Controls.Add(this.cbquocgia);
            this.Controls.Add(this.btluusua);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btbo);
            this.Controls.Add(this.btluu);
            this.Controls.Add(this.them);
            this.Controls.Add(this.luoi);
            this.Controls.Add(this.btcuoi);
            this.Controls.Add(this.bttruoc);
            this.Controls.Add(this.btsau);
            this.Controls.Add(this.btdau);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.txtma);
            this.Name = "frm_thuoc";
            this.Text = "Quản lý thuốc";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.luoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Button btdau;
        private System.Windows.Forms.Button btsau;
        private System.Windows.Forms.Button btcuoi;
        private System.Windows.Forms.Button bttruoc;
        private System.Windows.Forms.DataGridView luoi;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.Button btluu;
        private System.Windows.Forms.Button btbo;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btluusua;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.ComboBox cbquocgia;
        private System.Windows.Forms.Button bttim;
        private System.Windows.Forms.TextBox txttim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCongdung;
        private System.Windows.Forms.TextBox txtthanhphan;
        private System.Windows.Forms.Label label7;
    }
}

