namespace SAPCounter.Model
{
    public class MatchOther : Match
    {
        public static int Counter { get; set; } = 0;
        public MatchOther(SapMatchType matchType) : base(matchType)
        {
            Counter++;
        }
    }
}
