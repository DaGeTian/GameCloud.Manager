using System.ComponentModel.Composition.Hosting;
using GameCloud.Database;
using GameCloud.UCenter.Common.MEF;
using GameCloud.UCenter.Common.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameCloud.Manager.Tests
{
    [TestClass]
    public class ManagerTest
    {
        private static ExportProvider ExportProvider;

        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext context)
        {
            ExportProvider = CompositionContainerFactory.Create();

            SettingsInitializer.Initialize<Settings>(
                ExportProvider,
                SettingsDefaultValueProvider<Settings>.Default,
                AppConfigurationValueProvider.Default);

            SettingsInitializer.Initialize<UCenter.Common.Settings.Settings>(
                ExportProvider,
                SettingsDefaultValueProvider<UCenter.Common.Settings.Settings>.Default,
                AppConfigurationValueProvider.Default);

            SettingsInitializer.Initialize<DatabaseContextSettings>(
                ExportProvider,
                SettingsDefaultValueProvider<DatabaseContextSettings>.Default,
                AppConfigurationValueProvider.Default);
        }
    }
}
