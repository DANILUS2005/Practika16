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
    /// Логика взаимодействия для задание_6.xaml
    /// </summary>
    public partial class задание_6 : Window
    {
        public задание_6()
        {
            InitializeComponent();
        }
        int i = 0;
        private void Add_Click(object sender, RoutedEventArgs e) //6 задание
        {
            string Name = Convert.ToString(name.Text);
            Double Age = Convert.ToDouble(age.Text);
            string Zodiac = Convert.ToString(zodiac.Text);
            string Work = Convert.ToString(work.Text);
            result.Text = $"Вас зовут {Name}, вам {Age} лет, ваш знак зодиака {Zodiac}, вашей профессией является {Work}.";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }
    }
}
