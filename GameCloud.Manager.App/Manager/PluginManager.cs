using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using GameCloud.Manager.App.Models;
using Newtonsoft.Json;

namespace GameCloud.Manager.App.Manager
{
    public class PluginManager
    {
        public IReadOnlyList<Plugin> GetPlugins(string path)
        {
            var files = Directory.GetFiles(path, "manifest.json", SearchOption.AllDirectories);
            var plugins = new List<Plugin>();
            var serializer = new XmlSerializer(typeof(Plugin));
            foreach (var file in files)
            {
                using (FileStream stream = File.OpenRead(file))
                {
                    var plugin = JsonConvert.DeserializeObject<Plugin>(File.ReadAllText(file));// serializer.Deserialize(stream) as Plugin;
                    plugins.Add(plugin);
                }
            }

            return plugins;
        }
    }
}
