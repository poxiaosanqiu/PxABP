using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningMpaAbp.EntityFramework.Repositories
{
    public abstract class PxABPRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<PxAbpDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected PxABPRepositoryBase(IDbContextProvider<PxAbpDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class PxABPRepositoryBase<TEntity> : EfRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected PxABPRepositoryBase(IDbContextProvider<PxAbpDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
