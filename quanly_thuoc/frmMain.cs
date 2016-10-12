using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace quanly_thuoc
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void thuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_thuoc a = new frm_thuoc();
            a.MdiParent = this;
            a.StartPosition = FormStartPosition.CenterScreen;
            a.Show();
        }

        private void raToaThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoadon a = new frmHoadon();
            a.MdiParent = this;
            a.StartPosition = FormStartPosition.CenterScreen;
            a.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
