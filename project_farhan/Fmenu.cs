using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_farhan
{
    public partial class Fmenu : Form
    {
        public Fmenu()
        {
            InitializeComponent();
        }
        public Ftransaksi fd = new Ftransaksi() { TopLevel = false, TopMost = true };
        public fpetugas fp = new fpetugas() { TopLevel = false, TopMost = true };


        private void Fmenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            kf.flogin.Visible = true;
            this.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Fdasboard fd = new Fdasboard() { TopLevel = false, TopMost = true };
            kf.untkform(fd, panel2);
        }

        private void lbltrans_Click(object sender, EventArgs e)
        {
           
            fd.tampildata();
            fd.lblwellcome.Text ="selamat datang. " + kf.flogin.namaptg;
            kf.untkform(fd, panel2);
        }

        private void label3_Click(object sender, EventArgs e)
        {

            fpetugas fd = new fpetugas() { TopLevel = false, TopMost = true };
            fd.tampildatapetugas();
            kf.untkform(fp, panel2);
        }
    }
}
