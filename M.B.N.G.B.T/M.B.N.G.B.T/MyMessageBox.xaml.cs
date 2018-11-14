using ClassLibrary;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace M.B.N.G.B.T
{
    /// <summary>
    /// Логика взаимодействия для MyMessageBox.xaml
    /// </summary>
    public partial class MyMessageBox : Window
    {
        private DispatcherTimer dispatcherTimer = new DispatcherTimer();

        public MyMessageBox()
        {
            InitializeComponent();
            textBox_1.Focus();
            dispatcherTimer.Tick += new EventHandler(LabelTimer);
            dispatcherTimer.Start();
        }
        private void LabelTimer(object sender, EventArgs e)
        {
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
                
            if (Tester.IsKey(textBox_1.Text + textBox_2.Text + textBox_3.Text + textBox_4.Text))
                activation_Button.IsEnabled = true;
            else
                activation_Button.IsEnabled = false;
        }

        private void Activation_Button_Click(object sender, RoutedEventArgs e)
        {
            Tester.CreateFile();
            dispatcherTimer.Stop();
            Application.Current.Shutdown();
            Process.Start(Application.ResourceAssembly.Location);
        }

        private void Exit_Button_Click(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Stop();
            Close();
        }

        private void tableBox_1_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox_1.IsFocused && textBox_1.Text.Length == 5)
                textBox_2.Focus();
            else
            if (textBox_2.IsFocused && textBox_2.Text.Length == 5)
                textBox_3.Focus();
            else
            if (textBox_3.IsFocused && textBox_3.Text.Length == 5)
                textBox_4.Focus();
            else
            if (textBox_4.IsFocused && e.Key == Key.Back && textBox_4.Text.Length == 0)
                textBox_3.Focus();
            else
            if (textBox_3.IsFocused && e.Key == Key.Back && textBox_3.Text.Length == 0)
                textBox_2.Focus();
            else
            if (textBox_2.IsFocused && e.Key == Key.Back && textBox_2.Text.Length == 0)
                textBox_1.Focus();
        }
    }
}
