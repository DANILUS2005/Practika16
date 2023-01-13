using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Калькудлятор
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        int g = 0;
        private void К1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (choice.SelectedIndex)
                {
                    case 0:
                        double x = Convert.ToDouble(P1.Text);
                        double y = Convert.ToDouble(P2.Text);
                        Ответ.Content = x + y;

                        break;

                    case 1:
                        x = Convert.ToDouble(P1.Text);
                        y = Convert.ToDouble(P2.Text);
                        Ответ.Content = x - y;
                        break;

                    case 2:
                        x = Convert.ToDouble(P1.Text);
                        y = Convert.ToDouble(P2.Text);
                        if (y == 0)
                        {
                            ПЧ2.Content = "На ноль делить нельзя";
                            ПЧ2.Foreground = Brushes.Red;
                        }


                        else
                        {
                            Ответ.Content = x / y;
                        }
                        break;

                    case 3:
                        x = Convert.ToDouble(P1.Text);
                        y = Convert.ToDouble(P2.Text);
                        Ответ.Content = x * y;
                        break;

                    case 4:
                        x = Convert.ToDouble(P1.Text);
                        Ответ.Content = Math.Round(Math.Sin(x));
                        break;

                    case 5:
                        x = Convert.ToDouble(P1.Text);
                        Ответ.Content = Math.Round(Math.Cos(x), 4);
                        break;

                    case 6:
                        x = Convert.ToDouble(P1.Text);
                        Ответ.Content = Math.Round(Math.Tan(x));
                        break;

                    case 7:
                        x = Convert.ToDouble(P1.Text);
                        Ответ.Content = Math.Round(1 / Math.Tan(x));
                        break;
                }
            }

            catch
            {
                Ответ.Content = "Error";
            }
        }

        private void К2_Click(object sender, RoutedEventArgs e)
        {
            if (g % 2 == 0)
            {
                P2.Visibility = Visibility.Hidden;
                P2.Clear();
                g += 1;
            }
            else
            {
                P2.Visibility = Visibility.Visible;
                g += 1;
            }
        }

        private void Ч2_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }

        private void Ч1_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }

        private void choice_ContextMenuClosing(object sender, ContextMenuEventArgs e)
        {

        }

        private void P1_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }

        private void P2_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }
    }
}
        