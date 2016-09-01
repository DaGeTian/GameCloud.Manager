namespace GameCloud.Manager.App.Models
{
    public class PluginPage : PluginBase
    {
        public string View { get; set; }

        public PluginPageType Type { get; set; }

        public string Controller { get; set; }
    }
}
