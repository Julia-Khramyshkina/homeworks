using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;


namespace Tic_tac_toe
{
    public partial class MainPage : UserControl
    {
        
        internal System.Windows.Controls.Button[,] buttons = new System.Windows.Controls.Button[3, 3];
        //private bool click = true;
        //private bool win = false;

        public MainPage()
        {
            InitializeComponent();

            //this._1 = ((System.Windows.Controls.Button)(this.FindName("_1")));

            int number = 0;
            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < 3; ++j)
                {
                    //System.Windows.Controls.Button


                    //buttons[i, j] = ((System.Windows.Controls.Button)(this.FindName("butt" + number.ToString())));
                    //buttons[i, j].Content = "i";

                          //  <Button x:Name="_1" Content="Button" HorizontalAlignment="Left" Margin="175,84,0,0" VerticalAlignment="Top" Width="75" Click="Button_Click_1"/>

               //     this.LayoutRoot.
                //    buttons[i, j]. = new System.Drawing.Point(3 + 95 * i, 3 + 95 * j);
                    //buttons[i, j].Name = "button" + number.ToString();
                 //   buttons[i, j].ActualHeight = new 81;
                //    buttons[i, j].TabIndex = number;
                //    buttons[i, j].UseVisualStyleBackColor = true;
              //      buttons[i, j].Click += new System.EventHandler(this.Button_Click_1);

                    //this.
                    //this.tableLayoutPanel1.Controls.Add(buttons[i, j], i, j);
                    ++number;
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;

            bt.Content = "1";


            //bt.
        }

       
    }
}
