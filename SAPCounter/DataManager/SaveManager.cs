using SAPCounter.Model;
using System.IO;

namespace SAPCounter.DataManager
{
    public class SaveManager
    {
        public void SaveStats()
        {
            File.WriteAllText(@"..\..\..\Resources\Stats.txt", $"{MatchSummoner.Counter};{MatchHybrid.Counter};{MatchOther.Counter}");
        }
    }
}
