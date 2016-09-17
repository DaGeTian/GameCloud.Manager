using GameCloud.Database;
using GameCloud.Database.Attributes;

namespace TexasPoker.Database.Entities
{
    [CollectionName("EventCoinBuyItem")]
    public class CoinBuyItemEventEntity : EntityBase
    {
        public string BuyPlayerEtGuid { get; set; }
        public int GiftTbId { get; set; }
        public int CostCoins { get; set; }
        public int AfterBuyCoinsNum { get; set; }
        public string EventType { get; set; }
        public string EventTm { get; set; }
    }
}
