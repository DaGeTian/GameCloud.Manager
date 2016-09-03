using System;
using System.ComponentModel.Composition;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using GameCloud.Database.Adapters;
using GameCloud.Manager.PluginContract.Requests;
using GameCloud.Manager.PluginContract.Responses;
using GameCloud.UCenter.Common.Settings;
using MongoDB.Driver;
using TexasPoker.Database;
using TexasPoker.Database.Entities;
using Microsoft.AspNetCore.Mvc;

namespace TexasPoker.Manager.Api.ApiControllers
{
    /// <summary>
    /// Provide a controller for players
    /// </summary>
    [Export]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class PlayersController : ApiControllerBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayersController" /> class.
        /// </summary>
        /// <param name="database">Indicating the database context.</param>
        /// <param name="settings">Indicating the settings.</param>
        [ImportingConstructor]
        public PlayersController(TexasPokerDatabaseContext database, Settings settings)
            : base(database, settings)
        {
        }

        /// <summary>
        /// Get event list.
        /// </summary>
        /// <param name="token">Indicating the cancellation token.</param>
        /// <param name="keyword">Indicating the keyword.</param>
        /// <param name="orderby">Indicating the order by name.</param>
        /// <param name="page">Indicating the page number.</param>
        /// <param name="count">Indicating the count.</param>
        /// <returns>Async return event list.</returns>
        [Route("api/players")]
        public async Task<PluginPaginationResponse<PlayerEntity>> Post([FromBody]PluginRequestInfo request)
        {
            string keyword = request.GetParameterValue<string>("keyword");
            int page = request.GetParameterValue<int>("page", 1);
            int count = request.GetParameterValue<int>("pageSize", 10);

            Expression<Func<PlayerEntity, bool>> filter = null;

            if (!string.IsNullOrEmpty(keyword))
            {
                filter = p => p.map_component.DefActor.IsBot == "false"
                    || p.map_component.DefActor.AccountId == keyword
                    || p.map_component.DefActor.NickName.Contains(keyword);
            }
            else
            {
                filter = p => p.map_component.DefActor.IsBot == "false";
            }

            var total = await this.Database.Players.CountAsync(filter, CancellationToken.None);

            IQueryable<PlayerEntity> queryable = this.Database.Players.Collection.AsQueryable();
            if (filter != null)
            {
                queryable = queryable.Where(filter);
            }

            queryable.OrderByDescending(p => p.map_component.DefActor.Gold);

            var result = queryable.Skip((page - 1) * count).Take(count).ToList();

            // todo: add orderby support.
            var model = new PluginPaginationResponse<PlayerEntity>
            {
                Page = page,
                PageSize = count,
                Raws = result,
                Total = total
            };

            return model;
        }
    }
}
