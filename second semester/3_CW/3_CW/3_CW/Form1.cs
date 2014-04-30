using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _3_CW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Mouse Move to button
        /// </summary>
        /// <param name="sender">This object</param>
        /// <param name="e">This params.</param>
        private void MouseMove(object sender, MouseEventArgs e)
        {
            button1.Location = new Point
                (Math.Min(Math.Abs(this.Size.Width - 2 * button1.Location.X) * 3  %  this.Size.Width, 
                Math.Abs(this.Size.Width - 2 * button1.Location.X) * 3  %  this.Size.Height),
                Math.Min((Math.Abs(this.Size.Height - 2 * button1.Location.Y) * 3 %  this.Size.Height),                
                Math.Abs(this.Size.Height - 2 * button1.Location.Y) * 3 %  this.Size.Width));
        }

        /// <summary>
        /// Close the program.
        /// </summary>
        /// <param name="sender">This object.</param>
        /// <param name="e">That params.</param>
        private void ThisKeyPress(object sender, KeyPressEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Close the program with click in this butoon!
        /// </summary>
        /// <param name="sender">This object.</param>
        /// <param name="e">This params.</param>
        private void Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
