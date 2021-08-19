using PCS.Extension.Data.Entities;
using PCS.Extension.Data.Infrastructure;

namespace PCS.Extension.Data.Repositories.implement
{
    public class ProductRepository : BaseRepository<Products>, IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory, IUnitOfWork unitOfWork) : base(dbFactory, unitOfWork)
        {

        }
    }
}
