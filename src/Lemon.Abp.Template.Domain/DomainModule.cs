using Lemon.Abp.Template.Domain.Shared;
using Lemon.Abp.Template.Domain.Shared.MultiTenancy;
using Volo.Abp.Domain;
using Volo.Abp.Modularity;
using Volo.Abp.MultiTenancy;

namespace Lemon.Abp.Template.Domain
{
    [DependsOn(
        typeof(DomainSharedModule),
        typeof(AbpDddDomainModule))]
    public class DomainModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpMultiTenancyOptions>(options =>
            {
                options.IsEnabled = MultiTenancyConsts.IsEnabled;
            });
        }
    }
}