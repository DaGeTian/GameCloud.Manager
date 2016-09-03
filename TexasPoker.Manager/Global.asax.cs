using System.ComponentModel.Composition.Hosting;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using GameCloud.UCenter.Common.MEF;
using GameCloud.UCenter.Common.Settings;
using GameCloud.UCenter.Database;
using GameCloud.UCenter.Web.Common;

namespace Manager.TexasPoker
{
    /// <summary>
    /// Web MVC Application
    /// </summary>
    public class MvcApplication : System.Web.HttpApplication
    {
        /// <summary>
        /// Function for application start.
        /// </summary>
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ExportProvider exportProvider = CompositionContainerFactory.Create();

            WebApplicationManager.InitializeApplication(GlobalConfiguration.Configuration, exportProvider);
            SettingsInitializer.Initialize<Settings>(
                exportProvider,
                SettingsDefaultValueProvider<Settings>.Default,
                AppConfigurationValueProvider.Default);
            SettingsInitializer.Initialize<TexasPokerDatabaseContextSettings>(
                exportProvider,
                SettingsDefaultValueProvider<TexasPokerDatabaseContextSettings>.Default,
                AppConfigurationValueProvider.Default);
        }
    }
}
