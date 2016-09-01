using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using GameCloud.Manager.Web.Models;

namespace GameCloud.Manager.Web.Manager
{
    public class PluginClient
    {
        private readonly Plugin plugin;

        public PluginClient(Plugin plugin)
        {
            this.plugin = plugin;
        }

        public Task<TResponse> SendAsync<TRequest, TResponse>(PluginPage page, TRequest request, CancellationToken token)
        {
            throw new NotImplementedException();
        }
    }
}
