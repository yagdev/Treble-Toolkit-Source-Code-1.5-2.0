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

namespace TrebleToolkit
{
    /// <summary>
    /// Interaction logic for CompatibleDevices.xaml
    /// </summary>
    public partial class CompatibleDevices : Window
    {
        public CompatibleDevices()
        {
            InitializeComponent();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var win2 = new More();
            win2.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var win2 = new OnePlus6();
            win2.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var win2 = new XZ2();
            win2.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var win2 = new Xp5();
            win2.Show();
            this.Close();
        }
    }
}
