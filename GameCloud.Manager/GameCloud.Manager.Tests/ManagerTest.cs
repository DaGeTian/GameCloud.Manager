using System.ComponentModel.Composition.Hosting;
using GameCloud.Database;
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
        }
    }
}
