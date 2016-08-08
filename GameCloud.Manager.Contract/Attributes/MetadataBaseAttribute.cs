using System;

namespace GameCloud.Manager.Contract.Attributes
{
    public abstract class MetadataBaseAttribute : Attribute
    {
        public string Name { get; set; }

        public string DisplayName { get; set; }

        public string Description { get; set; }
    }
}
