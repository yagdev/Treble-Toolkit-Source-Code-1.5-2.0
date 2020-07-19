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
    /// Interaction logic for FlashTWRPAorAB.xaml
    /// </summary>
    public partial class FlashTWRPAorAB : Window
    {
        public FlashTWRPAorAB()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var win2 = new TWRPFlash();
            win2.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var win2 = new TWRPFlAB();
            win2.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var win2 = new FlashBoot();
            win2.Show();
            this.Close();
        }
    }
}
