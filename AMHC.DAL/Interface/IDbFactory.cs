using AMHC.DAL.Context;

namespace AMHC.DAL.Interface
{
    public interface IDbFactory
    {
        AMHCContext Init();
    }
}
