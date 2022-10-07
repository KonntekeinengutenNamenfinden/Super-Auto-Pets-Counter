using System.ComponentModel;

namespace SAPCounter.View.Controls.Summoner
{
    public class ViewModelSummoner : ViewModelBase, INotifyPropertyChanged
    {
        public Model.MatchSummoner? MatchSummoner { get; set; }
        public int Counter
        {
            get { return Model.MatchSummoner.Counter; }
            set
            {
                if (Counter + value >= 0)
                {
                    Model.MatchSummoner.Counter = value;
                    OnPropertyChanged(nameof(Counter));
                }

            }
        }
    }
}
