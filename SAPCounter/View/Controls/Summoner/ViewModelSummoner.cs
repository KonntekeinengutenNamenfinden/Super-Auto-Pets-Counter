using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPCounter.View.Controls.Summoner
{
    public class ViewModelSummoner : INotifyPropertyChanged
    {
        public Model.MatchSummoner matchSummoner { get; set; }
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

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged(string info)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
        }
    }
}
