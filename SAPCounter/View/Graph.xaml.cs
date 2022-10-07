using System.Windows;

namespace SAPCounter.View
{
    /// <summary>
    /// Interaktionslogik für Graph.xaml
    /// </summary>
    public partial class Graph : Window
    {
        private readonly ViewModel.ViewModelGraph _vmGraph;
        public Graph(string imagePath)
        {
            InitializeComponent();

            _vmGraph = new ViewModel.ViewModelGraph(imagePath);
            DataContext = _vmGraph;
        }
    }
}
