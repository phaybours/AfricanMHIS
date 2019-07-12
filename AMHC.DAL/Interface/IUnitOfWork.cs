using System.Threading.Tasks;

namespace AMHC.DAL.Interface
{
    public interface IUnitOfWork
    {
        Task<int> Commit(int userId);

        int CommitNonAsync(int userId);
    }
}
