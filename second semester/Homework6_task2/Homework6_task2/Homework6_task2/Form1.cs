using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework6_task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Change time.
        /// </summary>
        private void TimerTick(object sender, EventArgs e)
        {
            label.Text = DateTime.Now.ToString("h:mm:ss.f");
        }
    }
}
