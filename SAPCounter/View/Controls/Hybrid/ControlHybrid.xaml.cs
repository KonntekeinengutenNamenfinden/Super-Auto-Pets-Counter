using System.Windows.Controls;

namespace SAPCounter.View.Controls.Hybrid
{
    /// <summary>
    /// Interaktionslogik für ControlHybrid.xaml
    /// </summary>
    public partial class ControlHybrid : UserControl
    {
        private readonly ViewModelMatchHybrid vmMatchHybrid;
        public ControlHybrid()
        {
            InitializeComponent();

            vmMatchHybrid = new ViewModelMatchHybrid();
            DataContext = vmMatchHybrid;
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            vmMatchHybrid.Counter++;
        }

        private void Button_Click_1(object sender, System.Windows.RoutedEventArgs e)
        {
            vmMatchHybrid.Counter--;
        }
    }
}
