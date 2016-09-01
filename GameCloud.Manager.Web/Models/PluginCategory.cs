using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameCloud.Manager.Web.Models
{
    public class PluginCategory : PluginBase
    {
        public IReadOnlyList<PluginPage> Pages { get; set; }
    }
}
