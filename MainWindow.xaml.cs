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
            Process process = new Process();
            process.StartInfo.FileName = "flashaonly.bat";
            process.StartInfo.Arguments = @"-X";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            process.Start();
            process.WaitForExit();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = "flashab.bat";
            process.StartInfo.Arguments = @"-X";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            process.Start();
            process.WaitForExit();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = "flashtwrp.bat";
            process.StartInfo.Arguments = @"-X";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            process.Start();
            process.WaitForExit();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = "flashtwrpab.bat";
            process.StartInfo.Arguments = @"-X";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            process.Start();
            process.WaitForExit();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = "boottwrp.bat";
            process.StartInfo.Arguments = @"-X";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            process.Start();
            process.WaitForExit();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = "unlockbootloader.bat";
            process.StartInfo.Arguments = @"-X";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            process.Start();
            process.WaitForExit();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = "pmflash.bat";
            process.StartInfo.Arguments = @"-X";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            process.Start();
            process.WaitForExit();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = "installdrv.bat";
            process.StartInfo.Arguments = @"-X";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            process.Start();
            process.WaitForExit();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = "freecmd.bat";
            process.StartInfo.Arguments = @"-X";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            process.Start();
            process.WaitForExit();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = "xdathread.bat";
            process.StartInfo.Arguments = @"-X";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            process.Start();
            process.WaitForExit();
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            var win3 = new About2();
            win3.Show();
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = "uninstall.bat";
            process.StartInfo.Arguments = @"-X";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            process.Start();
            process.WaitForExit();
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = "compatibledevices.bat";
            process.StartInfo.Arguments = @"-X";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            process.Start();
            process.WaitForExit();
        }
    }
}
