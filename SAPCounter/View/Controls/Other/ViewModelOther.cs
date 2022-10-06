using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPCounter.View.Controls.Other
{
    public class ViewModelOther : INotifyPropertyChanged
    {
        public Model.MatchOther matchOther { get; set; }
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

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged(string info)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
        }
    }
}
