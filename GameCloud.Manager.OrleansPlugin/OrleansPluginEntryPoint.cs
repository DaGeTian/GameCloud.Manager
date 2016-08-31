using GameCloud.Manager.Contract;
using GameCloud.Manager.Contract.Attributes;
using GameCloud.Manager.Contract.Requests;
using Orleans;
using TexasPoker.GrainInterface;

namespace GameCloud.Manager.OrleansPlugin
{
    [PluginMetadata(Name = "orleansplugin", DisplayName = "Orleans插件", Description = "示例Orleans使用")]
    [PluginCategoryMetadata(Name = "update", DisplayName = "Grain UPDATE", Description = "调用Grain update方法")]
    public class OrleansPluginEntryPoint : PluginEntryPoint
    {
        [PluginItemMetadata(Name = "demo-update", Category = "update", DisplayName = "更新数据示例", Description = "Demo for update data", Type = PluginItemType.Update)]
        public OrleansSettings GetDataForDemoUpdate(PluginRequestInfo request)
        {
            GrainClient.Initialize();

            string id = "TaxasPokerManager";
            var grain = GrainClient.GrainFactory.GetGrain<ITexasPokerManager>(id);

            if (request.Method == PluginRequestMethod.Update)
            {
                var rate = request.GetParameterValue<float>("PumpingRate");
                grain.SetPumpingRate(rate).Wait();
            }

            var orleansSettings = new OrleansSettings();
            orleansSettings.PumpingRate = grain.GetPumpingRate().Result;

            return orleansSettings;
        }
    }
}
