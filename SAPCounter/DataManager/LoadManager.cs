using SAPCounter.Model;
using System.IO;

namespace SAPCounter.DataManager
{
    public class LoadManager
    {
        public void LoadStats()
        {
            if (File.Exists(@"..\..\..\Resources\Stats.txt"))
            {
                string loadedText = File.ReadAllText(@"..\..\..\Resources\Stats.txt");

                var allInts = loadedText.Split(';');

                for (int i = 0; i < int.Parse(allInts[0]); i++)
                {
                    MatchSummoner _ = new(Match.SapMatchType.Summoner);
                }
                for (int i = 0; i < int.Parse(allInts[1]); i++)
                {
                    MatchHybrid _ = new(Match.SapMatchType.Hybrid);
                }
                for (int i = 0; i < int.Parse(allInts[2]); i++)
                {
                    MatchOther _ = new(Match.SapMatchType.Other);
                }
            }

        }
    }
}
