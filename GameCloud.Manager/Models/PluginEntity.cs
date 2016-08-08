using GameCloud.Database;
using GameCloud.Database.Attributes;

namespace GameCloud.Manager.Models
{
    [CollectionName("Plugin")]
    public class PluginEntity : EntityBase
    {
        public string Name { get; set; }

        public string Content { get; set; }
    }
}