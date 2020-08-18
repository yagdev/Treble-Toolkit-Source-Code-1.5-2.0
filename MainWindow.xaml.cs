using ProjectLiteCompatible;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TrebleToolkitLite;

namespace ProjectLiteCompatible
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            const string strCmdText = "/C adb.exe reboot-bootloader & cd .. & mkdir Place_Files_Here & cd Place_Files_Here & mkdir boot & cd boot & ren *.img boot.img & cd .. & mkdir system & cd system & ren *.img system.img & cd .. & mkdir vbmeta & cd vbmeta & ren *.img vbmeta.img & cd .. & cd .. & cd assets & fastboot.exe format system & fastboot.exe format userdata & fastboot.exe --disable-verity --disable-verification flash vbmeta ../Place_Files_Here/vbmeta/vbmeta.img & fastboot.exe flash boot ../Place_Files_Here/boot/boot.img & fastboot.exe flash system ../Place_Files_Here/system/system.img & fastboot.exe reboot & cd .. & cd Place_Files_Here & mkdir boot & mkdir system & mkdir vbmeta";
            Process.Start("CMD.exe", strCmdText);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            const string strCmdText = "/C adb.exe reboot-bootloader & cd .. & mkdir Place_Files_Here & cd Place_Files_Here & mkdir boot & cd boot & ren *.img boot.img & cd .. & mkdir system & cd system & ren *.img system.img & cd .. & mkdir vbmeta & cd vbmeta & ren *.img vbmeta.img & cd .. & cd .. & cd assets & fastboot.exe format system_a & fastboot.exe format system_b & fastboot.exe format userdata & fastboot.exe --disable-verity --disable-verification flash vbmeta ../Place_Files_Here/vbmeta/vbmeta.img & fastboot.exe flash boot_a ../Place_Files_Here/boot/boot.img & fastboot.exe flash boot_b ../Place_Files_Here/boot/boot.img & fastboot.exe flash system_a ../Place_Files_Here/system/system.img & fastboot.exe flash system_b ../Place_Files_Here/system/system.img & fastboot.exe reboot & cd .. & cd Place_Files_Here & mkdir boot & mkdir system & mkdir vbmeta";
            Process.Start("CMD.exe", strCmdText);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            const string strCmdText = "/C adb.exe reboot-bootloader & cd .. & mkdir Place_Files_Here & cd Place_Files_Here & mkdir TWRP & cd TWRP & ren *.img twrp.img & cd .. & cd .. & cd assets & fastboot.exe flash recovery ../Place_Files_Here/TWRP/twrp.img & fastboot.exe reboot";
            Process.Start("CMD.exe", strCmdText);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            const string strCmdText = "/C adb.exe reboot-bootloader & cd .. & cd Place_Files_Here & cd TWRP & ren *.img twrp.img & ren *.zip twrp.zip & cd .. & cd .. & cd assets & fastboot.exe boot ../Place_Files_Here/TWRP/twrp.img & cd .. & mkdir Place_Files_Here & cd Place_Files_Here & mkdir TWRP & cd TWRP & ren *.zip twrp.zip & cd .. & cd .. & cd assets & adb.exe sideload ../Place_Files_Here/TWRP/twrp.zip";
            Process.Start("CMD.exe", strCmdText);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            const string strCmdText = "/C adb.exe reboot-bootloader & cd .. & cd Place_Files_Here & cd TWRP & ren *.img twrp.img & cd .. & cd .. & cd assets & fastboot.exe boot ../Place_Files_Here/TWRP/twrp.img & cd .. & cd Place_Files_Here & mkdir TWRP";
            Process.Start("CMD.exe", strCmdText);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            const string strCmdText = "/C adb.exe reboot-bootloader & fastboot.exe oem unlock";
            Process.Start("CMD.exe", strCmdText);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            const string strCmdText = "/C adb.exe sideload 10.zip";
            Process.Start("CMD.exe", strCmdText);
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C start https://adb.clockworkmod.com/";
            process.StartInfo = startInfo;
            process.Start();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            const string strCmdText = "/C cd .. & cd FreeCMD & start FreeCMD.exe";
            Process.Start("CMD.exe", strCmdText);
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C start https://forum.xda-developers.com/project-treble/trebleenabled-device-development/treble-gsi-flashing-tool-b-t4040435";
            process.StartInfo = startInfo;
            process.Start();
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            var win3 = new About2();
            win3.Show();
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            const string strCmdText = "/C cd .. & del * /f /q & del assets /f /q & del FreeCMD /f /q";
            Process.Start("CMD.exe", strCmdText);
            this.Close();
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            const string strCmdText = "/C help.docx";
            Process.Start("CMD.exe", strCmdText);
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C ren gui.exe gui3.exe & ren gui2.exe gui.exe & ren gui3.exe gui2.exe & gui.exe";
            process.StartInfo = startInfo;
            process.Start();
            this.Close();
        }
    }
}
