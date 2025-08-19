using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuDoanKhoiNghe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKhoiA frm = new FormKhoiA();
            frm.ShowDialog();
            this.Show();
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKhoiB frm = new FormKhoiB();
            frm.ShowDialog();
            this.Show();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKhoiC frm = new FormKhoiC();
            frm.ShowDialog();
            this.Show();
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKhoiD frm = new FormKhoiD();
            frm.ShowDialog();
            this.Show();
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKhoiH frm = new FormKhoiH();
            frm.ShowDialog();
            this.Show();
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKhoiV frm = new FormKhoiV();
            frm.ShowDialog();
            this.Show();
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKhoiR frm = new FormKhoiR();
            frm.ShowDialog();
            this.Show();
        }

        private void btnKhac_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormError frm = new FormError();
            frm.ShowDialog();
            this.Show();
        }
    }
}
