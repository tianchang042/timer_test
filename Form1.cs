using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Timer_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        System.Timers.Timer t = new System.Timers.Timer(5000);
        private void btnControl_Click(object sender, EventArgs e)
        {
            t.Elapsed += new System.Timers.ElapsedEventHandler(theout);
            t.AutoReset = true;
            t.Enabled = true;
            btnOther.Enabled = false;
        }
        public void theout(object source, System.Timers.ElapsedEventArgs e)
        {
            MessageBox.Show("OK!");
        }

        private void btnMan_Click(object sender, EventArgs e)
        {
            btnOther.Enabled = true;
            t.Stop();
            MessageBox.Show("stop");
            
        }

        private void btnOther_Click(object sender, EventArgs e)
        {
            MessageBox.Show("other");
        }
    }
}
