using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameCloud.Manager.Web.Models;

namespace GameCloud.Manager.Web.Manager
{
    public class PluginManager
    {
        public IReadOnlyList<Plugin> GetPlugins()
        {
            // todo: load plugins from all manifests.
            throw new NotImplementedException();
        }
    }
}
