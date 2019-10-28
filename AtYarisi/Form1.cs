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

            if (pb1.Left>pb2.Left && pb1.Left>pb3.Left)
            {
                lblSiralama.Text = "Şahbatur Önde";
            }
            else if (pb2.Left>pb1.Left && pb2.Left>pb3.Left)
            {
                lblSiralama.Text = "Gülbatur önde";
            }
            else if (pb3.Left>pb1.Left && pb3.Left>pb2.Left)
            {
                lblSiralama.Text="Canbatur önde";
            }

            if (pb1.Right >= pbFinish.Left)
            {
                timer1.Stop();
                MessageBox.Show("1.At Kazandı");
            }
            else if (pb2.Right >= pbFinish.Left)
            {
                timer1.Stop();
                MessageBox.Show("2.At Kazandı");
            }
            else if (pb3.Right >= pbFinish.Left)
            {
                timer1.Stop();
                MessageBox.Show("3. At Kazandı");
            }

        }

        private void btnSfirla_Click(object sender, EventArgs e)
        {
            pb1.Left = 0;
            pb2.Left = 0;
            pb3.Left = 0;
        }
    }
}
