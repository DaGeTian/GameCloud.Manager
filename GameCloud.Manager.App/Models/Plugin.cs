using System.Collections.Generic;

namespace GameCloud.Manager.App.Models
{
    public class Plugin : PluginBase
    {
        public IReadOnlyList<PluginCategory> Categories { get; set; }
    }
}
