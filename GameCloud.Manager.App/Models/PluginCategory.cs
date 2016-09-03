using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace GameCloud.Manager.App.Models
{
    [DataContract]
    public class PluginCategory : PluginBase
    {
        [DataMember(Name = "items")]
        public List<PluginItem> Items { get; set; }
    }
}
