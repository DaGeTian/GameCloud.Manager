using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Orleans;
using TexasPoker.GrainInterface;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TexasPoker.Manager.Api.ApiControllers
{
    [Route("api/settings")]
    public class SettingsController : Controller
    {
        [HttpPost]
        public async Task<float> Post([FromBody]float value)
        {
            GrainClient.Initialize();

            string id = "TaxasPokerManager";
            var grain = GrainClient.GrainFactory.GetGrain<ITexasPokerManager>(id);
            await grain.SetPumpingRate(value);

            return await grain.GetPumpingRate();
        }
    }
}
