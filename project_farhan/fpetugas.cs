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
    public partial class fpetugas : Form
    {
        public fpetugas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogPetugas DP = new DialogPetugas();
            DP.kondisi = "baru";
            DP.label1.Text = "Registrasi Petugas Baru";
            kf.modal(kf.fmenu, DP);
        }
        public void tampildatapetugas()
        {
            datapetugas.Rows.Clear();
            db.crud("select * from tpetugas");
            foreach (DataRow baris in db.ds.Tables[0].Rows)
            {
                string idp = baris["idp"].ToString();
                string nm = baris["nama"].ToString();
                string almt = baris["alamat"].ToString();
                string hak = baris["hak"].ToString();
                datapetugas.Rows.Add(idp, nm, almt, hak);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tampildatapetugas();
        }

        private void datapetugas_Click(object sender, EventArgs e)
        {
            int kolom = datapetugas.CurrentCell.ColumnIndex;
            int barisn= datapetugas.CurrentCell.RowIndex;
            string idp = datapetugas.Rows[barisn].Cells[0].Value.ToString();
                
            if (kolom==4)
            {
                DialogPetugas DP = new DialogPetugas();
                DP.kondisi = "ubah";
                DP.label1.Text = "Ubah Data Petugas";
                db.crud($"select * from tpetugas where idp = '{idp}'");
                foreach (DataRow row in db.ds.Tables[0].Rows)
                {
                    string id = row["idp"].ToString();
                    string nama = row["nama"].ToString();
                    string alamat = row["alamat"].ToString();
                    string pass = row["password"].ToString();
                    string hak = row["hak"].ToString();

                    DP.txtnama.Text = nama;
                    DP.rchtxtalmt.Text = alamat;
                    DP.txtpass.Text = pass;
                    DP.idpetugas = id;
                    DP.comboBox1.Text = hak;

                }
                kf.modal(kf.fmenu, DP);

            }
            if (kolom==5)
            {
                db.crud($"delete from tpetugas where idp='{idp}'");
            }


        }
        public void caridatapetugas(string cari)
        {
            datapetugas.Rows.Clear();
            db.crud($"select * from tpetugas where nama LIKE '%{cari}%' or hak LIKE '%{cari}%'");
            foreach (DataRow baris in db.ds.Tables[0].Rows)
            {
                string id = baris["idp"].ToString();
                string nama = baris["nama"].ToString();
                string alamat = baris["alamat"].ToString();
                string hak = baris["hak"].ToString();
                datapetugas.Rows.Add(id, nama, alamat, hak);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            caridatapetugas(textBox1.Text);
        }
    }
}
