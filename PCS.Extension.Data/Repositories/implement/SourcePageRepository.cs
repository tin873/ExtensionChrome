using PCS.Extension.Data.Entities;
using PCS.Extension.Data.Infrastructure;

namespace PCS.Extension.Data.Repositories.implement
{
    public class SourcePageRepository : BaseRepository<SourcePage>, ISourcePageRepository
    {
        public SourcePageRepository(IDbFactory dbFactory, IUnitOfWork unitOfWork) : base(dbFactory, unitOfWork)
        {

        }
    }
}
