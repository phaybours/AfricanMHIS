using AMHC.DAL.Context;
using AMHC.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMHC.DAL.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private AMHCContext dbContext;

        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public AMHCContext DbContext
        {
            get { return dbContext ?? (dbContext = dbFactory.Init()); }
        }

        public async Task<int> Commit(int userId)
        {
            return await DbContext.Commit(userId);
        }

        public int CommitNonAsync(int userId)
        {
            return DbContext.CommitNonAsync(userId);
        }
    }
}
