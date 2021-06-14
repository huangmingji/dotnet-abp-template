using Lemon.Abp.Template.Application;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Modularity;

namespace Lemon.Abp.Template.HttpApi
{
    [DependsOn(
        typeof(ApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule)
    )]
    public class HttpApiModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
        }
    }
}