using SAPCounter.View.Controls.Hybrid;
using SAPCounter.View.Controls.Other;
using SAPCounter.View.Controls.Summoner;
using System.Collections.Generic;
using System.Windows.Controls;

namespace SAPCounter.ViewModel
{
    public class ItemsControlViewModel
    {
        public List<UserControl> AllUserControls { get; set; }

        public ItemsControlViewModel()
        {
            AllUserControls = new List<UserControl>
            {
                new ControlSummoner(),
                new ControlHybrid(),
                new ControlOther()
            };
        }
    }
}
