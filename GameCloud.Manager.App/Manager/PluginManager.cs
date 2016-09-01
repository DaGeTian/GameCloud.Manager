using System;
using System.Collections.Generic;
using GameCloud.Manager.App.Models;

namespace GameCloud.Manager.App.Manager
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
