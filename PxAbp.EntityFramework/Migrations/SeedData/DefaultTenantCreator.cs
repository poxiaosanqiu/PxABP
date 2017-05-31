using System.Linq;
using PxAbp.EntityFramework;
using PxAbp.MultiTenancy;

namespace PxAbp.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly PxAbpDbContext _context;

        public DefaultTenantCreator(PxAbpDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
