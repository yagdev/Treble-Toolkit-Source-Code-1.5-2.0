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
    /// Interaction logic for Android10PM.xaml
    /// </summary>
    public partial class Android10PM : Window
    {
        public Android10PM()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            const string strCmdText = "/C adb.exe sideload 10.zip";
            Process.Start("CMD.exe", strCmdText);
            var win2 = new FlashPM2();
            win2.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var win2 = new More();
            win2.Show();
            this.Close();
        }
    }
}
