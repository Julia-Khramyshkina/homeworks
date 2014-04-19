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
        private Button[,] buttons = new Button[6, 6];

        private String WholePart = "";
        private String FractionalPart = "";
        private bool Dot = false;

        private double Value;

        private String Operation = "";


        public Calculator()
        {
            InitializeComponent();

            int number = 0;
            for (int j = 2; j < 5; ++j)
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
            
            String [] operation = new String[7] {"+", "-", "*", "/", "%", "1/x", "="};
            number = 0;
            for (int j = 3; j < 5; ++j)
            {
                for (int i = 2; i < 6; ++i)
                {
                    buttons[j, i] = new System.Windows.Forms.Button();
                    buttons[j, i].Name = operation[number];
                    buttons[j, i].Text = operation[number];
                    buttons[j, i].Dock = System.Windows.Forms.DockStyle.Fill;
                    buttons[j, i].UseVisualStyleBackColor = true;
                    buttons[j, i].Click += new System.EventHandler(this.ButtonClick);
                    if (number == 6)
                    {
                        this.tableLayoutPanel1.Controls.Add(buttons[j, i], j, i);
                        this.tableLayoutPanel1.SetRowSpan(buttons[j, i], 2);
                        break;

                    }
                    else
                        this.tableLayoutPanel1.Controls.Add(buttons[j, i], j, i);

                    ++number;
                }
            }

            buttons[0, 5] = new System.Windows.Forms.Button();
            buttons[0, 5].Name = (0).ToString();
            buttons[0, 5].Text = (0).ToString();
            buttons[0, 5].Dock = System.Windows.Forms.DockStyle.Fill;
            buttons[0, 5].UseVisualStyleBackColor = true;
            buttons[0, 5].Click += new System.EventHandler(this.ButtonClick);
            this.tableLayoutPanel1.Controls.Add(buttons[0, 5], 0, 5);
            this.tableLayoutPanel1.SetColumnSpan(buttons[0, 5], 2);

            buttons[2, 5] = new System.Windows.Forms.Button();
            buttons[2, 5].Name = ",";
            buttons[2, 5].Text = ",";
            buttons[2, 5].Dock = System.Windows.Forms.DockStyle.Fill;
            buttons[2, 5].UseVisualStyleBackColor = true;
            buttons[2, 5].Click += new System.EventHandler(this.ButtonClick);
            this.tableLayoutPanel1.Controls.Add(buttons[2, 5], 2, 5);

            String[] otherOperation = new String[5] {"Backspace", "CE", "C", "+-", "sqrt"};
            for (int i = 0; i < 5; ++i)
            {
                buttons[i, 1] = new System.Windows.Forms.Button();
                buttons[i, 1].Name = otherOperation[i];
                buttons[i, 1].Text = otherOperation[i];
                buttons[i, 1].Dock = System.Windows.Forms.DockStyle.Fill;
                buttons[i, 1].UseVisualStyleBackColor = true;
                buttons[i, 1].Click += new System.EventHandler(this.ButtonClick);
                this.tableLayoutPanel1.Controls.Add(buttons[i, 1], i, 1);
            }

        }

        public bool Digit(String count)
        {
            return (count[0] <= '9' && count[0] >= '0');
        }

        public void Assembly()
        {
            String ourNumber = this.WholePart + '.' + this.FractionalPart;
            this.Value = Double.Parse(ourNumber);
        }

        public void ThisOperation()
        {
            


            switch (this.Operation)
            {
                case "sqrt":
                    {
                        this.Value = Math.Sqrt(this.Value);
                        this.Operation = "";
                        break;
                    }
                case "1/x":
                    {
                        this.Value = 1 / (this.Value);
                        this.Operation = "";
                        break;
                    }
                case "+-":
                    {
                        this.Value = -this.Value;
                        this.Operation = "";
                        break;
                    }
               

            }

        }

        public bool IsBinary()
        {
            return this.Operation == "+" || this.Operation == "-" || this.Operation == "*" || this.Operation == "/";
        }


        public void ButtonClick(object sender, EventArgs e)
        {
            Button countButton = (Button)sender;
 
            if (countButton.Text == "," && !this.Dot)
            {
                this.Dot = true;
                return;
            }

            if (Digit(countButton.Text) && !this.Dot)
            {
                this.WholePart = this.WholePart + countButton.Text[0];
                return;
            }

            if (Digit(countButton.Text) && this.Dot)
            {
                this.FractionalPart = this.FractionalPart + countButton.Text[0];
                return;
            }


            if (countButton.Text != "=")
            {
                this.Assembly();
                this.Operation = countButton.Text;
                if (!this.IsBinary())
                {
                    this.ThisOperation();
                    return;
                }
                
            }              
            


        }
    }
}
