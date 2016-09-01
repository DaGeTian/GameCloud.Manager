using System.Collections.Generic;

namespace GameCloud.Manager.App.Models
{
    public class PluginCategory : PluginBase
    {
        public IReadOnlyList<PluginPage> Pages { get; set; }
    }
}
