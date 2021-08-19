using PCS.Extension.Data.Entities;
using PCS.Extension.Data.Infrastructure;

namespace PCS.Extension.Data.Repositories.implement
{
    public class CurrencyRepository : BaseRepository<Currency>, ICurrencyRepository
    {
        public CurrencyRepository(IDbFactory dbFactory, IUnitOfWork unitOfWork) : base(dbFactory, unitOfWork)
        {

        }
    }
}
