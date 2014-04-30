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
        private String WholePart = "";
        private String FractionalPart = "";
        private bool Dot = false;

        private double Value;

        private double TempValue;

        private String Operation = "";


        public Calculator()
        {
            InitializeComponent();
        }

        public bool Digit(String count)
        {
            return (count[0] <= '9' && count[0] >= '0');
        }

        public void Assembly()
        {
            if (FractionalPart == "")
            {
                this.FractionalPart = "0";
            }
            String ourNumber = this.WholePart + ',' + this.FractionalPart;
            this.WholePart = "";
            this.FractionalPart = "";
            this.Dot = false;
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
                        textBox1.Text = this.Value.ToString();
                        break;
                    }
                case "1/x":
                    {
                        this.Value = 1 / (this.Value);
                        this.Operation = "";
                        textBox1.Text = this.Value.ToString();
                        break;
                    }
                case "+-":
                    {
                        this.Value = -this.Value;
                        this.Operation = "";
                        textBox1.Text = this.Value.ToString();
                        break;
                    }
               

            }

        }

        public bool IsBinary()
        {
            return this.Operation == "+" || this.Operation == "-" || this.Operation == "*" || this.Operation == "/";
        }

        public void BinaryOperation()
        {
            switch (this.Operation)
            {

                case "+":
                    {
                        this.TempValue = this.Value;
                        this.Assembly();
                        this.Value = this.Value + this.TempValue;
                        textBox1.Text = this.Value.ToString();
                        break;
                    }

                case "-":
                    {
                        this.TempValue = this.Value;
                        this.Assembly();
                        this.Value = this.Value - this.TempValue;
                        textBox1.Text = this.Value.ToString();
                        break;
                    }

                case "*":
                    {
                        this.TempValue = this.Value;
                        this.Assembly();
                        this.Value = this.Value * this.TempValue;
                        textBox1.Text = this.Value.ToString();
                        break;
                    }

                case "/":
                    {
                        this.TempValue = this.Value;
                        this.Assembly();
                        this.Value = this.Value / this.TempValue;
                        textBox1.Text = this.Value.ToString();
                        break;
                    }
            }
        }

        public void ButtonClick(object sender, EventArgs e)
        {
            Button countButton = (Button)sender;
            if (countButton.Text == "," && !this.Dot)
            {
                this.Dot = true;
                textBox1.Text = textBox1.Text + (countButton.Text[0]).ToString();
                return;
            }

            if (Digit(countButton.Text) && !this.Dot)
            {
                this.WholePart = this.WholePart + countButton.Text[0];
                textBox1.Text = textBox1.Text + (countButton.Text[0]).ToString();
                return;
            }

            if (Digit(countButton.Text) && this.Dot)
            {
                this.FractionalPart = this.FractionalPart + countButton.Text[0];
                textBox1.Text = textBox1.Text + (countButton.Text[0]).ToString();
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
                textBox1.Text = textBox1.Text + (countButton.Text[0]).ToString();
                if (this.FractionalPart != "" || this.WholePart != "")
                {
                    this.BinaryOperation();
                }
            }

            if (countButton.Text == "=")
            {
                textBox1.Text = this.Value.ToString();
            }


        }

    }
}