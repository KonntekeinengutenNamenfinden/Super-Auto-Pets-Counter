using System.Windows;

namespace SAPCounter.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ViewModel.ItemsControlViewModel _vmItemsControl;
        public MainWindow()
        {
            InitializeComponent();
            _vmItemsControl = new ViewModel.ItemsControlViewModel();
            DataContext = _vmItemsControl;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
