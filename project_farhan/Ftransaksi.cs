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
    public partial class Ftransaksi : Form
    {
        public Ftransaksi()
        {
            InitializeComponent();
        }
        public void tampilkeranjang()
        {
            lblttl.Text = "0";
            flowLayoutPanel2.Controls.Clear();
            string idp = kf.flogin.idptg;
            db.crud($"SELECT tmenu.id, tmenu.NamaMenu, tmenu.pic, tkeranjang.subtotal, (SELECT SUM(subtotal) FROM tkeranjang WHERE idp='{idp}') as total FROM tkeranjang INNER JOIN tmenu on tkeranjang.idm = tmenu.id WHERE tkeranjang.idp ='{idp}';");
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
                lblttl.Text = baris["total"].ToString();
                MenuKeranjang mk = new MenuKeranjang();
                mk.Name = baris["id"].ToString();
                mk.pictureBox1.Image = image;
                mk.label1.Text = baris["NamaMenu"].ToString();
                mk.label2.Text = baris["subtotal"].ToString();
                flowLayoutPanel2.Controls.Add(mk);
            }
        }
        public void tampildata()
        {
            db.crud("select*from tmenu");
            foreach(DataRow baris in db.ds.Tables[0].Rows)
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

                    image= null;
                }


                Fdetailmenu FDM = new Fdetailmenu();
                string judul = baris["NamaMenu"].ToString();
                string deskripsi = baris["Keterangan"].ToString();
                string harga = baris["Harga_Jual"].ToString();
                FDM.lblnama.Text = judul;
                FDM.lblketerangan.Text = deskripsi;
                FDM.lblharga.Text = harga;
                FDM.pictureBox1.Image = image;
                FDM.Name = baris["id"].ToString();
                Console.WriteLine(baris["id"].ToString());
                flowLayoutPanel1.Controls.Add(FDM);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            flowLayoutPanel1.Controls.Clear();
            tampildata();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string idp = kf.flogin.idptg;
            string bayar = texbayar.Text;
            //ini bust masuk ke head dan detail
            db.crud($"call masuktrans('{idp}','{bayar}')");
            //ini buat hapus data keranjang
            db.crud($"delete from tkeranjang where idp='{idp}'");
            //untuk membersihkan text transaksi
            lblttl.Text = "0";
            texbayar.Text = "0";
            lblkmbl.Text = "0";
            flowLayoutPanel2.Controls.Clear();

        }

        private void texbayar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int total = Convert.ToInt32(lblttl.Text);
                int bayar = Convert.ToInt32(texbayar.Text);
                int kembali = bayar - total;
                if(kembali<0)
                {
                    lblkmbl.Text = "0";
                }
                else
                {
                    lblkmbl.Text = "" + kembali;
                }
            }
            catch 
            {

                lblkmbl.Text = "0";
            }
        }
    }
}
