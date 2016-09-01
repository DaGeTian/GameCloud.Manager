using System;
using System.Threading;
using System.Threading.Tasks;
using GameCloud.Manager.App.Models;

namespace GameCloud.Manager.App.Manager
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
