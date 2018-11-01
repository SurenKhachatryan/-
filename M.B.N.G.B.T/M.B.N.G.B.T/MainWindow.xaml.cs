using System.Windows;
using System.Windows.Input;
using M.B.N.G.B.T.VisualMemoryTest;
using M.B.N.G.B.T.AttentivenessTest;
using M.B.N.G.B.T.TestEclecticAttention;
using M.B.N.G.B.T.ConcentrationDefinitionTest;
using M.B.N.G.B.T.WalterSchulteTest;
using M.B.N.G.B.T.EmilKraepelinTest;
using M.B.N.G.B.T.RavenTest_IQ;
using System.Diagnostics;
using System.Threading;

namespace M.B.N.G.B.T
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
                Thread.Sleep(500);

            if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
            {
                MessageBox.Show("Ծրագիրը արդեն բաց է։", "Մ․Բ․Ն․Գ․Բ․Թ․");
                Close();
            }

            InitializeComponent();
        }

        private void Button_Visual_Memory_Test(object sender, RoutedEventArgs e)
        {
            new VisualMemoryTestRuleWindow().Show();
            Close();
        }

        private void Button_Schulte_Test(object sender, RoutedEventArgs e)
        {
            new WalterSchulteTestRuleWindow().Show();
            Close();
        }

        private void Button_VLMarshuk_Test(object sender, RoutedEventArgs e)
        {
            new ConcentrationDefinitionTestRuleWindow().Show();
            Close();
        }

        private void Button_Krepelin_Test(object sender, RoutedEventArgs e)
        {
            new EmilKraepelinTestRuleWindow().Show();
            Close();
        }

        private void Button_Attentiveness_Test(object sender, RoutedEventArgs e)
        {
            new AttentivenessTestRuleWindow().Show();
            Close();
        }

        private void Button_Test_Eclectic_Attention(object sender, RoutedEventArgs e)
        {
            new TestEclecticAttentionRuleWindow().Show();
            Close();
        }

        private void Button_Test_Raven_IQ(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("  Ուրեմն, երեխեք ջան, պատմեմ լսեք: Շինարարությունը սկսել եինք, բայց բանը բանից անցավ , Սաշիկր Եկավ 50/50 փաթեթի պայմանները ներկայացրեց ու ստիպված շինարարներիս կրճատեցի, բայց էդ էլ չփրկեց: Անցավ 1 ամիս ֆինանսը պրծավ  ու արդեն շինարարներս ազատվեցին գործից, ու ըտենց շինարարութունը կանգնեց , մեկ էլ մի օր հանկարծ  Աստված մի դուռ բացեց: Հեղափոխություն, նոր Վարչապետ, ու էդպես կապ հաստատեցի Վարչապետի հետ, հանդիպեցինք, խոսեցինք, ներկայացրեցի իրավիճակը ու մեր շատ սիրելի Նիկոլ հոպարը հովանավորներ գտավ, ովքեր կֆինանսավորեն մեր պրոեկտը , էնպես որ շուտով աշխատանքները կշարունակվեն և ավարտին կհասցվեն:))))", "Ավելի բարեկարգ երևան");
            new RavenTestIQRuleWindow().Show();
            Close();
        }

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Tab)
                e.Handled = true;
        }

        private void Button_Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
