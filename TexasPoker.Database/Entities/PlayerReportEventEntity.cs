using GameCloud.Database;
using GameCloud.Database.Attributes;

namespace TexasPoker.Database.Entities
{
    [CollectionName("PlayerReportEvent")]
    public class PlayerReportEventEntity : EntityBase
    {
        public string ReportPlayer { get; set; }
        public string BeingReportedPlayer { get; set; }
        public string ReportType { get; set; }
        public string EventType { get; set; }
        public string EventTm { get; set; }
    }
}
