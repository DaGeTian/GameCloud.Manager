using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace GameCloud.Manager.App.Models
{
    [DataContract]
    public class PluginCertificate
    {
        [DataMember]
        public string Thumbnail { get; set; }
    }
}
