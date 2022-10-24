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
using Lib_8_;

namespace Практ_1_
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

        private void Rasch_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(Znach1.Text, out int x);
            int.TryParse(Znach2.Text, out int y);
            if (x > 0 && y > 0)
            {
                Vivod2.Text = $"{Maxnums.MaxNum(out string d, y, x)}";
                Vivod1.Text = d;
            }
            else
            {
                MessageBox.Show("Введите корректное значение");
            }
        }


        private void ExitProg_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void AboutProg_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Борькин Иван ИСП-31 \nЗадание:Найти максимум из n целых случайных чисел X, распределенных в диапазоне от 0 до n.Вывести на экран на одной строке сгенерированные числа, на другой строкерезультат.");
        }

        private void ClearProg_Click(object sender, RoutedEventArgs e)
        {
            Znach1.Clear();
            Znach2.Clear();
            Vivod2.Clear();
            Vivod1.Clear();
        }
    }
}
