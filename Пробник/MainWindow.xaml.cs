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

namespace Пробник
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            dt = new reg_ayto_1();
        }
        reg_ayto_1 dt;
        private void KN1_Click(object sender, RoutedEventArgs e)
        {
            if (dt.AVTO(T1.Text, T2.Text))
            {
                Window1 F = new Window1();
                F.Show();
                this.Hide();
            }
            else MessageBox.Show("Ошибка");
        }
    }
}
