using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TrebleToolkit
{
    /// <summary>
    /// Interaction logic for XDAThread.xaml
    /// </summary>
    public partial class XDAThread : Window
    {
        public XDAThread()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                myweb.Source = new Uri("https://forum.xda-developers.com/project-treble/trebleenabled-device-development/treble-gsi-flashing-tool-b-t4040435");


            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
