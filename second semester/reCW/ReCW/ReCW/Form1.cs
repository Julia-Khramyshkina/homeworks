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
        private Button[] buttons = new Button [9];
        private bool click = true;
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));

            this.tableLayoutPanel1.Location = new System.Drawing.Point(-2, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(287, 262);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            int number = 0;
            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < 3; ++j)
                {
                    buttons[number] = new System.Windows.Forms.Button();
                    buttons[number].Location = new System.Drawing.Point(3 + 95 * i, 3 + 95 * j);
                    buttons[number].Name = "button" + number.ToString();
                    buttons[number].Size = new System.Drawing.Size(89, 81);
                    buttons[number].TabIndex = number;
                    buttons[number].UseVisualStyleBackColor = true;
                    buttons[number].Click += new System.EventHandler(this.ButtonClick);
                    this.tableLayoutPanel1.Controls.Add(buttons[number], i, j);
                    ++number;
                }
            }
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button countButton = (Button)sender;
            if (countButton.Text != "")
                return;

            if (click)
            {
                countButton.Text = "X";
                if (this.Win())
                {
                    countButton.Text = "X, WIN";
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
                }
                click = !click;
            }

        }

        private bool Win()
        {
            
            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < 3; ++ j)
                {
                    if (buttons[i].Text == buttons[i + 1].Text &&  buttons[i + 1].Text
                        == buttons[i + 2].Text && buttons[i + 2].Text != "")
                        return true;

                    if (buttons[j].Text == buttons[j + 3].Text && buttons[j + 3].Text
                        == buttons[j + 6].Text && buttons[j + 6].Text != "")
                        return true;
                }
            }

            if (buttons[0].Text == buttons[4].Text && buttons[4].Text == buttons[8].Text
                && buttons[8].Text != "")
                return true;

            if (buttons[2].Text == buttons[4].Text && buttons[4].Text == buttons[6].Text
                && buttons[6].Text != "")
                return true;

            return false;        

        }


    }
}
