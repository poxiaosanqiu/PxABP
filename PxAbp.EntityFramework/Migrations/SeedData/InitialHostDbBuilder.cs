using PxAbp.EntityFramework;
using EntityFramework.DynamicFilters;

namespace PxAbp.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly PxAbpDbContext _context;

        public InitialHostDbBuilder(PxAbpDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
