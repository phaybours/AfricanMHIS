using AMHC.DAL.Context;
using AMHC.DAL.Interface;

namespace AMHC.DAL.Implementation
{
    public class DbFactory : Disposable, IDbFactory
    {
        AMHCContext dbContext;

        public AMHCContext Init()
        {
            return dbContext ?? (dbContext = new AMHCContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
