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
    public partial class egze : Form
    {
        public egze()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SendKeys.Send("WebSPM");
            SendKeys.Send("{Enter}");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
          
        }
    }
}
