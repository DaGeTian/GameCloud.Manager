using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameCloud.Manager.Web.Models
{
    public class PluginPage : PluginBase
    {
        public string View { get; set; }

        public PluginPageType Type { get; set; }

        public string Controller { get; set; }
    }
}
