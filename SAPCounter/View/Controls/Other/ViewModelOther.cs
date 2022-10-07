using System.ComponentModel;

namespace SAPCounter.View.Controls.Other
{
    public class ViewModelOther : ViewModelBase, INotifyPropertyChanged
    {
        public Model.MatchOther? MatchOther { get; set; }
        public int Counter
        {
            get { return Model.MatchOther.Counter; }
            set
            {
                if (Counter + value >= 0)
                {
                    Model.MatchOther.Counter = value;
                    OnPropertyChanged(nameof(Counter));
                }

            }
        }
    }
}
