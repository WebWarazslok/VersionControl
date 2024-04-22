using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCC_Proba
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
            timer1.Interval = 10; // Set the interval in milliseconds
            timer1.Start();
            timer1.Tick += Timer1_Tick;
            this.WindowState = FormWindowState.Maximized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            myProgressBar1.Value += 1;
            label2.Text = myProgressBar1.Value.ToString() + "%";
            if (myProgressBar1.Value < 50)
            {
                label1.Text = "Kártya generálása...";
            }
            else
            {
                label1.Text = "Nyomtatási kép generálása...";
            }
            if (myProgressBar1.Value >= myProgressBar1.Maximum)
            {
                timer1.Stop(); // Stop the timer when the progress bar is full
                this.Close(); // Close the loading form
            }
        }
    }
}
