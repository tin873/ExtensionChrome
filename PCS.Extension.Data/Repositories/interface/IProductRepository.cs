using PCS.Extension.Data.Entities;
using System.Collections.Generic;

namespace PCS.Extension.Data.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Products> GetProductsByIdClient(object clientId);
    }
}
