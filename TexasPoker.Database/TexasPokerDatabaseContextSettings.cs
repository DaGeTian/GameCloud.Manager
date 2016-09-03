using System.ComponentModel.Composition;
using GameCloud.Database;
using GameCloud.UCenter.Common.Settings;

namespace GameCloud.UCenter.Database
{
    [Export]
    public class TexasPokerDatabaseContextSettings : DatabaseContextSettings
    {
        [Setting(settingName: "TexasPokerConnectionString")]
        public override string ConnectionString { get; set; }

        [Setting(settingName: "TexasPokerDatabaseName")]
        public override string DatabaseName { get; set; }
    }
}
