using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace _11_project
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public bool xo = true;
        static int count_X = 0, count_O = 0;
        static Random rand = new Random();

        public MainPage()
        {
            this.InitializeComponent();

            Button_1.IsEnabled = false;
            Button_2.IsEnabled = false;
            Button_3.IsEnabled = false;
            Button_4.IsEnabled = false;
            Button_5.IsEnabled = false;
            Button_6.IsEnabled = false;
            Button_7.IsEnabled = false;
            Button_8.IsEnabled = false;
            Button_9.IsEnabled = false;

            but_reset.Visibility = Visibility.Collapsed;
        }

        public void Security()
        {

            Button_1.IsEnabled = false;
            Button_2.IsEnabled = false;
            Button_3.IsEnabled = false;
            Button_4.IsEnabled = false;
            Button_5.IsEnabled = false;
            Button_6.IsEnabled = false;
            Button_7.IsEnabled = false;
            Button_8.IsEnabled = false;
            Button_9.IsEnabled = false;

            but_reset.Visibility = Visibility.Visible;
        }

        private void Start_the_game_Click(object sender, RoutedEventArgs e)
        {
            Button_1.IsEnabled = true;
            Button_2.IsEnabled = true;
            Button_3.IsEnabled = true;
            Button_4.IsEnabled = true;
            Button_5.IsEnabled = true;
            Button_6.IsEnabled = true;
            Button_7.IsEnabled = true;
            Button_8.IsEnabled = true;
            Button_9.IsEnabled = true;

            Start_the_game.Visibility = Visibility.Collapsed;
            but_reset.Visibility = Visibility.Visible;
        }

        private void Button_1_Click(object sender, RoutedEventArgs e)
        {
            bool empty = false;

            if (!Choice.IsChecked.Value) {

                Button button = (sender as Button);
                button.IsEnabled = false;
                
                if (xo) {

                    button.Content = "X";
                }
                else {

                    button.Content = "O";
                }

                xo = !xo;

                check();
            }
            else
            {
                Button button = (sender as Button);
                button.IsEnabled = false;
                

                button.Content = "X";

                xo = !xo;

                while(!empty) {

                    switch (rand.Next(1, 9)) {

                        case 1: {

                                if(Button_1.IsEnabled) {

                                    Button_1.IsEnabled = false;
                                    Button_1.Content = "O";
                                    empty = true;
                                }

                                if (!Button_1.IsEnabled && !Button_2.IsEnabled && !Button_3.IsEnabled && !Button_4.IsEnabled && !Button_5.IsEnabled && !Button_6.IsEnabled && !Button_7.IsEnabled && !Button_8.IsEnabled && !Button_9.IsEnabled)
                                {
                                    empty = true;
                                }
                                break;
                        }

                        case 2:
                            {
                                if (Button_2.IsEnabled)
                                {
                                    Button_2.IsEnabled = false;
                                    Button_2.Content = "O";
                                    empty = true;
                                }

                                if (!Button_1.IsEnabled && !Button_2.IsEnabled && !Button_3.IsEnabled && !Button_4.IsEnabled && !Button_5.IsEnabled && !Button_6.IsEnabled && !Button_7.IsEnabled && !Button_8.IsEnabled && !Button_9.IsEnabled)
                                {
                                    empty = true;
                                }
                                break;
                            }

                        case 3:
                            {
                                if (Button_3.IsEnabled)
                                {
                                    Button_3.IsEnabled = false;
                                    Button_3.Content = "O";
                                    empty = true;
                                }

                                if (!Button_1.IsEnabled && !Button_2.IsEnabled && !Button_3.IsEnabled && !Button_4.IsEnabled && !Button_5.IsEnabled && !Button_6.IsEnabled && !Button_7.IsEnabled && !Button_8.IsEnabled && !Button_9.IsEnabled)
                                {
                                    empty = true;
                                }
                                break;
                            }

                        case 4:
                            {
                                if (Button_4.IsEnabled)
                                {
                                    Button_4.IsEnabled = false;
                                    Button_4.Content = "O";
                                    empty = true;
                                }

                                if (!Button_1.IsEnabled && !Button_2.IsEnabled && !Button_3.IsEnabled && !Button_4.IsEnabled && !Button_5.IsEnabled && !Button_6.IsEnabled && !Button_7.IsEnabled && !Button_8.IsEnabled && !Button_9.IsEnabled)
                                {
                                    empty = true;
                                }
                                break;
                            }

                        case 5:
                            {
                                if (Button_5.IsEnabled)
                                {
                                    Button_5.IsEnabled = false;
                                    Button_5.Content = "O";
                                    empty = true;
                                }

                                if (!Button_1.IsEnabled && !Button_2.IsEnabled && !Button_3.IsEnabled && !Button_4.IsEnabled && !Button_5.IsEnabled && !Button_6.IsEnabled && !Button_7.IsEnabled && !Button_8.IsEnabled && !Button_9.IsEnabled)
                                {
                                    empty = true;
                                }
                                break;
                            }

                        case 6:
                            {
                                if (Button_6.IsEnabled)
                                {
                                    Button_6.IsEnabled = false;
                                    Button_6.Content = "O";
                                    empty = true;
                                }

                                if (!Button_1.IsEnabled && !Button_2.IsEnabled && !Button_3.IsEnabled && !Button_4.IsEnabled && !Button_5.IsEnabled && !Button_6.IsEnabled && !Button_7.IsEnabled && !Button_8.IsEnabled && !Button_9.IsEnabled)
                                {
                                    empty = true;
                                }
                                break;
                            }

                        case 7:
                            {
                                if (Button_7.IsEnabled)
                                {
                                    Button_7.IsEnabled = false;
                                    Button_7.Content = "O";
                                    empty = true;
                                }

                                if (!Button_1.IsEnabled && !Button_2.IsEnabled && !Button_3.IsEnabled && !Button_4.IsEnabled && !Button_5.IsEnabled && !Button_6.IsEnabled && !Button_7.IsEnabled && !Button_8.IsEnabled && !Button_9.IsEnabled)
                                {
                                    empty = true;
                                }
                                break;
                            }

                        case 8:
                            {
                                if (Button_8.IsEnabled)
                                {
                                    Button_8.IsEnabled = false;
                                    Button_8.Content = "O";
                                    empty = true;
                                }

                                if (!Button_1.IsEnabled && !Button_2.IsEnabled && !Button_3.IsEnabled && !Button_4.IsEnabled && !Button_5.IsEnabled && !Button_6.IsEnabled && !Button_7.IsEnabled && !Button_8.IsEnabled && !Button_9.IsEnabled)
                                {
                                    empty = true;
                                }
                                break;
                            }

                        case 9:
                            {
                                if (Button_9.IsEnabled)
                                {
                                    Button_9.IsEnabled = false;
                                    Button_9.Content = "O";
                                    empty = true;
                                }

                                if (!Button_1.IsEnabled && !Button_2.IsEnabled && !Button_3.IsEnabled && !Button_4.IsEnabled && !Button_5.IsEnabled && !Button_6.IsEnabled && !Button_7.IsEnabled && !Button_8.IsEnabled && !Button_9.IsEnabled)
                                {
                                    empty = true;
                                }
                                break;
                            }
                    }
                }

                //xo = !xo;

                check();
            }
        }

        private void but_reset_Click(object sender, RoutedEventArgs e)
        {
            Button_1.IsEnabled = false;
            Button_2.IsEnabled = false;
            Button_3.IsEnabled = false;
            Button_4.IsEnabled = false;
            Button_5.IsEnabled = false;
            Button_6.IsEnabled = false;
            Button_7.IsEnabled = false;
            Button_8.IsEnabled = false;
            Button_9.IsEnabled = false;

            Button_1.Content = "";
            Button_2.Content = "";
            Button_3.Content = "";
            Button_4.Content = "";
            Button_5.Content = "";
            Button_6.Content = "";
            Button_7.Content = "";
            Button_8.Content = "";
            Button_9.Content = "";

            xo = true;

            but_reset.Visibility = Visibility.Collapsed;
            Start_the_game.Visibility = Visibility.Visible;
        }

        async void check()
        {
            bool win = false;

            if((Button_7.Content.ToString() == "X" ) && (Button_8.Content.ToString() == "X") && (Button_9.Content.ToString() == "X"))
            {
                var dialog_win_x = new MessageDialog("X is Winer!").ShowAsync();
                win = true;
                Security();
                count_X++;
                Button_1.Content = "";
                Button_2.Content = "";
                Button_3.Content = "";
                Button_4.Content = "";
                Button_5.Content = "";
                Button_6.Content = "";
                count_x.Text = "X: " + count_X;
            }
            else if ((Button_4.Content.ToString() == "X") && (Button_5.Content.ToString() == "X") && (Button_6.Content.ToString() == "X"))
            {
                var dialog_win_x = new MessageDialog("X is Winer!").ShowAsync();
                win = true;
                Security();
                count_X++;
                Button_1.Content = "";
                Button_2.Content = "";
                Button_3.Content = "";
                Button_7.Content = "";
                Button_8.Content = "";
                Button_9.Content = "";
                count_x.Text = "X: " + count_X;
            }
            else if ((Button_1.Content.ToString() == "X") && (Button_2.Content.ToString() == "X") && (Button_3.Content.ToString() == "X"))
            {
                var dialog_win_x = new MessageDialog("X is Winer!").ShowAsync();
                win = true;
                Security();
                count_X++;
                Button_7.Content = "";
                Button_8.Content = "";
                Button_9.Content = "";
                Button_4.Content = "";
                Button_5.Content = "";
                Button_6.Content = "";
                count_x.Text = "X: " + count_X;
            }
            //
            else if ((Button_7.Content.ToString() == "X") && (Button_4.Content.ToString() == "X") && (Button_1.Content.ToString() == "X"))
            {
                var dialog_win_x = new MessageDialog("X is Winer!").ShowAsync();
                win = true;
                Security();
                count_X++;
                Button_8.Content = "";
                Button_2.Content = "";
                Button_3.Content = "";
                Button_9.Content = "";
                Button_5.Content = "";
                Button_6.Content = "";
                count_x.Text = "X: " + count_X;
            }
            else if ((Button_8.Content.ToString() == "X") && (Button_5.Content.ToString() == "X") && (Button_2.Content.ToString() == "X"))
            {
                var dialog_win_x = new MessageDialog("X is Winer!").ShowAsync();
                win = true;
                Security();
                count_X++;
                Button_1.Content = "";
                Button_9.Content = "";
                Button_3.Content = "";
                Button_4.Content = "";
                Button_7.Content = "";
                Button_6.Content = "";
                count_x.Text = "X: " + count_X;
            }
            else if ((Button_9.Content.ToString() == "X") && (Button_6.Content.ToString() == "X") && (Button_3.Content.ToString() == "X")) {

                var dialog_win_x = new MessageDialog("X is Winer!").ShowAsync();
                win = true;
                Security();
                count_X++;
                Button_1.Content = "";
                Button_2.Content = "";
                Button_8.Content = "";
                Button_4.Content = "";
                Button_5.Content = "";
                Button_7.Content = "";
                count_x.Text = "X: " + count_X;
            }
            //
            else if ((Button_7.Content.ToString() == "X") && (Button_5.Content.ToString() == "X") && (Button_3.Content.ToString() == "X"))
            {
                var dialog_win_x = new MessageDialog("X is Winer!").ShowAsync();
                win = true;
                Security();
                count_X++;
                Button_1.Content = "";
                Button_2.Content = "";
                Button_9.Content = "";
                Button_4.Content = "";
                Button_8.Content = "";
                Button_6.Content = "";
                count_x.Text = "X: " + count_X;
            }
            else if ((Button_9.Content.ToString() == "X") && (Button_5.Content.ToString() == "X") && (Button_1.Content.ToString() == "X"))
            {
                var dialog_win_x = new MessageDialog("X is Winer!").ShowAsync();
                win = true;
                Security();
                count_X++;
                Button_8.Content = "";
                Button_2.Content = "";
                Button_3.Content = "";
                Button_4.Content = "";
                Button_7.Content = "";
                Button_6.Content = "";
                count_x.Text = "X: " + count_X;
            }
            //
            else if ((Button_7.Content.ToString() == "O") && (Button_8.Content.ToString() == "O") && (Button_9.Content.ToString() == "O"))
            {
                var dialog_win_x = new MessageDialog("O is Winer!").ShowAsync();
                win = true;
                Security();
                count_O++;
                Button_1.Content = "";
                Button_2.Content = "";
                Button_3.Content = "";
                Button_4.Content = "";
                Button_5.Content = "";
                Button_6.Content = "";
                count_o.Text = "O: " + count_O;
            }
            else if ((Button_4.Content.ToString() == "O") && (Button_5.Content.ToString() == "O") && (Button_6.Content.ToString() == "O"))
            {
                var dialog_win_x = new MessageDialog("O is Winer!").ShowAsync();
                win = true;
                Security();
                count_O++;
                Button_1.Content = "";
                Button_2.Content = "";
                Button_3.Content = "";
                Button_7.Content = "";
                Button_8.Content = "";
                Button_9.Content = "";
                count_o.Text = "O: " + count_O;
            }
            else if ((Button_1.Content.ToString() == "O") && (Button_2.Content.ToString() == "O") && (Button_3.Content.ToString() == "O"))
            {
                var dialog_win_x = new MessageDialog("O is Winer!").ShowAsync();
                win = true;
                Security();
                count_O++;
                Button_9.Content = "";
                Button_8.Content = "";
                Button_7.Content = "";
                Button_4.Content = "";
                Button_5.Content = "";
                Button_6.Content = "";
                count_o.Text = "O: " + count_O;
            }
            //
            else if ((Button_7.Content.ToString() == "O") && (Button_4.Content.ToString() == "O") && (Button_1.Content.ToString() == "O"))
            {
                var dialog_win_x = new MessageDialog("O is Winer!").ShowAsync();
                win = true;
                Security();
                count_O++;
                Button_9.Content = "";
                Button_2.Content = "";
                Button_3.Content = "";
                Button_8.Content = "";
                Button_5.Content = "";
                Button_6.Content = "";
                count_o.Text = "O: " + count_O;
            }
            else if ((Button_8.Content.ToString() == "O") && (Button_5.Content.ToString() == "O") && (Button_2.Content.ToString() == "O"))
            {
                var dialog_win_x = new MessageDialog("O is Winer!").ShowAsync();
                win = true;
                Security();
                count_O++;
                Button_1.Content = "";
                Button_9.Content = "";
                Button_3.Content = "";
                Button_4.Content = "";
                Button_7.Content = "";
                Button_6.Content = "";
                count_o.Text = "O: " + count_O;
            }
            else if ((Button_9.Content.ToString() == "O") && (Button_6.Content.ToString() == "O") && (Button_3.Content.ToString() == "O"))
            {
                var dialog_win_x = new MessageDialog("O is Winer!").ShowAsync();
                win = true;
                Security();
                count_O++;
                Button_1.Content = "";
                Button_2.Content = "";
                Button_8.Content = "";
                Button_4.Content = "";
                Button_5.Content = "";
                Button_7.Content = "";
                count_o.Text = "O: " + count_O;
            }
            //
            else if ((Button_7.Content.ToString() == "O") && (Button_5.Content.ToString() == "O") && (Button_3.Content.ToString() == "O"))
            {
                var dialog_win_x = new MessageDialog("O is Winer!").ShowAsync();
                win = true;
                Security();
                count_O++;
                Button_1.Content = "";
                Button_2.Content = "";
                Button_9.Content = "";
                Button_4.Content = "";
                Button_8.Content = "";
                Button_6.Content = "";
                count_o.Text = "O: " + count_O;
            }
            else if ((Button_9.Content.ToString() == "O") && (Button_5.Content.ToString() == "O") && (Button_1.Content.ToString() == "O"))
            {
                var dialog_win_x = new MessageDialog("O is Winer!").ShowAsync();
                win = true;
                Security();
                count_O++;
                Button_8.Content = "";
                Button_2.Content = "";
                Button_3.Content = "";
                Button_4.Content = "";
                Button_7.Content = "";
                Button_6.Content = "";
                count_o.Text = "O: " + count_O;
            }
            else if((!win) && (!Button_1.IsEnabled) && (!Button_2.IsEnabled) && (!Button_3.IsEnabled) && (!Button_4.IsEnabled) && (!Button_5.IsEnabled) && (!Button_6.IsEnabled) && (!Button_7.IsEnabled) && (!Button_8.IsEnabled) && (!Button_9.IsEnabled))
            {
                var dialog_win_x = new MessageDialog("We dont have a winer!").ShowAsync();
            }


        }

    }
}
