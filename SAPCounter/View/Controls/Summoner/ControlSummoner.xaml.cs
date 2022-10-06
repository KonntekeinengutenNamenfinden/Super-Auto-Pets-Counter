using System.Windows.Controls;

namespace SAPCounter.View.Controls.Summoner
{
    /// <summary>
    /// Interaktionslogik für ControlSummoner.xaml
    /// </summary>
    public partial class ControlSummoner : UserControl
    {
        ViewModelSummoner vmSummoner;
        public ControlSummoner()
        {
            InitializeComponent();

            vmSummoner = new ViewModelSummoner();
            DataContext = vmSummoner;
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            vmSummoner.Counter--;
        }

        private void Button_Click_1(object sender, System.Windows.RoutedEventArgs e)
        {
            vmSummoner.Counter++;
        }
    }
}
