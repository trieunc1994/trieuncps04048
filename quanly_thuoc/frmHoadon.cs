using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace quanly_thuoc
{
    public partial class frmHoadon : Form
    {
        OleDbConnection ketnoi = new OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0;Data Source=" + Application.StartupPath + "/../../data.mdb");
        DataTable bangthuoc;
        DataTable banghoadon;
        DataTable bang_all_thuoc;

        int vitri_hoadon;

        public void load_csdl()
        {
            banghoadon = new DataTable();
            OleDbCommand cmd = new OleDbCommand("Select * from tbhoadon", ketnoi);
            OleDbDataReader dbRead;
            dbRead = cmd.ExecuteReader();
            banghoadon.Load(dbRead);
            
            vitri_hoadon = 0;
            txtvitri.Text = "Hóa đơn : " + (vitri_hoadon+1) + "/" + banghoadon.Rows.Count.ToString();
            dochoadon();
        }

        public void khoa()
        {
            txtma.ReadOnly = true;
            txtchuandoan.ReadOnly = true;
            txtdiachi.ReadOnly = true;
            txthoten.ReadOnly = true;
            txtSDT.ReadOnly = true;
        }

        public void mokhoa()
        {
            txtma.ReadOnly = false;
            txtchuandoan.ReadOnly = false;
            txtdiachi.ReadOnly = false;
            txthoten.ReadOnly = false;
            txtSDT.ReadOnly = false;
        }

        public void dochoadon()
        {
            bangthuoc = new DataTable();
            try
            {
                string mahd = banghoadon.Rows[vitri_hoadon]["mahd"].ToString();
                txtma.Text = mahd;

                dtngay.Value = DateTime.Parse(banghoadon.Rows[vitri_hoadon]["ngay"].ToString());
                txtchuandoan.Text = banghoadon.Rows[vitri_hoadon]["benh"].ToString();
                txtdiachi.Text = banghoadon.Rows[vitri_hoadon]["diachi"].ToString();
                txthoten.Text = banghoadon.Rows[vitri_hoadon]["hoten"].ToString();
                dtngaysinh.Value = DateTime.Parse(banghoadon.Rows[vitri_hoadon]["ngaysinh"].ToString());
                txtSDT.Text = banghoadon.Rows[vitri_hoadon]["sdt"].ToString();

                OleDbCommand cmd = new OleDbCommand("Select b.tenthuoc,a.* from tbthuoc b,tbhoadonthuoc a where a.mathuoc=b.maso and mahd='" + mahd + "'", ketnoi);
                OleDbDataReader dbRead;
                dbRead = cmd.ExecuteReader();
                bangthuoc.Load(dbRead);
                luoi_thuoc.DataSource = bangthuoc;

                luoi_thuoc.Columns["mahd"].Visible = false;
                luoi_thuoc.Columns["mathuoc"].Visible = false;
                luoi_thuoc.Columns["tenthuoc"].HeaderText = "Tên thuốc";
                luoi_thuoc.Columns["soluong"].HeaderText = "Số lượng";
                luoi_thuoc.Columns["dvt"].HeaderText = "Đơn vị tính";
                luoi_thuoc.Columns["huongdan"].HeaderText = "Hướng dẫn sử dụng";
                luoi_thuoc.Columns["huongdan"].Width = 150;
            }
            catch(Exception ex)
            {
                vitri_hoadon = 0;
            }
            
        }

        public frmHoadon()
        {
            InitializeComponent();
        }

        private void frmHoadon_Load(object sender, EventArgs e)
        {
            ketnoi.Open();

            // Load csdl bảng lớp vào Combobox
            bang_all_thuoc = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter("Select * from tbthuoc", ketnoi);
            adapter.FillSchema(bang_all_thuoc, SchemaType.Source);
            adapter.Fill(bang_all_thuoc);
            cbthuoc.DataSource = bang_all_thuoc;
            cbthuoc.DisplayMember = "tenthuoc";
            cbthuoc.ValueMember = "maso";

            load_csdl();
            khoa();
        }

        private void bttruoc_Click(object sender, EventArgs e)
        {
            if (vitri_hoadon < banghoadon.Rows.Count-1)
            {
                vitri_hoadon = vitri_hoadon + 1;
                txtvitri.Text = "Hóa đơn : " + (vitri_hoadon+1) + "/" + banghoadon.Rows.Count.ToString();
                dochoadon();
            }
        }

        private void btsau_Click(object sender, EventArgs e)
        {
            if (vitri_hoadon > 0)
            {
                vitri_hoadon = vitri_hoadon - 1;
                txtvitri.Text = "Hóa đơn : " + (vitri_hoadon + 1) + "/" + banghoadon.Rows.Count.ToString();
                dochoadon();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            btLuu.Visible = true;
            gr.Enabled = true;
            btThem.Visible = false;
            btBo.Visible = true;

            txtma.Text = "";
            txtchuandoan.Text = "";
            txthoten.Text = "";
            txtSDT.Text = "";
            txtdiachi.Text = "";
            /*
            for(int i = luoi_thuoc.Rows.Count-1; i >= 0; i--)
            {
                luoi_thuoc.Rows.RemoveAt(i);
            }*/
            bangthuoc = new DataTable();
            bangthuoc.Columns.Add("mathuoc", Type.GetType("System.String"));
            bangthuoc.Columns.Add("tenthuoc", Type.GetType("System.String"));
            bangthuoc.Columns.Add("soluong", Type.GetType("System.String"));
            bangthuoc.Columns.Add("dvt", Type.GetType("System.String"));
            bangthuoc.Columns.Add("huongdan", Type.GetType("System.String"));
            luoi_thuoc.DataSource = bangthuoc;
            mokhoa();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            DataRow a = bangthuoc.NewRow();
            a["mathuoc"] = cbthuoc.SelectedValue;
            a["tenthuoc"] = cbthuoc.Text;
            a["soluong"] = txtSoluong.Text;
            a["dvt"] = txtDVT.Text;
            a["huongdan"] = txtHuongdan.Text;
            bangthuoc.Rows.Add(a);
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if ((txtchuandoan.Text == "") || (txtma.Text == ""))
                MessageBox.Show("Bạn chưa nhập mã hóa đơn hoặc chưa nhập bệnh án ! Vui lòng nhập đầy đủ trước khi lưu");
            else
            {
                string lenh = "insert into tbhoadon(mahd,ngay,benh,hoten, ngaysinh, sdt, diachi) Values('" + txtma.Text + "','" + dtngay.Value + "','" + txtchuandoan.Text + "','" + txthoten.Text + "','" + dtngaysinh.Value + "','" + txtSDT.Text + "','" + txtdiachi.Text + "')";
                OleDbCommand bo_lenh = new OleDbCommand(lenh, ketnoi);
                bo_lenh.ExecuteNonQuery();

                for (int i = 0; i < bangthuoc.Rows.Count; i++)
                {
                    lenh = "insert into tbhoadonthuoc(mahd, mathuoc, soluong, dvt, huongdan) Values('" + txtma.Text + "','" + bangthuoc.Rows[i]["mathuoc"].ToString() + "','" + bangthuoc.Rows[i]["soluong"].ToString() + "','" + bangthuoc.Rows[i]["dvt"].ToString() + "','" + bangthuoc.Rows[i]["huongdan"].ToString() + "')";
                    bo_lenh = new OleDbCommand(lenh, ketnoi);
                    bo_lenh.ExecuteNonQuery();
                }
                load_csdl();
                btLuu.Visible = false;
                gr.Enabled = false;
                btThem.Visible = true;
                btBo.Visible = false;
                khoa();
            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            try 
            {
                DialogResult a = MessageBox.Show(this, "Bạn muốn xóa hóa đơn này ?", "Admin", MessageBoxButtons.YesNo);
                if (a == DialogResult.Yes)
                {
                    string lenh = "delete from tbhoadonthuoc where mahd='" + txtma.Text + "'";
                    OleDbCommand bo_lenh = new OleDbCommand(lenh, ketnoi);
                    bo_lenh.ExecuteNonQuery();

                    lenh = "delete from tbhoadon where mahd='" + txtma.Text + "'";
                    bo_lenh = new OleDbCommand(lenh, ketnoi);
                    bo_lenh.ExecuteNonQuery();

                    load_csdl();
                }
            }
            catch(Exception ex)
            {

            }
            
        }

        private void btBo_Click(object sender, EventArgs e)
        {
            load_csdl();
            btLuu.Visible = false;
            gr.Enabled = false;
            btThem.Visible = true;
            btBo.Visible = false;
            khoa();
        }

        private void btDEL_Click(object sender, EventArgs e)
        {
            bangthuoc.Rows[luoi_thuoc.CurrentCell.RowIndex].Delete();
        }
    }
}
