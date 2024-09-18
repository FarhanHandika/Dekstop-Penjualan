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
    public partial class DialogPetugas : Form
    {
        public DialogPetugas()
        {
            InitializeComponent();
        }
        public string idpetugas;
        public string kondisi;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("admin");
            comboBox1.Items.Add("petugas");
        }
        
        private void buttonsimpan_Click(object sender, EventArgs e)
        {
            string nama = txtnama.Text;
            string alamat = rchtxtalmt.Text;
            string password = txtpass.Text;
            string hak = comboBox1.Text;
            if (kondisi == "baru")
            {
                db.crud("insert into tpetugas values(null, '" + txtnama.Text + "','" + rchtxtalmt.Text + "','" + txtpass.Text + "','" + comboBox1.Text + "')");
            }
            else 
            {
                db.crud($"update tpetugas set nama = '{nama}', alamat='{alamat}', password='{password}', hak='{hak}' where idp= '{idpetugas}'");
            }
            

            
            this.Close();
            fpetugas fd = new fpetugas() { TopLevel = false, TopMost = true };
            fd.tampildatapetugas();
            kf.untkform(fd, kf.fmenu.panel2);
        }
    }
}
