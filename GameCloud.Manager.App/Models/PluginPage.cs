using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace GameCloud.Manager.App.Models
{
    [DataContract]
    public class PluginPage : PluginBase
    {
        [DataMember(Name = "route")]
        public string Route { get; set; }

        [DataMember(Name = "view")]
        public string View { get; set; }

        [DataMember(Name = "type")]
        public PluginPageType Type { get; set; }

        [DataMember(Name = "controller")]
        public string Controller { get; set; }
    }
}
