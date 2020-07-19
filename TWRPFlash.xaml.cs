using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Interaction logic for TWRPFlash.xaml
    /// </summary>
    public partial class TWRPFlash : Window
    {
        public TWRPFlash()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = "flashtwrp.bat";
            process.StartInfo.Arguments = @"-X";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            process.Start();
            process.WaitForExit();
            var win2 = new TWRPFlashed();
            win2.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var win2 = new FlashTWRPAorAB();
            win2.Show();
            this.Close();
        }
    }
}
