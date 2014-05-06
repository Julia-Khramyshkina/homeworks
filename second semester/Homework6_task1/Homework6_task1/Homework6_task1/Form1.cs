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

        private bool GetResult = false;


        public Calculator()
        {
            InitializeComponent();
        }

        public bool Digit(String count)
        {
            return (count[0] <= '9' && count[0] >= '0');
        }

        public double Assembly()
        {
            if (FractionalPart == "")
            {
                this.FractionalPart = "0";
            }
            String ourNumber = this.WholePart + ',' + this.FractionalPart;
            this.WholePart = "";
            this.FractionalPart = "";
            this.Dot = false;
            return Double.Parse(ourNumber);
        }

        public void ThisOperation()
        {
            
            switch (this.Operation)
            {
                case "sqrt":
                    {
                        this.Value = this.Assembly();
                        this.Value = Math.Sqrt(this.Value);
                        this.Operation = "";
                        this.GetResult = true;
                        textBox1.Text = this.Value.ToString();
                        break;
                    }
                case "reverse":
                    {
                        if (this.Value == 0)
                            this.Value = this.Assembly();
                        this.Value = Math.Pow(this.Value, -1);
                        this.Operation = "";
                        this.GetResult = true;
                        textBox1.Text = this.Value.ToString();
                        break;
                    }
                case "+-":   
                    {
                        if (this.Value != 0)
                        {
                            this.Value = -this.Value;
                        }
                        else
                        {
                            this.Value = this.Assembly();
                        }

                        this.GetResult = true;
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
                        this.Operation = "";
                        this.Value = this.Value + this.TempValue;
                        this.TempValue = 0;
                        textBox1.Text = this.Value.ToString();
                        this.GetResult = true;
                        break;
                    }

                case "-":
                    {
                        this.Operation = "";
                        this.Value = this.Value - this.TempValue;
                        this.TempValue = 0;
                        textBox1.Text = this.Value.ToString();
                        this.GetResult = true;
                        break;
                    }

                case "*":
                    {
                        this.Operation = "";
                        this.Value = this.Value * this.TempValue;
                        this.TempValue = 0;
                        textBox1.Text = this.Value.ToString();
                        this.GetResult = true;
                        break;
                    }

                case "/":
                    {
                        this.Operation = "";
                        this.Value = this.Value / this.TempValue;
                        this.TempValue = 0;
                        textBox1.Text = this.Value.ToString();
                        this.GetResult = true;
                        break;
                    }
            }
        }

        public void Clear()
        {
            this.TempValue = 0;
            this.Value = 0;
            this.FractionalPart = "";
            this.WholePart = "";
            this.Dot = false;
            this.Operation = "";
            textBox1.Text = "";
            this.GetResult = false;
        }


        public void ButtonClick(object sender, EventArgs e)
        {
            Button countButton = (Button)sender;

            if (this.Value != 0 && this.Operation == "" && Digit(countButton.Text) && !this.GetResult)
            {
                this.WholePart = this.WholePart + countButton.Text[0];
                textBox1.Text = countButton.Text[0].ToString();
                return;
            }

            if (this.Value != 0 && this.Operation == "" && Digit(countButton.Text) && this.GetResult)
            {
                this.Clear();
                return;
            }

            if (countButton.Text == "C")
            {
                this.Clear();
                return;
            }

            if (countButton.Text == "CE")
            {
                this.FractionalPart = "";
                this.WholePart = "";

                if (this.Value != 0 && this.Operation != "")
                {
                    this.TempValue = 0;
                    textBox1.Text = this.Value.ToString() + this.Operation;
                    return;
                }

                if (this.Value != 0)
                {
                    this.Clear();
                    textBox1.Text = "";
                    return;
                }
            }

            if (this.Operation == "" && this.Value != 0 && countButton.Text != "=")
            {
                this.Operation = countButton.Text;
                textBox1.Text = this.Value.ToString() + countButton.Text[0];
                return;
            }

            if (countButton.Text == "," && !this.Dot)
            {
                this.Dot = true;
                textBox1.Text = textBox1.Text + countButton.Text[0];
                return;
            }


            //if (Digit(countButton.Text) && this.Operation != "")
            //{
            //    this.BinaryOperation();
            //    textBox1.Text = this.Value.ToString();
            //    return;

            //}

            if (Digit(countButton.Text) && !this.Dot)
            {
                this.WholePart = this.WholePart + countButton.Text[0];
                textBox1.Text = textBox1.Text + countButton.Text[0];
                if (this.Operation != "")
                {
                    this.TempValue = this.Assembly();
                    //this.BinaryOperation();
                    //textBox1.Text = this.Value.ToString() + ;
                    return;

                }
                return;
            }

            if (Digit(countButton.Text) && this.Dot)
            {
                this.FractionalPart = this.FractionalPart + countButton.Text[0];
                textBox1.Text = textBox1.Text + countButton.Text[0];
                return;
            }

            if (this.Operation == "" && countButton.Text != "=")
            {
                this.Operation = countButton.Text;

                if (!this.IsBinary())
                {
                    this.ThisOperation();
                    this.Operation = "";
                    return;
                }

                

                if (this.Value != 0 && this.IsBinary())
                {

                    textBox1.Text = this.Value.ToString() + countButton.Text[0];

                    return;
                }
                else
                {
                    textBox1.Text = textBox1.Text + countButton.Text[0];
                }
                

            }           


            if (this.Value != 0 && this.TempValue != 0 && this.IsBinary() && countButton.Text != "=")
            {
                this.BinaryOperation();
                textBox1.Text = this.Value.ToString() + countButton.Text;
                this.Operation = countButton.Text;
                return;
            }


            if (this.Value == 0)
            {
                this.Value = this.Assembly();
            }
            else
            {
                this.TempValue = this.Assembly();
            }

            

            if (countButton.Text == "=" )
            {
                if (this.Value != 0 && this.TempValue != 0 && this.IsBinary())
                {
                    this.BinaryOperation();
                }
                this.Operation = "";
                textBox1.Text = this.Value.ToString() + "ololo";
                return;
              
            }
        }

    }
}