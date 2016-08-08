using System.Collections.Generic;
using System.Runtime.Serialization;
using GameCloud.Manager.Contract.Requests;

namespace GameCloud.Manager.Models
{
    [DataContract]
    public class PluginRequest
    {
        [DataMember(Name = "pluginName")]
        public string PluginName { get; set; }

        [DataMember(Name = "category")]
        public string Category { get; set; }

        [DataMember(Name = "item")]
        public string Item { get; set; }

        [DataMember(Name = "method")]
        public PluginRequestMethod Method { get; set; }

        [DataMember(Name = "content")]
        public Dictionary<string, string> Content { get; set; }
    }
}