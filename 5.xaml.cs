using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    /// Interaction logic for Xp5.xaml
    /// </summary>
    public partial class Xp5 : Window
    {
        public Xp5()
        {
            InitializeComponent();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var win2 = new CompatibleDevices();
            win2.Show();
            this.Close();
        }
    }
}
