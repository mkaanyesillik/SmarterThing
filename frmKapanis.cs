using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmarterThing
{
    public partial class frmKapanis : Form
    {
        public frmKapanis()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblslider.Text = lblslider.Text.Substring(1) + lblslider.Text.Substring(0, 1);

            lblslider.Text = lblslider.Text.Substring(1) + lblslider.Text.Substring(0, 1);
        }

        private void frmKapanis_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Interval = 3000;

            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
