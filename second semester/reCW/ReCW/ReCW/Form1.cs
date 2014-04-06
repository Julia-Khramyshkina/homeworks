using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReCW
{
    public partial class Form1 : Form
    {
        private Button[,] buttons = new Button [3, 3];

        private bool click = true;
        private bool win = false;

        public Form1()
        {
            InitializeComponent();

            int number = 0;
            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < 3; ++j)
                {
                    buttons[i, j] = new System.Windows.Forms.Button();
                    buttons[i, j].Location = new System.Drawing.Point(3 + 95 * i, 3 + 95 * j);
                    buttons[i, j].Name = "button" + number.ToString();
                    buttons[i, j].Size = new System.Drawing.Size(89, 81);
                    buttons[i, j].TabIndex = number;
                    buttons[i, j].UseVisualStyleBackColor = true;
                    buttons[i, j].Click += new System.EventHandler(this.ButtonClick);
                    this.tableLayoutPanel1.Controls.Add(buttons[i, j], i, j);
                    ++number;
                }
            }
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button countButton = (Button)sender;

            if (countButton.Text != "" || win)
                return;

            if (click)
            {
                countButton.Text = "X";
                if (this.Win())
                {
                    countButton.Text = "X, WIN";
                    win = true;
                    return;
                }
                click = !click;
            }
            else
            {
                countButton.Text = "O";
                if (this.Win())
                {
                    countButton.Text = "O, WIN";
                    win = true;
                    return;
                }
                click = !click;
            }
        }

        private bool Win()
        {
            
            for (int i = 0; i < 3; ++i)
            {             
                if (buttons[0, i].Text == buttons[1, i].Text &&  buttons[1, i].Text
                    == buttons[2, i].Text && buttons[2, i].Text != "")
                    return true;

                if (buttons[i, 0].Text == buttons[i, 1].Text && buttons[i, 1].Text
                    == buttons[i, 2].Text && buttons[i, 2].Text != "")
                    return true;
            }

            if (buttons[0, 0].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[2, 2].Text
                && buttons[2, 2].Text != "")
                return true;

            if (buttons[0, 2].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[2, 0].Text
                && buttons[2, 0].Text != "")
                return true;

            return false;        
        }


    }
}
