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
    /// Логика взаимодействия для задание_4.xaml
    /// </summary>
    public partial class задание_4 : Window
    {
        public задание_4()
        {
            InitializeComponent();
        }
        //задание 4
        int Crystal = 0;
        private void Buy_Click(object sender, RoutedEventArgs e)
        {
            double Gold = Convert.ToDouble(gold.Text);
            if (Gold > 45)
            {
                Gold -= 45;
                Crystal += 5;
                crystalQuantity.Content = $"Кол-во кристалов: {Crystal}";
                goldQuantity.Foreground = Brushes.Black;
                goldQuantity.Text = $"{Gold}";
            }
            else
            {
                goldQuantity.Foreground = Brushes.Red;
                goldQuantity.Text = "Недостаточно денег для покупки!";
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
