using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uniclient
{
    public partial class FenProgessbar : Form
    {
        public FenProgessbar()
        {
            InitializeComponent();
        }

        private void FenProgessbar_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                Login Log = new Login();
                pictureBox1.Width += 20;
                // int i = pictureBox1.Width;
                lbi.Text = "Chargement... ";
                if (pictureBox1.Width >= 450)
                {
                    timer1.Stop();
                    this.Hide();
                    Log.Show();

                }

            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
