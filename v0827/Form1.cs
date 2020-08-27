using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0827
{
    public partial class Form1 : Form
    {
        int vx = rand.Next(-10,11);
        int vy = rand.Next(-10,11);
        int vx2 = rand.Next(-10, 11);
        int vy2 = rand.Next(-10, 11);
        int vx3 = rand.Next(-10, 11);
        int vy3 = rand.Next(-10, 11);
        static Random rand = new Random();
        public Form1()
        {
            InitializeComponent();

            label1.Left = rand.Next(ClientSize.Width-ClientSize.Width);
            label1.Top = rand.Next(ClientSize.Height-ClientSize.Height);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            label1.Text = "(*´ω｀*)";
            timer1.Interval = 60;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;

            label4.Left += vx2;
            label4.Top += vy2;

            label5.Left += vx3;
            label5.Top += vy3;


            Point mp = MousePosition;
            mp = PointToClient(mp);
            label2.Text = "" + mp.X + "," + mp.Y;

            label3.Text = "" + label1.Left + "," + label1.Top;

            if(timer1.Interval > 5)
            {
                timer1.Interval = timer1.Interval - rand.Next(-2,4);
            }
            else
            {
                timer1.Interval = timer1.Interval + rand.Next(0, 11);
            }

            if(label1.Left < 0)
            {
                vx = Math.Abs(vx);
            }
            if(label1.Top < 0)
            {
                vy = Math.Abs(vy);
            }
            if(label1.Right > ClientSize.Width)
            {
                vx = -Math.Abs(vx);
            }
            if(label1.Bottom > ClientSize.Height)
            {
                vy = -Math.Abs(vy);
            }

            if (label4.Left < 0)
            {
                vx2 = Math.Abs(vx);
            }
            if (label4.Top < 0)
            {
                vy2 = Math.Abs(vy);
            }
            if (label4.Right > ClientSize.Width)
            {
                vx2 = -Math.Abs(vx);
            }
            if (label4.Bottom > ClientSize.Height)
            {
                vy2 = -Math.Abs(vy);
            }

            if (label5.Left < 0)
            {
                vx3 = Math.Abs(vx);
            }
            if (label5.Top < 0)
            {
                vy3 = Math.Abs(vy);
            }
            if (label5.Right > ClientSize.Width)
            {
                vx3 = -Math.Abs(vx);
            }
            if (label5.Bottom > ClientSize.Height)
            {
                vy3 = -Math.Abs(vy);
            }

            if ((label1.Left <= mp.X) && 
                (label1.Right > mp.X) &&
                (label1.Top <= mp.Y) && 
                (label1.Bottom > mp.Y)) 
            {
                timer1.Enabled = false;
                label1.Text = "( ﾟДﾟ)";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
