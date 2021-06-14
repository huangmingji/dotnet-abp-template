using Lemon.Abp.Template.Application;
using Lemon.Abp.Template.EntityFrameworkCore.DbMigrations;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Lemon.Abp.Template.DbMigrations
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(EntityFrameworkCoreDbMigrationsModule),
        typeof(ApplicationModule)
    )]
    public class DbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            // Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}