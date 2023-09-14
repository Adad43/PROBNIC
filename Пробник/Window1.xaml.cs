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
using System.Windows.Shapes;

namespace Пробник
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            dt = new reg_ayto_1();
        }
        reg_ayto_1 dt;
        private void KN1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow F = new MainWindow();
            F.Show();
            this.Hide();
        }

        private void KN2_Click(object sender, RoutedEventArgs e)
        {
            dt.AddUser(T1.Text, T2.Text);
            MessageBox.Show("Вроде как все добавилось");
        }
    }
}
