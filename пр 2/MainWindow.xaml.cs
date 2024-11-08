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

namespace Pract2_2._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Опрограмме_Click(object sender, RoutedEventArgs e) //Кнопка "О программе"
        {
            MessageBox.Show("Разработчик: Воейков Никита. Задание: Ввести n целых чисел. Найти сумму чисел > 5. Результат вывести на экран.");
        }

        private void Выход_Click(object sender, RoutedEventArgs e) //Кнопка "Выход"
        {
            this.Close();
        }

        private void Button2_Click(object sender, RoutedEventArgs e) //Кнопка "Очистить"
        {
            zn1.Clear();
            zn2.Clear();
            zn3.Clear();
            mas = null;
        }
        int[] mas;
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (mas == null)
            {
                MessageBox.Show("Создайте массив");
                return;
            }
            int sum = 0;
            Lib_2.Class2.Function(ref sum, mas);
            zn2.Text = sum.ToString();
        }
        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            bool f2 = int.TryParse(zn1.Text, out int N);
            if (f2 == true)
            {
                if (N > 0)
                {
                    zn3.Clear();
                    Lib_2.Class2.Massiv(out mas, N);
                    for (int j = 0; j < mas.Length; j++)
                    {
                        zn3.Text = zn3.Text + " " + mas[j].ToString();

                    }
                }
                else
                    MessageBox.Show("Введите число больше 0");
            }
            else
                MessageBox.Show("Я люблю числа, а не буквы");
        }

        private void Сохранить_Click(object sender, RoutedEventArgs e)
        {
            if (mas != null) LibMas.Class1.Save(mas);
        }
        private void Открыть_Click(object sender, RoutedEventArgs e)
        {
            zn3.Clear();
            LibMas.Class1.Insert(out mas);
            for (int i = 0; i < mas.Length; i++)
            {
                zn3.Text = zn3.Text + " " + mas[i].ToString();
            }
        }
    }
}
