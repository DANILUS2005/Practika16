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
    /// Логика взаимодействия для з3.xaml
    /// </summary>
    public partial class з3 : Window
    {
        public з3()
        {
            InitializeComponent();
        }
        private void Razbros_Click(object sender, RoutedEventArgs e)
        {
            int k = 52 / 3;
            Ryadi.Text = $"{k}";
            int h = 52 % 3;
            Lishnie.Text = $"{h}";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }
    }
}
