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
    public partial class Ftest : Form
    {
        public Ftest()
        {
            InitializeComponent();
        }
private void Ftest_Paint(object sender, PaintEventArgs e)
        {
            KF.untukrounded(button1, 20, 20, 20, 20);
            KF.untukrounded(pictureBox1, 103, 103, 103, 103);
            KF.untukrounded(button2, 1, 30, 1, 30);

            KF.untukrounded(panel1, 20, 1, 1, 20);
            KF.untukrounded(button3, 1, 20, 20, 1);
        }
    }
}
