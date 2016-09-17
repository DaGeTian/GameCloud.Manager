using GameCloud.Database;
using GameCloud.Database.Attributes;

namespace TexasPoker.Database.Entities
{
    [CollectionName("EventChipsChangeByManager")]
    public class ChipsChangeByManagerEventEntity : EntityBase
    {
        public string PlayerEtGuid { get; set; }
        public int ChangeChips { get; set; }
        public int AfterChangeChipsNum { get; set; }
        public string EventType { get; set; }
        public string EventTm { get; set; }
    }
}
