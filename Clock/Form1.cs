using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 1000; //1 varkyan
            timer.Elapsed += circularProgressBar1_Click;
            timer.Start();

        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {
            circularProgressBar1.Invoke((MethodInvoker)delegate

                {
                    circularProgressBar1.Text = DateTime.Now.ToString("hh:mm:ss");
                    circularProgressBar1.SubscriptText = DateTime.Now.ToString("tt"); // AM kam PM
                });


        }
    }
}
