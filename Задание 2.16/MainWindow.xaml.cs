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

namespace Задание_2._16
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
        //задание 1
        int Birthday; //хранит целое число от -2147483648 до 2147483647 и занимает 4 байта. Представлен системным типом System.Int32.
        double the_quality_of_life; //хранит число с плавающей точкой от ±5.0*10-324 до ±1.7*10308 и занимает 8 байта.Представлен системным типом System.Double
        string userName; //хранит набор символов Unicode. Представлен системным типом System.String.
        bool check; //хранит значение true или false (логические литералы). Представлен системным типом System.Boolean
        char entrance; //хранит одиночный символ в кодировке Unicode и занимает 2 байта. Представлен системным типом System.Char.
        byte company; //хранит целое число от 0 до 255 и занимает 1 байт.Представлен системным типом System.Byte
        short breeds; // хранит целое число от -32768 до 32767 и занимает 2 байта.Представлен системным типом System.Int16
        long death; //хранит целое число от –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807 и занимает 8 байт.Представлен системным типом System.Int64
        float population_density; //хранит число с плавающей точкой от -3.4*1038 до 3.4*1038 и занимает 4 байта.Представлен системным типом System.Single
        sbyte temperature; //хранит целое число от -128 до 127 и занимает 1 байт.Представлен системным типом System.SByte

        private void Задание_4_Click(object sender, RoutedEventArgs e)
        {
            задание_4 mainWindow = new задание_4();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }

        private void Задание_5_Click(object sender, RoutedEventArgs e)
        {
            задание_5 mainWindow = new задание_5();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }

        private void Задание_6_Click(object sender, RoutedEventArgs e)
        {
            задание_6 mainWindow = new задание_6();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }

        private void Задание_3_Click(object sender, RoutedEventArgs e)
        {
            задание_3 mainWindow = new задание_3();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }
    }
}
    
