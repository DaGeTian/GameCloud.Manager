using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameCloud.Manager.Web.Models
{
    public class Plugin : PluginBase
    {
        public IReadOnlyList<PluginCategory> Categories { get; set; }
    }
}
