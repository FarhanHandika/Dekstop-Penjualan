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
    public partial class dialogmenu : Form
    {
        public dialogmenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public int harga;
        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public int konter = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            konter++;
            textBox1.Text = "" + konter;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (konter <=1)
            {
              
            }
            else
            {
                konter--;
                textBox1.Text = "" + konter;
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try 
            {
                konter = Convert.ToInt32(textBox1.Text);
            }
            catch (Exception)
            {

                konter = 1;
            }
            int total = harga * konter;
            label4.Text = "" + total;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            string idlogin = kf.flogin.idptg;
            string qty = textBox1.Text;
            string idmenu = this.Name;
            db.crud($"call masukkeranjang('{idlogin}','{idmenu}','{qty}')");
            //ini untuk menampilkan data keranjang
            kf.fmenu.fd.tampilkeranjang();

          
            this.Close();
            
        }
    }
}
