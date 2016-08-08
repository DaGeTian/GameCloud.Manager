using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GameCloud.Manager.Models
{
    [DataContract]
    public class PluginCategory : PluginBase
    {
        [DataMember(Name = "items")]
        public List<PluginItem> Items { get; set; }
    }
}