using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_farhan
{
    public partial class Fdetailmenu : UserControl
    {
        public Fdetailmenu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            dialogmenu DM = new dialogmenu();
            string idm = this.Name;
            db.crud($"select * from tmenu where id = '{idm}'");
            foreach (DataRow baris in db.ds.Tables[0].Rows)
            {
                Image image;
                try
                {
                    byte[] imageData = (byte[])baris["pic"];
                    MemoryStream ms = new MemoryStream(imageData);
                    image = Image.FromStream(ms);

                }
                catch (Exception)
                {

                    image = null;
                }
                DM.Name = baris["id"].ToString();
                Fdetailmenu FDM = new Fdetailmenu();
                string judul = baris["NamaMenu"].ToString();
                string deskripsi = baris["Keterangan"].ToString();
                string harga = baris["Harga_Jual"].ToString();
                DM.harga = (int)baris["harga_jual"];
                DM.label3.Text = judul;
                DM.richTextBox1.Text = deskripsi;
                DM.label4.Text = harga;
                DM.pictureBox1.Image = image;
                FDM.Name = baris["id"].ToString();
                Console.WriteLine(baris["id"].ToString());
                
            }
            DM.label1.Text = this.Name;
            kf.modal(kf.fmenu, DM);
        }
    }
}
