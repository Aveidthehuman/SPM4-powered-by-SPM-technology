using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPM4_powered_by_SPM_technology
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SendKeys.Send("QuickSPM");
            SendKeys.Send("{Enter}");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            SendKeys.Send(textBox1.Text);
            SendKeys.Send("{Enter}");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox2spm1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            egze f2 = new egze();
            f2.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void groupBox2spm1_Enter(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            groupBox2spm1.Visible = false;
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Error f3 = new Error();
            f3.Show();

        }
    }
}
