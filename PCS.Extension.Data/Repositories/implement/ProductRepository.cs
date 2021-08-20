using PCS.Extension.Data.Entities;
using PCS.Extension.Data.Infrastructure;
using System.Collections.Generic;
using System.Linq;

namespace PCS.Extension.Data.Repositories.implement
{
    public class ProductRepository : BaseRepository<Products>, IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory, IUnitOfWork unitOfWork) : base(dbFactory, unitOfWork)
        {

        }

        public IEnumerable<Products> GetProductsByIdClient(object clientId)
        {
            var listProducts = DbContext.Products.Where(x => x.ClientCardId == clientId);
            if (listProducts.Count() > 0)
                return listProducts;
            return null;
        }
    }
}
