using GameCloud.Database;
using GameCloud.Database.Attributes;

namespace TexasPoker.Database.Entities
{
    [CollectionName("EventPlayerSendOtherChips")]
    public class PlayerSendOtherChipsEventEntity : EntityBase
    {
        public string SendPlayerEtGuid { get; set; }
        public string TargetPlayerEtGuid { get; set; }
        public int SendChipsNum { get; set; }
        public int AfterSendChipsNum { get; set; }
        public string EventType { get; set; }
        public string EventTm { get; set; }
    }
}
