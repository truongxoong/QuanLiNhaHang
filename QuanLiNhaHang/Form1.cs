using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhaHang
{
    public partial class QuanLi : Form
    {
        public QuanLi()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void butThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void QuanLi_FormClosing(object sender, FormClosingEventArgs e)
        {
           if( MessageBox.Show("ban co muon thoat khong?","Thong Bao",MessageBoxButtons.OKCancel) 
                != System.Windows.Forms.DialogResult.OK)
           {
                   e.Cancel = true;
           }
        }

        private void butDN_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            this.Hide();
            f.ShowDialog();
            this.Show();
            
        }
    }
}
