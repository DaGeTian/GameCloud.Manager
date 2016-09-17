using GameCloud.Database;
using GameCloud.Database.Attributes;

namespace TexasPoker.Database.Entities
{
    [CollectionName("EventChipBuyItem")]
    public class ChipBuyItemEventEntity : EntityBase
    {
        public string BuyPlayerEtGuid { get; set; }
        public int GiftTbId { get; set; }
        public int CostChips { get; set; }
        public int AfterBuyChipsNum { get; set; }
        public string EventType { get; set; }
        public string EventTm { get; set; }
    }
}
