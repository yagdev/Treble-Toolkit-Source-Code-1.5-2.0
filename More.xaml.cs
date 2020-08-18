using ProjectComplete2;
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

namespace TrebleToolkit
{
    /// <summary>
    /// Interaction logic for More.xaml
    /// </summary>
    public partial class More : Window
    {
        public More()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var win2 = new MainWindow();
            win2.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var win2 = new Android10PM();
            win2.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var win2 = new CompatibleDevices();
            win2.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C start https://adb.clockworkmod.com/";
            process.StartInfo = startInfo;
            process.Start();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            const string strCmdText = "/C cd .. & cd FreeCMD & start FreeCMD.exe";
            Process.Start("CMD.exe", strCmdText);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C start https://forum.xda-developers.com/project-treble/trebleenabled-device-development/treble-gsi-flashing-tool-b-t4040435";
            process.StartInfo = startInfo;
            process.Start();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            var win2 = new About();
            win2.Show();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            const string strCmdText = "/C cd .. & del * /f /q & del assets /f /q & del FreeCMD /f /q";
            Process.Start("CMD.exe", strCmdText);
            this.Close();
        }
    }
}
