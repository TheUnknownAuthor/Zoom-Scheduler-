using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace ZoomFucker
{
    public partial class ZoomScheduler : Form
    {
        public ZoomScheduler()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            ZoomScheduler form1 = new ZoomScheduler();

            this.Hide();

            string fuck = Link1.Text;
            string fuck2 = Link2.Text;
            string fuck3 = Link3.Text;
            string fuck4 = Link4.Text;
            string fuck5 = Link5.Text;
            string fuck6 = Link6.Text;
            string fuck7 = Link7.Text;
            int bruhfart1 = Int32.Parse(this.textBox1.Text) * 60;
            Thread.Sleep(bruhfart1 * 1000);
            Process.Start(fuck);
            int bruhfart27 = Int32.Parse(this.TIme1.Text) * 60;
            Thread.Sleep(bruhfart27 * 1000);
            Process.Start(fuck2);
            int bruhfart28 = Int32.Parse(this.Time2.Text) * 60;
            Thread.Sleep(bruhfart28 * 1000);
            Process.Start(fuck3);
            int bruhfart29 = Int32.Parse(this.Time3.Text) * 60;
            Thread.Sleep(bruhfart29 * 1000);
            Process.Start(fuck4);
            int bruhfart30 = Int32.Parse(this.Time4.Text) * 60;
            Thread.Sleep(bruhfart30 * 1000);
            Process.Start(fuck5);
            int bruhfart31 = Int32.Parse(this.Time5.Text) * 60;
            Thread.Sleep(bruhfart31 * 1000);
            Process.Start(fuck6);
            int bruhfart32 = Int32.Parse(this.Time6.Text) * 60;
            Thread.Sleep(bruhfart32 * 1000);
            Thread.Sleep(100);
            Process.Start(fuck7);
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Link2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}