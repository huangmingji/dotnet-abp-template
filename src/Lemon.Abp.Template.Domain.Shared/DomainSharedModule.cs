using Volo.Abp.Modularity;
using Volo.Abp.Validation;

namespace Lemon.Abp.Template.Domain.Shared
{
    [DependsOn(
        typeof(AbpValidationModule))]
    public class DomainSharedModule : AbpModule
    {
        public DomainSharedModule()
        {
        }
    }
}
