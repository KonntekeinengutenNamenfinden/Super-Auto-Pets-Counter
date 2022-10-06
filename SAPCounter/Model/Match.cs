namespace SAPCounter.Model
{
    public class Match
    {
        public enum SapMatchType
        {
            Summoner,
            Hybrid,
            Other
        }
        public SapMatchType CurrentMatchType { get; set; }
    }
}
