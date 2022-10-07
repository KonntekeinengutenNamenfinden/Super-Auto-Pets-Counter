using QuickChart;
using SAPCounter.View;
using System.IO;
using System.Security.AccessControl;

namespace SAPCounter.DataManager
{
    public class GraphManager
    {
        private readonly string _imageFilePath;
        public GraphManager(string resourceFilePath)
        {
            _imageFilePath = resourceFilePath + @"graph.png";
        }

        public void Do()
        {
            string config = @"{type: 'pie', " +
                "data: {labels: ['Summoner', 'Hybrid', 'Other'], " +
                "datasets: [{label: 'Statistic', " +
                $"data: [{Model.MatchSummoner.Counter}, {Model.MatchHybrid.Counter}, {Model.MatchOther.Counter}]" +
                "}]}}";

            Chart qc = new()
            {
                Width = 300,
                Height = 200,
                Config = config
            };

            qc.ToFile(_imageFilePath);

            var _ = new Graph(_imageFilePath);
            _.Show();
        }
    }
}
