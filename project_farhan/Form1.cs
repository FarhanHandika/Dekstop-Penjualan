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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.crud("select*from tmenu");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        public string idptg, namaptg;
        private void buttonfarhan1_Click(object sender, EventArgs e)
        {
            string user = textBoxfarhan1.Text;
            string pass = textboxfarhan2.Text;
            db.crud($"select * from tpetugas where idp = '{user}' and password = '{pass}'");
            int data = db.ds.Tables[0].Rows.Count;
            if (data==1)
            {
                DataRow baris = db.ds.Tables[0].Rows[0];
                idptg = baris["idp"].ToString();
                namaptg = baris ["nama"].ToString();
                kf.fmenu.Visible = true;
                kf.flogin.Visible = false;
            }
            else
            {
                MessageBox.Show(this, "user/pass salah", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information );
            }

        }
    }
}
