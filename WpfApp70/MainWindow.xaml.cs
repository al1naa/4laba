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

namespace WpfApp70
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
                double P = Convert.ToInt16(TbNumberp.Text);

                const double NachV = 1000;
                const double KonechV = 1100;

                int months = 0;
                double NNachV = NachV;

                while (NNachV < KonechV)
                {
                    NNachV += NNachV * P / 100;
                    months++;

                }

                TextBlockAnswer.Text = $"Через {months} месяцев размер вклада превысит 1100 руб. \n Итоговый размер вклада: {NNachV:N2} руб.";
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
