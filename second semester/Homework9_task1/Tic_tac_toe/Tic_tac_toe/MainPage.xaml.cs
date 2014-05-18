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
        internal System.Windows.Controls.Button[] buttons = new System.Windows.Controls.Button[9];
        private int Change = 0;
        private bool Win = false;


        public MainPage()
        {
            InitializeComponent();
            buttons[0] = button1;
            buttons[1] = button2;
            buttons[2] = button3;
            buttons[3] = button4;
            buttons[4] = button5;
            buttons[5] = button6;
            buttons[6] = button7;
            buttons[7] = button8;
            buttons[8] = button9;

        }

        private bool IsWin()
        {
            for (int i = 0; i < 3; ++i)
            {
                if (buttons[i].Content == buttons[i + 3].Content && buttons[i + 3].Content == buttons[i + 6].Content && buttons[i + 6].Content.ToString() != "")
                    return true;
            }
            int j = 0;
            while (j < 7)
            {
                if (buttons[j].Content == buttons[j + 1].Content && buttons[j + 1].Content == buttons[j + 2].Content && buttons[j + 2].Content.ToString() != "")
                    return true;
                j = j + 3;
            }

            if (buttons[0].Content == buttons[4].Content && buttons[4].Content == buttons[8].Content && buttons[8].Content.ToString() != "")
                return true;
            if (buttons[2].Content == buttons[4].Content && buttons[4].Content == buttons[6].Content && buttons[6].Content.ToString() != "")
                return true;

            return false;

        }


        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            Button countButton = (Button)sender;
            if (this.Win)
                return;

            if (countButton.Name.ToString() == "Change0" && this.Change == 0)
            {
                this.Change = -1;
                countButton.Content = countButton.Content + "!";
                return;
            }
            if (this.Change == 0 && countButton.Name.ToString() == "ChangeX")
            {
                this.Change = 1;
                countButton.Content = countButton.Content + "!";
                return;
            }
            



            if (countButton.Content.ToString() != "")
                return;


            if (this.Change == 1)
            {
                countButton.Content = "X";

                if (this.IsWin())
                {
                    countButton.Content = "X! WIN";
                    this.Win = true;
                    return;
                }                 
            }
            else
            {
                countButton.Content = "0";
                if (this.IsWin())
                {
                    countButton.Content = "0! WIN";
                    this.Win = true;
                    return;
                }
            }



            for (int i = 0; i < 9; ++i)
            {
                if (buttons[i].Content == "")
                {
                    if (this.Change == 1)
                    {
                        buttons[i].Content = "0";
                        if (this.IsWin())
                        {
                            countButton.Content = "0! WIN";
                            this.Win = true;
                        }
                        return;
                    }
                    else
                    {
                        buttons[i].Content = "X";
                        if (this.IsWin())
                        {
                            countButton.Content = "X! WIN";
                            this.Win = true;
                        }     
                        return;
                    }
                }
            }
      


        }

       
    }
}
