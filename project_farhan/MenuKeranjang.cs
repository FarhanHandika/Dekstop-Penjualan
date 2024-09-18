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
    public partial class MenuKeranjang : UserControl
    {
        public MenuKeranjang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idmenu = this.Name;
            string idp = kf.flogin.idptg;
            db.crud($"DELETE FROM tkeranjang WHERE idm = '{idmenu}' AND idp = '{idp}'");
            kf.fmenu.fd.tampilkeranjang();
        }
    }
}
