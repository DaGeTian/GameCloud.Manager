using System;
using System.Globalization;
using System.IO;
using GameCloud.Manager.App.Manager;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;

namespace GameCloud.Manager.App.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHostingEnvironment hostingEnvironment;

        public HomeController(IHostingEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Plugin()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            try
            {
                string path = this.hostingEnvironment.WebRootPath ;
                var manager = new PluginManager();
                var plugins= manager.GetPlugins(Path.Combine(path, "plugins"));
                var actionName = context.ActionDescriptor.DisplayName.ToLower();
                if (actionName.Contains("plugin") || actionName == "index")
                {
                    this.ViewBag.StartupScript =
                            string.Format(CultureInfo.InvariantCulture,
                            "var $plugins={0};",
                            JsonConvert.SerializeObject(plugins));
                }
            }
            catch (Exception ex)
            {
                // CustomTrace.TraceError(ex, "Inject plugin json failed");
            }

            base.OnActionExecuted(context);
        }
    }
}
