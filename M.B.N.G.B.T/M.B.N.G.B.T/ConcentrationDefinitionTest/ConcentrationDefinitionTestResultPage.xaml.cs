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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace M.B.N.G.B.T.ConcentrationDefinitionTest
{
    /// <summary>
    /// Логика взаимодействия для ConcentrationDefinitionTestResultPage.xaml
    /// </summary>
    public partial class ConcentrationDefinitionTestResultPage : Page
    {
        public ConcentrationDefinitionTestResultPage()
        {
            InitializeComponent();
          

        }

        private string WriteTextBlock(int[][] arr)
        {
            string str = $"\n";
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != null)
                {
                    str += $"{i + 1})";
                    for (int j = 0; j < arr[i].Length; j++)
                    {
                        str += $"{arr[i][j]},";
                    }
                    str += $"\n";
                }
            }
            return str;
        }

        private void Button_Click_Try_Again(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ConcentrationDefinitionTestRulePage());
        }

        private void Button_Click_Exit_Main(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(null);
        }
    }
}
