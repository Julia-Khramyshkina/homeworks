using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26_03_Control_Work
{
    public partial class Form1 : Form
    {
        private bool click = true;
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Сreating a place to play.
        /// </summary>
        /// <param name="sender">Transmitted object.</param>
        /// <param name="e">Transmitted args.</param>
        private void TableLayoutPanel1Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// Processing pressing a key № 1.
        /// </summary>
        /// <param name="sender">Transmitted object.</param>
        /// <param name="e">Transmitted args.</param>
        private void Button1Click(object sender, EventArgs e)
        {
            if (this.button1.Text != "")
                return;

            if (click)
            {
                this.button1.Text = "X";
                click = !click;
            }
            else
            {
                this.button1.Text = "O";
                click = !click;
            }
        }

        /// <summary>
        /// Processing pressing a key № 2.
        /// </summary>
        /// <param name="sender">Transmitted object.</param>
        /// <param name="e">Transmitted args.</param>
        private void Button2Click(object sender, EventArgs e)
        {
            if (this.button2.Text != "")
                return;

            if (click)
            {
                this.button2.Text = "X";
                click = !click;
            }
            else
            {
                this.button2.Text = "O";
                click = !click;
            }
        }

        /// <summary>
        /// Processing pressing a key № 3.
        /// </summary>
        /// <param name="sender">Transmitted object.</param>
        /// <param name="e">Transmitted args.</param>
        private void Button3Click(object sender, EventArgs e)
        {
            if (this.button3.Text != "")
                return;

            if (click)
            {
                this.button3.Text = "X";
                click = !click;
            }
            else
            {
                this.button3.Text = "O";
                click = !click;
            }
        }

        /// <summary>
        /// Processing pressing a key № 4.
        /// </summary>
        /// <param name="sender">Transmitted object.</param>
        /// <param name="e">Transmitted args.</param>
        private void Button4Click(object sender, EventArgs e)
        {
            if (this.button4.Text != "")
                return;

            if (click)
            {
                this.button4.Text = "X";
                click = !click;
            }
            else
            {
                this.button4.Text = "O";
                click = !click;
            }
        }

        /// <summary>
        /// Processing pressing a key № 5.
        /// </summary>
        /// <param name="sender">Transmitted object.</param>
        /// <param name="e">Transmitted args.</param>
        private void Button5Click(object sender, EventArgs e)
        {
            if (this.button5.Text != "")
                return;

            if (click)
            {
                this.button5.Text = "X";
                click = !click;
            }
            else
            {
                this.button5.Text = "O";
                click = !click;
            }
        }

        /// <summary>
        /// Processing pressing a key № 6.
        /// </summary>
        /// <param name="sender">Transmitted object.</param>
        /// <param name="e">Transmitted args.</param>
        private void Button6Click(object sender, EventArgs e)
        {
            if (this.button6.Text != "")
                return;

            if (click)
            {
                this.button6.Text = "X";
                click = !click;
            }
            else
            {
                this.button6.Text = "O";
                click = !click;
            }
        }

        /// <summary>
        /// Processing pressing a key № 7.
        /// </summary>
        /// <param name="sender">Transmitted object.</param>
        /// <param name="e">Transmitted args.</param>
        private void Button7Click(object sender, EventArgs e)
        {
            if (this.button7.Text != "")
                return;

            if (click)
            {
                this.button7.Text = "X";
                click = !click;
            }
            else
            {
                this.button7.Text = "O";
                click = !click;
            }
        }

        /// <summary>
        /// Processing pressing a key № 8.
        /// </summary>
        /// <param name="sender">Transmitted object.</param>
        /// <param name="e">Transmitted args.</param>
        private void Button8Click(object sender, EventArgs e)
        {
            if (this.button8.Text != "")
                return;

            if (click)
            {
                this.button8.Text = "X";
                click = !click;
            }
            else
            {
                this.button8.Text = "O";
                click = !click;
            }
        }

        /// <summary>
        /// Processing pressing a key № 9.
        /// </summary>
        /// <param name="sender">Transmitted object.</param>
        /// <param name="e">Transmitted args.</param>
        private void Button9Click(object sender, EventArgs e)
        {
            if (this.button9.Text != "")
                return;

            if (click)
            {
                this.button9.Text = "X";
                click = !click;
            }
            else
            {
                this.button9.Text = "O";
                click = !click;
            }
        }
    }
}
