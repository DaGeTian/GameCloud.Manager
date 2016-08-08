using GameCloud.Database;
using GameCloud.Database.Attributes;

namespace TexasPoker.Database.Entities
{
    [CollectionName("LostAllSendChipsEvent")]
    public class LostAllSendChipsEventEntity : EntityBase
    {
        public string GetPlayerEtGuid { get; set; }
        public int GetChipsNum { get; set; }
        public int AfterGetChipsNum { get; set; }
        public string EventType { get; set; }
        public string EventTm { get; set; }
    }
}
