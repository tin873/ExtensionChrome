using PCS.Extension.Data.Entities;
using PCS.Extension.Data.Repositories;
using PCS.Extension.Services.interfaces;

namespace PCS.Extension.Services.implement
{
    public class ClientCardService : BaseService<ClientCard>, IClientCardService
    {
        public ClientCardService(IBaseRepository<ClientCard> baseRepository) : base(baseRepository)
        {

        }
    }
}
