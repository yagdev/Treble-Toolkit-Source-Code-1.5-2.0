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
    /// Interaction logic for TWRPFlAB.xaml
    /// </summary>
    public partial class TWRPFlAB : Window
    {
        public TWRPFlAB()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            const string strCmdText = "/C adb.exe reboot-bootloader & cd .. & cd Place_Files_Here & cd TWRP & ren *.img twrp.img & ren *.zip twrp.zip & cd .. & cd .. & cd assets & fastboot.exe boot ../Place_Files_Here/TWRP/twrp.img";
            Process.Start("CMD.exe", strCmdText);
            var win2 = new TWRPFlAB2();
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
