using System.Diagnostics.Metrics;

namespace SAPCounter.Model
{
    public abstract class Match
    {
        public enum SapMatchType
        {
            Summoner,
            Hybrid,
            Other
        }
        public SapMatchType CurrentMatchType { get; set; }

        public Match(SapMatchType matchType)
        {
            CurrentMatchType = matchType;
        }
    }
}
