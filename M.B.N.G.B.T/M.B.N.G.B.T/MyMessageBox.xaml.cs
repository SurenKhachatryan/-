using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace M.B.N.G.B.T
{
    /// <summary>
    /// Логика взаимодействия для MyMessageBox.xaml
    /// </summary>
    public partial class MyMessageBox : Window
    {
        public MyMessageBox()
        {
            InitializeComponent();
            textBox_1.Focus();
        }

        private void Activation_Button_Click(object sender, RoutedEventArgs e)
        {
            Tester.CreateFile();
            Application.Current.Shutdown();
            Process.Start(Application.ResourceAssembly.Location);
        }

        private void Exit_Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void tableBox_1_KeyUp(object sender, KeyEventArgs e)
        {
            if (Tester.IsKey(textBox_1.Text + textBox_2.Text + textBox_3.Text + textBox_4.Text))
                activation_Button.IsEnabled = true;
            else
                activation_Button.IsEnabled = false;
        }
    }
}
