using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Lemon.Abp.Template.EntityFrameworkCore
{    
    [ConnectionStringName("Default")]
    public class EntityFrameworkCoreDbContext: AbpDbContext<EntityFrameworkCoreDbContext>
    {

        public EntityFrameworkCoreDbContext(DbContextOptions<EntityFrameworkCoreDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Configure();
            base.OnModelCreating(builder);
        }

    }
}