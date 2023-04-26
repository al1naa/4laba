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

namespace WpfApp68
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

        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int N = Convert.ToInt16(TbNumbern.Text);
                int k = 1;
                while (k * k <= N)
                {
                    k++;
                }

                k--;

                switch (k)
                {
                    case 0:
                        TextBlockAnswer.Text = ("Квадрат любого целого числа не превосходит N");
                        break;
                    case 1:
                        TextBlockAnswer.Text = ("Квадрат наибольшего целого числа, не превосходящего N, равен 1");
                        break;
                    default:
                        TextBlockAnswer.Text = ("Квадрат наибольшего целого числа, не превосходящего N, равен " + k * k);
                        break;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены не корректные данные");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
