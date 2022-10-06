using SAPCounter.Model;
using System.Collections.Generic;

namespace SAPCounter.ViewModel
{
    public class ViewModelMatch
    {
        public List<Match> AllMatches { get; set; } = new();

        public ViewModelMatch(Match.SapMatchType type)
        {
            AllMatches.Add(new Match
            {
                CurrentMatchType = type
            });
        }
    }
}
