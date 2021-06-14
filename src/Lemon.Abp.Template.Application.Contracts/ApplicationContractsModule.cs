using Volo.Abp.Application;
using Volo.Abp.FluentValidation;
using Volo.Abp.Modularity;

namespace Lemon.Abp.Template.Application
{
    [DependsOn(
        typeof(AbpFluentValidationModule),
        typeof(AbpDddApplicationContractsModule)
    )]
    public class ApplicationContractsModule : AbpModule
    {
        
    }
}