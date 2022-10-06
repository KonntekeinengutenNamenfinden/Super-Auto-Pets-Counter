namespace SAPCounter.Model
{
    public class MatchSummoner : Match
    {
        public static int Counter { get; set; } = 0;
        public MatchSummoner(SapMatchType matchType) : base(matchType)
        {
            Counter++;
        }
    }
}
