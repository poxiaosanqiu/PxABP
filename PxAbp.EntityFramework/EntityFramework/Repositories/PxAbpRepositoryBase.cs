using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace PxAbp.EntityFramework.Repositories
{
    public abstract class PxAbpRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<PxAbpDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected PxAbpRepositoryBase(IDbContextProvider<PxAbpDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class PxAbpRepositoryBase<TEntity> : PxAbpRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected PxAbpRepositoryBase(IDbContextProvider<PxAbpDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
