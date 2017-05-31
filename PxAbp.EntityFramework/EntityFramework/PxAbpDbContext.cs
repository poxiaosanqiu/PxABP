using System.Data.Common;
using Abp.Zero.EntityFramework;
using PxAbp.Authorization.Roles;
using PxAbp.MultiTenancy;
using PxAbp.Users;
using System.Data.Entity;
using PxAbp.Tasks;

namespace PxAbp.EntityFramework
{
    public class PxAbpDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public PxAbpDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in PxAbpDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of PxAbpDbContext since ABP automatically handles it.
         */
        public PxAbpDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public PxAbpDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public PxAbpDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }

        public IDbSet<Task> Tasks { get; set; }
    }
}
