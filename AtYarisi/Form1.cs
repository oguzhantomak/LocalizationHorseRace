using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        private void BtnStart_Click(object sender, EventArgs e)
        {

            timer1.Start();

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            pb1.Left += rnd.Next(1, 20);
            pb2.Left += rnd.Next(1, 20);
            pb3.Left += rnd.Next(1, 20);

            if (pb1.Right>pb2.Right && pb1.Right>pb3.Right)
            {
                lblSiralama.Text = "Şahbatur Önde";
            }
            else if (pb2.Right>pb1.Right && pb2.Right>pb3.Right)
            {
                lblSiralama.Text = "Gülbatur önde";
            }
            else if (pb3.Right>pb1.Right && pb3.Right > pb2.Right)
            {
                lblSiralama.Text="Canbatur önde";
            }

            if (pb1.Right >= pbFinish.Left)
            {
                timer1.Stop();
                MessageBox.Show("Şahbatur Kazandı");
            }
            else if (pb2.Right >= pbFinish.Left)
            {
                timer1.Stop();
                MessageBox.Show("Gülbatur Kazandı");
            }
            else if (pb3.Right >= pbFinish.Left)
            {
                timer1.Stop();
                MessageBox.Show("Canbatur Kazandı");
            }

        }

        private void btnSfirla_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            pb1.Left = 0;
            pb2.Left = 0;
            pb3.Left = 0;
            lblSiralama.Text = "";
        }
    }
}
