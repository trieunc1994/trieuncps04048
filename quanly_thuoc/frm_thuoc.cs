using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace quanly_thuoc
{
    public partial class frm_thuoc : Form
    {
        OleDbConnection ketnoi = new OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0;Data Source=" + Application.StartupPath + "/../../data.mdb");
        DataTable bangthuoc;
        DataTable bangquocgia;

        int vitri_mautin;

        public void load_csdl()
        {
            bangthuoc = new DataTable();
            OleDbCommand cmd = new OleDbCommand("Select * from tbthuoc", ketnoi);
            OleDbDataReader dbRead;
            dbRead = cmd.ExecuteReader();
            bangthuoc.Load(dbRead);

            luoi.DataSource = bangthuoc;

            vitri_mautin = 0;
            docmautin();
        }

        public void khoa()
        {
            txtCongdung.ReadOnly = true;
            txtma.ReadOnly = true;
            txtten.ReadOnly = true;
            txtthanhphan.ReadOnly = true;
        }

        public void mokhoa()
        {
            txtCongdung.ReadOnly = false;
            txtma.ReadOnly = false;
            txtten.ReadOnly = false;
            txtthanhphan.ReadOnly = false;
        }

        public void docmautin()
        { 
            DataRow dong;
            dong = bangthuoc.Rows[vitri_mautin];
            txtma.Text = dong["maso"].ToString();
            txtten.Text = dong["tenthuoc"].ToString();
            txtCongdung.Text = dong["congdung"].ToString();
            txtthanhphan.Text = dong["thanhphan"].ToString();
            cbquocgia.SelectedValue = dong["xuatxu"].ToString();
        }

        public frm_thuoc()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ketnoi.Open();
            khoa();
            // Load csdl bảng lớp vào Combobox
            bangquocgia = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter("Select * from tbquocgia", ketnoi);
            adapter.FillSchema(bangquocgia, SchemaType.Source);
            adapter.Fill(bangquocgia);
            cbquocgia.DataSource = bangquocgia;
            cbquocgia.DisplayMember = "tenquocgia";
            cbquocgia.ValueMember = "maso";

            load_csdl();
        }

        private void bttruoc_Click(object sender, EventArgs e)
        {
            if (vitri_mautin < bangthuoc.Rows.Count - 1)
            {
                vitri_mautin = vitri_mautin + 1;
                docmautin();
                luoi.CurrentCell = luoi.Rows[vitri_mautin].Cells[0];
            }
            
        }

        private void btsau_Click(object sender, EventArgs e)
        {
            if (vitri_mautin > 0)
            {
                vitri_mautin = vitri_mautin - 1;
                docmautin();
                luoi.CurrentCell = luoi.Rows[vitri_mautin].Cells[0];
            }
        }

        private void btcuoi_Click(object sender, EventArgs e)
        {
            vitri_mautin = bangthuoc.Rows.Count - 1;
            docmautin();
            luoi.CurrentCell = luoi.Rows[vitri_mautin].Cells[0];
        }

        private void btdau_Click(object sender, EventArgs e)
        {
            vitri_mautin = 0;
            docmautin();
            luoi.CurrentCell = luoi.Rows[vitri_mautin].Cells[0];
        }

        private void them_Click(object sender, EventArgs e)
        {
            txtma.Text = "";
            txtten.Text = "";
            txtthanhphan.Text = "";
            txtCongdung.Text = "";

            btluu.Visible = true;
            btbo.Visible = true;
            them.Visible = false;
            btXoa.Visible = false;
            btSua.Visible = false;
            mokhoa();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string lenh;
            OleDbCommand bo_lenh;
            try
            {
                DialogResult a = MessageBox.Show(this, "Bạn muốn xóa loại thuốc này ?", "Admin",MessageBoxButtons.YesNo);
                if (a == DialogResult.Yes)
                {
                    lenh = "delete from tbthuoc where maso ='" + txtma.Text + "'";
                    bo_lenh = new OleDbCommand(lenh, ketnoi);
                    bo_lenh.ExecuteNonQuery();

                    load_csdl();
                    if (vitri_mautin > 0)
                        vitri_mautin--;
                    docmautin();
                }
            }
            catch (Exception ex)
            {
                DialogResult a = MessageBox.Show(this, "Thuốc này đã có trong hóa đơn, bạn có muốn xóa luôn thuốc này trong hóa đơn ?", "Admin", MessageBoxButtons.YesNo);
                if (a == DialogResult.Yes)
                {
                    lenh = "delete from tbhoadonthuoc where mathuoc ='" + txtma.Text + "'";
                    bo_lenh = new OleDbCommand(lenh, ketnoi);
                    bo_lenh.ExecuteNonQuery();

                    lenh = "delete from tbthuoc where maso ='" + txtma.Text + "'";
                    bo_lenh = new OleDbCommand(lenh, ketnoi);
                    bo_lenh.ExecuteNonQuery();

                    load_csdl();
                    if (vitri_mautin > 0)
                        vitri_mautin--;
                    docmautin();
                }
            }
            
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            btluu.Visible = false;
            btluusua.Visible = true;
            btbo.Visible = true;
            them.Visible = false;
            btSua.Visible = false;
            btXoa.Visible = false;
            
            mokhoa();
            txtma.ReadOnly = true;
        }

        private void btluusua_Click(object sender, EventArgs e)
        {
            string lenh = "update tbthuoc set tenthuoc='" + txtten.Text + "', thanhphan='" + txtthanhphan.Text + "', congdung='" + txtCongdung.Text + "', xuatxu='" + cbquocgia.SelectedValue + "' where maso = '" + txtma.Text + "'";
            OleDbCommand bo_lenh = new OleDbCommand(lenh, ketnoi);
            bo_lenh.ExecuteNonQuery();

            load_csdl();

            docmautin();

            btluusua.Visible = false;
            btluu.Visible = false;
            btbo.Visible = false;
            them.Visible = true;
            btSua.Visible = true;
            khoa();
        }

        private void btbo_Click(object sender, EventArgs e)
        {
            btluusua.Visible = false;
            btluu.Visible = false;
            btbo.Visible = false;
            them.Visible = true;
            btSua.Visible = true;
            btXoa.Visible = true;
            docmautin();
            khoa();
        }

        private void luoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void luoi_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                vitri_mautin = e.RowIndex;
                txtma.Text = luoi.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtten.Text = luoi.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtCongdung.Text = luoi.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtthanhphan.Text = luoi.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbquocgia.SelectedValue = luoi.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch(Exception ie) { }
            
        }

        private void bttim_Click(object sender, EventArgs e)
        {
            bangthuoc = new DataTable();
            OleDbCommand cmd = new OleDbCommand("Select * from tbthuoc where tenthuoc like '%"+ txttim.Text +"%'", ketnoi);
            OleDbDataReader dbRead;
            dbRead = cmd.ExecuteReader();
            bangthuoc.Load(dbRead);

            luoi.DataSource = bangthuoc;

            vitri_mautin = 0;
            docmautin();
        }

        private void txttim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                bttim_Click(sender, e);
            }
        }

        private void cbquocgia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btluu_Click(object sender, EventArgs e)
        {
            string lenh = "insert into tbthuoc(maso, tenthuoc,thanhphan, congdung, xuatxu) Values('" + txtma.Text + "','" + txtten.Text + "','" + txtthanhphan.Text + "','" + txtCongdung.Text + "','" + cbquocgia.SelectedValue + "')";
            OleDbCommand bo_lenh = new OleDbCommand(lenh, ketnoi);
            bo_lenh.ExecuteNonQuery();

            load_csdl();

            btluu.Visible = false;
            btbo.Visible = false;
            them.Visible = true;
            btXoa.Visible = true;
            btSua.Visible = true;
            khoa();
        }

       
    }
}
