using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using PxAbp.EntityFramework;

namespace PxAbp.Migrator
{
    [DependsOn(typeof(PxAbpDataModule))]
    public class PxAbpMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<PxAbpDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}