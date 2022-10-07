using SAPCounter.DataManager;
using System.IO;
using System.Windows;

namespace SAPCounter.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string ResourceFilePath = Path.Combine(Path.GetFullPath(@"..\..\..\"), @"Resources\");
        private readonly ViewModel.ItemsControlViewModel _vmItemsControl;

        public MainWindow()
        {
            InitializeComponent();

            LoadManager _ = new();
            _.LoadStats();

            _vmItemsControl = new ViewModel.ItemsControlViewModel();
            DataContext = _vmItemsControl;
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            SaveManager _ = new();
            _.SaveStats();
            this.Close();
        }

        private void MakeStatistic_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                GraphManager graphManager = new(ResourceFilePath);
                graphManager.Do();
            }
            catch
            {
                MessageBox.Show("Cannot create a statistic-window while another stat-window is still open", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
