using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework6_task1
{
    public partial class Calculator : Form
    {
        private Button[,] buttons = new Button[5, 5];

        public Calculator()
        {
            InitializeComponent();

            int number = 0;
            for (int j = 1; j < 4; ++j)
            {
                for (int i = 0; i < 3; ++i)
                {
                    buttons[i, j] = new System.Windows.Forms.Button();
                    buttons[i, j].Name = (number + 1).ToString();
                    buttons[i, j].Text = (number + 1).ToString();
                    buttons[i, j].Dock = System.Windows.Forms.DockStyle.Fill; 
                    buttons[i, j].TabIndex = number;
                    buttons[i, j].UseVisualStyleBackColor = true;
                    buttons[i, j].Click += new System.EventHandler(this.ButtonClick);
                    this.tableLayoutPanel1.Controls.Add(buttons[i, j], i, j);
                    ++number;
                }               
            }
            
            String [] operation = new String[4] {"+", "-", "*", "/"}; 
            for (int i = 1; i < 5; ++i)
            {
                buttons[3, i] = new System.Windows.Forms.Button();
                buttons[3, i].Name = operation[i - 1];
                buttons[3, i].Text = operation[i - 1];
                buttons[3, i].Dock = System.Windows.Forms.DockStyle.Fill;
                buttons[3, i].TabIndex = number;
                buttons[3, i].UseVisualStyleBackColor = true;
                buttons[3, i].Click += new System.EventHandler(this.ButtonClick);
                this.tableLayoutPanel1.Controls.Add(buttons[3, i], 3, i);
                ++number;
            }



            buttons[0, 4] = new System.Windows.Forms.Button();
            buttons[0, 4].Name = (0).ToString();
            buttons[0, 4].Text = (0).ToString();
            buttons[0, 4].Dock = System.Windows.Forms.DockStyle.Fill;
            buttons[0, 4].UseVisualStyleBackColor = true;
            buttons[0, 4].Click += new System.EventHandler(this.ButtonClick);
            this.tableLayoutPanel1.Controls.Add(buttons[0, 4], 0, 4);
            this.tableLayoutPanel1.SetColumnSpan(buttons[0, 4], 2);

            buttons[2, 4] = new System.Windows.Forms.Button();
            buttons[2, 4].Name = ",";
            buttons[2, 4].Text = ",";
            buttons[2, 4].Dock = System.Windows.Forms.DockStyle.Fill;
            buttons[2, 4].UseVisualStyleBackColor = true;
            buttons[2, 4].Click += new System.EventHandler(this.ButtonClick);
            this.tableLayoutPanel1.Controls.Add(buttons[2, 4], 2, 4);

        }


        public void ButtonClick(object sender, EventArgs e)
        {
        }
    }
}
