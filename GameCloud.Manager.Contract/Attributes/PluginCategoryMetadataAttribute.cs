using System;

namespace GameCloud.Manager.Contract.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
    public class PluginCategoryMetadataAttribute : MetadataBaseAttribute
    {
    }
}
