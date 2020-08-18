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
    /// Interaction logic for FlashAB.xaml
    /// </summary>
    public partial class FlashAB : Window
    {
        public FlashAB()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            const string strCmdText = "/C adb.exe reboot-bootloader & cd .. & mkdir Place_Files_Here & cd Place_Files_Here & mkdir boot & cd boot & ren *.img boot.img & cd .. & mkdir system & cd system & ren *.img system.img & cd .. & mkdir vbmeta & cd vbmeta & ren *.img vbmeta.img & cd .. & cd .. & cd assets & fastboot.exe format system_a & fastboot.exe format system_b & fastboot.exe format userdata & fastboot.exe --disable-verity --disable-verification flash vbmeta ../Place_Files_Here/vbmeta/vbmeta.img & fastboot.exe flash boot_a ../Place_Files_Here/boot/boot.img & fastboot.exe flash boot_b ../Place_Files_Here/boot/boot.img & fastboot.exe flash system_a ../Place_Files_Here/system/system.img & fastboot.exe flash system_b ../Place_Files_Here/system/system.img & fastboot.exe reboot & cd .. & cd Place_Files_Here & mkdir boot & mkdir system & mkdir vbmeta";
            Process.Start("CMD.exe", strCmdText);
            var win2 = new FlashFinished();
            win2.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var win2 = new FlashTreble();
            win2.Show();
            this.Close();
        }
    }
}
