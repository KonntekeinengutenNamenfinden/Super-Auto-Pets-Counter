using System.Windows.Controls;

namespace SAPCounter.View.Controls.Other
{
    /// <summary>
    /// Interaktionslogik für ControlOther.xaml
    /// </summary>
    public partial class ControlOther : UserControl
    {
        private readonly ViewModelOther vmOther;
        public ControlOther()
        {
            InitializeComponent();

            vmOther = new ViewModelOther();
            DataContext = vmOther;
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            vmOther.Counter++;
        }

        private void Button_Click_1(object sender, System.Windows.RoutedEventArgs e)
        {
            vmOther.Counter--;
        }
    }
}
