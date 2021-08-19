using System.Threading.Tasks;

namespace PCS.Extension.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        int Commit();
        Task<int> CommitAsync();
    }
}
