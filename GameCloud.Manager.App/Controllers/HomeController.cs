using System;
using System.Globalization;
using System.IO;
using GameCloud.Manager.App.Manager;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;

namespace GameCloud.Manager.App.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHostingEnvironment hostingEnvironment;
        private readonly PluginManager manager;

        public HomeController(PluginManager manager, IHostingEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment;
            this.manager = manager;
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
                var descriptor = context.ActionDescriptor as ControllerActionDescriptor;
                if (descriptor != null && (descriptor.ActionName.ToLower() == "index" || descriptor.ActionName.ToLower() == "plugin"))
                {
                    this.ViewBag.StartupScript =
                        string.Format(CultureInfo.InvariantCulture,
                        "var $plugins={0};",
                        JsonConvert.SerializeObject(this.manager.Plugins));
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
