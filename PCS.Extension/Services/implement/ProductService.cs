using PCS.Extension.Data.Entities;
using PCS.Extension.Data.Repositories;
using PCS.Extension.Services.interfaces;

namespace PCS.Extension.Services.implement
{
    public class ProductService : BaseService<Products>, IProductService
    {
        public ProductService(IBaseRepository<Products> baseRepository) : base(baseRepository)
        {

        }
    }
}
