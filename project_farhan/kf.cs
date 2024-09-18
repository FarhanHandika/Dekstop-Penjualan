using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace project_farhan
{
    class kf
    {
        public static Form1 flogin = new Form1();
        public static Fmenu fmenu = new Fmenu();

        public static int UtamaX, UtamaY, lebarform, tinggiform, lokasimodalx, lokasimodaly;
        static Timer waktu;
        static Form modalnya;
        static Boolean jalan;


        public static void untkform(Form formapa, Panel pnlapa)
        {
            pnlapa.Controls.Clear();
            pnlapa.Controls.Add(formapa);
            formapa.FormBorderStyle = FormBorderStyle.None;
            formapa.Dock = DockStyle.Fill;
            formapa.Show();
        }
        public static void modal(Form formutama, Form modal)
        {
            modalnya = modal;
            modal.ShowInTaskbar = false;
            modal.FormBorderStyle = FormBorderStyle.None;
            modal.Load += (s, e) => animasimodal(modalnya, true);
            Form latarbelakang = new Form();
            latarbelakang.FormBorderStyle = FormBorderStyle.None;
            latarbelakang.ShowInTaskbar = false;
            latarbelakang.Owner = formutama;
            latarbelakang.StartPosition = FormStartPosition.Manual;

            latarbelakang.Opacity = .85d;
            latarbelakang.BackColor = Color.Black;
            latarbelakang.Location = formutama.Location;
            modal.Owner = latarbelakang;
            UtamaX = formutama.Location.X;
            UtamaY = formutama.Location.Y;
            lebarform = formutama.Size.Width;
            tinggiform = formutama.Size.Height;
            latarbelakang.Size = formutama.Size;
            latarbelakang.Show();
            modal.ShowDialog();
            latarbelakang.Dispose();
        }
        public static void animasimodal(Form modal, Boolean jalanku)
        {
            if (jalanku == true)
            {
                modal.Opacity = 0;
            }
            else
            {
                modal.Opacity = 100;
            }
            jalan = jalanku;
            waktu = new Timer();
            waktu.Enabled = true;
            waktu.Interval = 1;
            waktu.Tick += timerjalan;
            lokasimodaly = UtamaY + tinggiform / 2 - modal.Height / 2;
            lokasimodalx = UtamaX + lebarform / 2 - modal.Width / 2;
        }
        public static void timerjalan(object sender, EventArgs e)
        {
            modalanimasi(modalnya, jalan);
        }
        private static void modalanimasi(Form modal, Boolean jalankan)
        {
            if (jalankan == true)
            {
                int lokasiy = UtamaX += 20;
                if (modal.Opacity >= 1)
                {
                    modal.Opacity = 1;
                }
                else
                {
                    modal.Opacity += .05;
                }
                modal.Location = new Point(lokasimodalx, lokasiy);
                if (lokasiy >= lokasimodaly)
                {
                    modal.Opacity = 1;
                    modal.Location = new Point(lokasimodalx, lokasimodaly);
                    waktu.Stop();
                }
            }
            else
            {
                modal.Opacity = 100;
                modal.Location = new Point(lokasimodalx, lokasimodaly);
            }
        }
        public static void untukrounded(Control ctrlapa, int kiriatas, int kananatas, int kananbawah, int kiribawah)
        {
            int borderRadius = 10; //untuk radius
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();

            //sudut kiri atas
            path.AddArc(new Rectangle(0, 0, kiriatas, kiriatas), 180, 90);

            //garis dari kiri atas ke kanan atas
            path.AddLine(borderRadius, 0, ctrlapa.Width - borderRadius, 0);

            //sudut kanan atas
            path.AddArc(new Rectangle(ctrlapa.Width - kananatas, 0, kananatas, kananatas), 270, 90);

            //garis dari kanan atas ke kanan bawah 
            path.AddLine(ctrlapa.Width, borderRadius, ctrlapa.Width, ctrlapa.Height - borderRadius);

            //sudut kanan bawah
            path.AddArc(new Rectangle(ctrlapa.Width - kananbawah, ctrlapa.Height - kananbawah, kananbawah, kananbawah), 0, 90);

            //garis dari kanan bawah ke kiri bawah
            path.AddLine(ctrlapa.Width - borderRadius, ctrlapa.Height, borderRadius, ctrlapa.Height);
            path.AddArc(new Rectangle(0, ctrlapa.Height - kiribawah, kiribawah, kiribawah), 90, 90);

            //garisa dari kiri bawah ke kiri atas
            path.AddLine(0, ctrlapa.Height - borderRadius, 0, borderRadius);
            path.CloseAllFigures();

            ctrlapa.Region = new Region(path);

        }
    }

}
