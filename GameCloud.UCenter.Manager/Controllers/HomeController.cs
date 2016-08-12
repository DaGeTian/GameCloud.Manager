using System.ComponentModel.Composition;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Mvc;
using GameCloud.Database.Adapters;
using GameCloud.UCenter.Database;

namespace GameCloud.UCenter.Manager.Controllers
{
    /// <summary>
    /// Provide a class for home controller.
    /// </summary>
    [Export]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class HomeController : ControllerBase
    {
        private readonly UCenterDatabaseContext database;

        /// <summary>
        /// Initializes a new instance of the <see cref="HomeController" /> class.
        /// </summary>
        /// <param name="database">Indicating the database context</param>
        [ImportingConstructor]
        public HomeController(UCenterDatabaseContext database)
        {
            this.database = database;
        }

        /// <summary>
        /// Get the index page.
        /// </summary>
        /// <returns>action result.</returns>
        public ActionResult Index()
        {
            return this.View();
        }

        /// <summary>
        /// Get the app list page.
        /// </summary>
        /// <returns>action result.</returns>
        public ActionResult Apps()
        {
            return this.View();
        }

        /// <summary>
        /// Get the user list page.
        /// </summary>
        /// <returns>action result.</returns>
        public ActionResult UserList()
        {
            return this.View();
        }

        /// <summary>
        /// Get the device list page.
        /// </summary>
        /// <returns>action result.</returns>
        public ActionResult DeviceList()
        {
            return this.View();
        }

        /// <summary>
        /// Get the account event list page.
        /// </summary>
        /// <returns>action result.</returns>
        public ActionResult AccountEvents()
        {
            return this.View();
        }

        /// <summary>
        /// Get the error event list page.
        /// </summary>
        /// <returns>action result.</returns>
        public ActionResult ErrorEvents()
        {
            return this.View();
        }

        /// <summary>
        /// Gets the single order page.
        /// </summary>
        /// <param name="id">indicating the order id.</param>
        /// <returns>action result.</returns>
        public ActionResult SingleAppConfiguration(string id)
        {
            ViewBag.AppId = id;
            return this.View();
        }

        /// <summary>
        /// Get the order list page.
        /// </summary>
        /// <param name="token">Indicating the cancellation token.</param>
        /// <param name="accountId">Indicating the account id.</param>
        /// <returns>action result.</returns>
        public async Task<ActionResult> OrderList(CancellationToken token, string accountId = null)
        {
            if (!string.IsNullOrEmpty(accountId))
            {
                var account = await this.database.Accounts.GetSingleAsync(accountId, token);
                ViewBag.AccountId = account.Id;
                ViewBag.AccountName = account.AccountName;
            }

            return this.View();
        }
        
        /// <summary>
        /// Gets the single order page.
        /// </summary>
        /// <param name="id">indicating the order id.</param>
        /// <returns>action result.</returns>
        public ActionResult SingleOrder(string id)
        {
            ViewBag.OrderId = id;
            return this.View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>action result.</returns>
        public ActionResult RealtimeGlance()
        {
            ViewBag.Message = "Your application description page.";

            return this.View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>action result.</returns>
        public ActionResult NewUsers()
        {
            ViewBag.Message = "Your contact page.";

            return this.View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>action result.</returns>
        public ActionResult ActiveUsers()
        {
            ViewBag.Message = "Your contact page.";

            return this.View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>action result.</returns>
        public ActionResult Stay()
        {
            ViewBag.Message = "Your contact page.";

            return this.View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>action result.</returns>
        public ActionResult Lost()
        {
            ViewBag.Message = "Your contact page.";

            return this.View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>action result.</returns>
        public ActionResult OnlineAnalytics()
        {
            ViewBag.Message = "Your contact page.";

            return this.View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>action result.</returns>
        public ActionResult OnlineBehaviour()
        {
            ViewBag.Message = "Your contact page.";

            return this.View();
        }
    }
}