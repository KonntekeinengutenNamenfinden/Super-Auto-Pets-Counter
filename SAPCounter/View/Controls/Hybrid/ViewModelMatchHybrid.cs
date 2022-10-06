using System.ComponentModel;

namespace SAPCounter.View.Controls.Hybrid
{
    public class ViewModelMatchHybrid : INotifyPropertyChanged
    {
        public Model.MatchHybrid matchHybrid { get; set; }
        public int Counter
        {
            get { return Model.MatchHybrid.Counter; }
            set
            {
                if (Counter + value >= 0)
                {
                    Model.MatchHybrid.Counter = value;
                    OnPropertyChanged(nameof(Counter));
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged(string info)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
        }
    }
}
