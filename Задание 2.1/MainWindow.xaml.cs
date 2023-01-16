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

namespace Задание_2._1
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
        double temperature; //хранит число с плавающей точкой от ±5.0*10-324 до ±1.7*10308 и занимает 8 байта.Представлен системным типом System.Double
       string userName; //хранит набор символов Unicode. Представлен системным типом System.String. 
        bool check; //хранит значение true или false (логические литералы). Представлен системным типом System.Boolean
        char entrance ; //хранит одиночный символ в кодировке Unicode и занимает 2 байта. Представлен системным типом System.Char.
        byte ; //хранит целое число от 0 до 255 и занимает 1 байт.Представлен системным типом System.Byte
        short ; // хранит целое число от -32768 до 32767 и занимает 2 байта.Представлен системным типом System.Int16
        long ;  //хранит целое число от –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807 и занимает 8 байт.Представлен системным типом System.Int64
        float ;  //хранит число с плавающей точкой от -3.4*1038 до 3.4*1038 и занимает 4 байта.Представлен системным типом System.Single
        sbyte;  //хранит целое число от -128 до 127 и занимает 1 байт.Представлен системным типом System.SByte

        
            
        //задание 4
        int Crystal = 0;
        private void Buy_Click(object sender, RoutedEventArgs e) //3 задание 
        {
            double Gold = Convert.ToDouble(gold.Text);
            if (Gold > 56)
            {
                Gold -= 65;
                Crystal += 4;
                crystalQuantity.Content = $"Кол-во кристалов: {Crystal}";
                goldQuantity.Foreground = Brushes.Black;
                gold.Text = $"{Gold}";
            }
            else
            {
                goldQuantity.Foreground = Brushes.Red;
                goldQuantity.Content = "Недостаточно денег для покупки!";
            }

        }
    }
}
