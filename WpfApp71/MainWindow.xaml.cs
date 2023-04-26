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

namespace WpfApp71
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
            int n = Convert.ToInt16(TbNumbern.Text);
            bool seven = false;

            while (n > 0)
            {
                n = n % 10;
                n = n / 10;
                if (n == 7)
                {
                    seven = true;
                    break;
                }
                
            }

            switch (seven)
            {
                case true:
                    TextBlockAnswer.Text = "Ответ: true";
                    break;
                case false:
                    TextBlockAnswer.Text = "Ответ: false";
                    break;
            }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
