using System.ComponentModel;

namespace SAPCounter.View.Controls.Hybrid
{
    public class ViewModelMatchHybrid : ViewModelBase, INotifyPropertyChanged
    {
        public Model.MatchHybrid? MatchHybrid { get; set; }
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
    }
}
