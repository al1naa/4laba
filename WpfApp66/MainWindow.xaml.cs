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

namespace WpfApp66
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
                int x = Convert.ToInt16(TbNumberx.Text);
                string number ;

                switch (x)
                {
                    case 20:
                        number = "двадцать лет";
                        break;
                    case 21:
                        number = "двадцать один год";
                        break;
                    case 22:
                        number = "двадцать два года";
                        break;
                    case 23:
                        number = "двадцать три года";
                        break;
                    case 24:
                        number = "двадцать четыре года";
                        break;
                    case 25:
                        number = "двадцать пять лет";
                        break;
                    case 26:
                        number = "двадцать шесть лет";
                        break;
                    case 27:
                        number = "двадцать семь лет";
                        break;
                    case 28:
                        number = "двадцать восемь лет";
                        break;
                    case 29:
                        number = "двадцать девять лет";
                        break;
                    case 30:
                        number = "тридцать лет";
                        break;
                    case 31:
                        number = "тридцать один год";
                        break;
                    case 32:
                        number = "тридцать два года";
                        break;
                    case 33:
                        number = "тридцать три года";
                        break;
                    case 34:
                        number = "тридцать четыре года";
                        break;
                    case 35:
                        number = "тридцать пять лет";
                        break;
                    case 36:
                        number = "двадцать шесть лет";
                        break;
                    case 37:
                        number = "двадцать семь лет";
                        break;
                    case 38:
                        number = "двадцать восемь лет";
                        break;
                    case 39:
                        number = "двадцать девять лет";
                        break;
                    case 40:
                        number = "сорок лет";
                        break;
                    case 41:
                        number = "сорок один год";
                        break;
                    case 42:
                        number = "сорок два года";
                        break;
                    case 43:
                        number = "сорок три года";
                        break;
                    case 44:
                        number = "сорок четыре года";
                        break;
                    case 45:
                        number = "сорок пять лет";
                        break;
                    case 46:
                        number = "сорок шесть лет";
                        break;
                    case 47:
                        number = "сорок семь лет";
                        break;
                    case 48:
                        number = "сорок восемь лет";
                        break;
                    case 49:
                        number = "сорок девять лет";
                        break;
                    case 50:
                        number = "пятьдесят лет";
                        break;
                    case 51:
                        number = "пятьдесят один год";
                        break;
                    case 52:
                        number = "пятьдесят два года";
                        break;
                    case 53:
                        number = "пятьдесят три года";
                        break;
                    case 54:
                        number = "пятьдесят четыре года";
                        break;
                    case 55:
                        number = "пятьдесят пять лет";
                        break;
                    case 56:
                        number = "пятьдесят шесть лет";
                        break;
                    case 57:
                        number = "пятьдесят семь лет";
                        break;
                    case 58:
                        number = "пятьдесят восемь лет";
                        break;
                    case 59:
                        number = "пятьдесят девять лет";
                        break;
                    case 60:
                        number = "шестьдесят лет";
                        break;
                    case 61:
                        number = "шестьдесят один год";
                        break;
                    case 62:
                        number = "шестьдесят два года";
                        break;
                    case 63:
                         number = "шестьдесят три года";
                        break;
                    case 64:
                        number = "шестьдесят четыре года";
                        break;
                    case 65:
                        number = "шестьдесят пять лет";
                        break;
                    case 66:
                        number = "шестьдесят шесть лет";
                        break;
                    case 67:
                        number = "шестьдесят семь лет";
                        break;
                    case 68:
                        number = "шестьдесят восемь лет";
                        break;
                    case 69:
                        number = "шестьдесят девять лет";
                        break;
                    default:
                        number = "Неизвестный возраст";
                        break;
                }

                TextBlockAnswer.Text = $"Ответ: \n Ваш возраст = {number}";
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
