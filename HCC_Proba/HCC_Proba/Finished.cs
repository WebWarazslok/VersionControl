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
    public partial class Finished : Form
    {
        public Finished()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void button_woc1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
