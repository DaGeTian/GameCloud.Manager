using System.Web.Mvc;
using GameCloud.Manager.Handlers;

namespace GameCloud.Manager.Controllers
{
    public class BaseController : Controller
    {
        public BaseController(PluginManager manager)
        {
            this.Manager = manager;
        }

        public PluginManager Manager { get; private set; }

        // GET: Base
        public ActionResult Index()
        {
            return View();
        }
    }
}