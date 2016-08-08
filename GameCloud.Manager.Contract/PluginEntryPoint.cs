using System.Reflection;
using GameCloud.Manager.Contract.Attributes;
using GameCloud.Manager.Contract.Configuration;

namespace GameCloud.Manager.Contract
{
    public class PluginEntryPoint
    {
        private string plugName;

        public PluginEntryPoint()
        {
            this.Configuration = new PluginConfiguration(this.PluginName);
        }

        public string PluginName
        {
            get
            {
                if (plugName == null)
                {
                    plugName = this.GetType().GetCustomAttribute<PluginMetadataAttribute>().Name;
                }

                return plugName;
            }
        }

        public PluginConfiguration Configuration { get; private set; }
    }
}
