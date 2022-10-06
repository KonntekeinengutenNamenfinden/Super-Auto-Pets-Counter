namespace SAPCounter.Model
{
    public class MatchHybrid : Match
    {
        public static int Counter { get; set; } = 0;
        public MatchHybrid(SapMatchType matchType) : base(matchType)
        {
            Counter++;
        }
    }
}
