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
using System.Windows.Shapes;

namespace Задание_2._16
{
    /// <summary>
    /// Логика взаимодействия для задание_5.xaml
    /// </summary>
    public partial class задание_5 : Window
    {
        public задание_5()
        {
            InitializeComponent();
        }
        private void calculate_Click(object sender, RoutedEventArgs e)
        {
            double hour;
            double minut;
            double people = Convert.ToDouble(People.Text);
            if (people > 0 || people == 1)
            {
                hour = Math.Truncate(people * 10 / 60);
                minut = people * 10 % 60;
                if (hour < 5)
                {
                    answer1.Content = $"Вы должны отстоять в очереди {hour} часа и {minut} минут";
                    answer1.Foreground = Brushes.Black;
                }
                else if (hour > 4)
                {
                    answer1.Content = $"Вы должны отстоять в очереди {hour} часов и {minut} минут";
                    answer1.Foreground = Brushes.Black;
                }
                else if (hour == 0)
                {
                    answer1.Content = $"Вы должны отстоять в очереди {minut} минут";
                    answer1.Foreground = Brushes.Black;
                }

            }
            else
            {
                answer1.Content = "Данные введены некоректно";
                answer1.Foreground = Brushes.Red;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }
    }
}
