using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProjectComplete2
{
    /// <summary>
    /// Interaction logic for FlashBoot.xaml
    /// </summary>
    public partial class FlashBoot : Window
    {
        public FlashBoot()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var win2 = new FlashTWRPAorAB();
            win2.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var win2 = new BootTWRP();
            win2.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var win2 = new MainWindow();
            win2.Show();
            this.Close();
        }
    }
}
