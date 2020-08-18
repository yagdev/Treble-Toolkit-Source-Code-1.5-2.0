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
    /// Interaction logic for TWRPFlAB2.xaml
    /// </summary>
    public partial class TWRPFlAB2 : Window
    {
        public TWRPFlAB2()
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
            const string strCmdText = "/C cd .. & mkdir Place_Files_Here & cd Place_Files_Here & mkdir TWRP & cd TWRP & ren *.zip twrp.zip & cd .. & cd .. & cd assets & adb.exe sideload ../Place_Files_Here/TWRP/twrp.zip";
            Process.Start("CMD.exe", strCmdText);
            var win2 = new TWRPFlashed();
            win2.Show();
            this.Close();
        }
    }
}
