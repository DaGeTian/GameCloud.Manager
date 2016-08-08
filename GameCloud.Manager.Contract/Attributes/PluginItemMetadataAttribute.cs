namespace GameCloud.Manager.Contract.Attributes
{
    public class PluginItemMetadataAttribute : MetadataBaseAttribute
    {
        public string Category { get; set; }

        public string View { get; set; }

        public PluginItemType Type { get; set; }

        public string Controller { get; set; }
    }
}
