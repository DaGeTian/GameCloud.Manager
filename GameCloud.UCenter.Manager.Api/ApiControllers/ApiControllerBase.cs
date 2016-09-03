using System.ComponentModel.Composition;
using GameCloud.UCenter.Common.Settings;
using GameCloud.UCenter.Database;
using Microsoft.AspNetCore.Mvc;

namespace GameCloud.UCenter.Manager.Api.ApiControllers
{
    /// <summary>
    /// Provide an API controller base class.
    /// </summary>
    [Export]
    public class ApiControllerBase : Controller
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiControllerBase" /> class.
        /// </summary>
        /// <param name="database">Indicating the database.</param>
        /// <param name="settings">Indicating the settings.</param>
        [ImportingConstructor]
        public ApiControllerBase(UCenterDatabaseContext database, Settings settings)
        {
            this.Database = database;
            this.Settings = settings;
        }

        /// <summary>
        /// Gets the database context.
        /// </summary>
        protected UCenterDatabaseContext Database { get; private set; }

        /// <summary>
        /// Gets the settings.
        /// </summary>
        protected Settings Settings { get; private set; }
    }
}
