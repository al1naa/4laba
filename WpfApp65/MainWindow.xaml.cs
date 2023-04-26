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

namespace WpfApp65
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
                int DD = Convert.ToInt16(TbNumberDD.Text);
                int MM = Convert.ToInt16(TbNumberMM.Text);

                switch (MM)
                {
                    case 1:
                        if (DD == 1)
                        {
                            DD = 31;
                            MM = 12;
                        }
                        else
                        {
                            DD--;
                        }
                        break;
                    case 2:
                        if (DD == 1)
                        {
                            DD = 31;
                            MM--;
                        }
                        else
                        {
                            DD--;
                        }
                        break;
                    case 3:
                        if (DD == 1)
                        {
                            DD = 28;
                            MM--;
                        }
                        else
                        {
                            DD--;
                        }
                        break;
                    case 4:
                        if (DD == 1)
                        {
                            DD = 31;
                            MM--;
                        }
                        else
                        {
                            DD--;
                        }
                        break;
                    case 5:
                        if (DD == 1)
                        {
                            DD = 30;
                            MM--;
                        }
                        else
                        {
                            DD--;
                        }
                        break;
                    case 6:
                        if (DD == 1)
                        {
                            DD = 31;
                            MM--;
                        }
                        else
                        {
                            DD--;
                        }
                        break;
                    case 7:
                        if (DD == 1)
                        {
                            DD = 30;
                            MM--;
                        }
                        else
                        {
                            DD--;
                        }
                        break;
                    case 8:
                        if (DD == 1)
                        {
                            DD = 31;
                            MM--;
                        }
                        else
                        {
                            DD--;
                        }
                        break;
                    case 9:
                        if (DD == 1)
                        {
                            DD = 31;
                            MM--;
                        }
                        else
                        {
                            DD--;
                        }
                        break;
                    case 10:
                        if (DD == 1)
                        {
                            DD = 30;
                            MM--;
                        }
                        else
                        {
                            DD--;
                        }
                        break;
                    case 11:
                        if (DD == 1)
                        {
                            DD = 31;
                            MM--;
                        }
                        else
                        {
                            DD--;
                        }
                        break;
                    case 12:
                        if (DD == 1)
                        {
                            DD = 30;
                            MM--;
                        }
                        else
                        {
                            DD--;
                        }
                        break;
                }


                TextBlockAnswer.Text = $"Ответ: \n {DD}.{MM}";
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
