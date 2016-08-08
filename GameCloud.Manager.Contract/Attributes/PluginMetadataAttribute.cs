using System;

namespace GameCloud.Manager.Contract.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class PluginMetadataAttribute : MetadataBaseAttribute
    {
    }
}
