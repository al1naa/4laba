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
using static System.Math;

namespace WpfApp67
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
                int number = Convert.ToInt16(TbNumbern.Text);

                switch (number)
                {
                    case 1:
                        double radius = Convert.ToInt16(TbNumberx.Text);
                        TextBlockAnswer.Text = ($"\nДиаметр: {2 * radius} \n Длина: {2 * PI * radius} \n Площадь круга: {PI * radius * radius}");
                        break;
                    case 2:
                        double diameter = Convert.ToInt16(TbNumberx.Text);
                        TextBlockAnswer.Text = ($"\nРадиус: {diameter / 2} \n Длина: {PI * diameter} \n Площадь круга: {PI * (diameter / 2) * (diameter / 2)}");
                        break;
                    case 3:
                        double length = Convert.ToInt16(TbNumberx.Text);
                        TextBlockAnswer.Text = ($"\nРадиус: {length / (2 * PI)} \n Диаметр: {length / PI} \n Площадь круга: {PI * (length / (2 * PI)) * (length / (2 * PI))}");
                        break;
                    case 4:
                        double area = Convert.ToInt16(TbNumberx.Text);
                        TextBlockAnswer.Text =($"\nРадиус: {Sqrt(area / PI)} \n Диаметр: {Sqrt(4 * area / PI)} \n Длина: {2 * PI * Sqrt(area / PI)}");
                        break;
                    default:
                        TextBlockAnswer.Text =("Неверный номер элемента!");
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
