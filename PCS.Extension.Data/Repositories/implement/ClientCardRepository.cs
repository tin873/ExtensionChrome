using PCS.Extension.Data.Entities;
using PCS.Extension.Data.Infrastructure;

namespace PCS.Extension.Data.Repositories.implement
{
    public class ClientCardRepository : BaseRepository<ClientCard>, IClientCardRepository
    {
        public ClientCardRepository(IDbFactory dbFactory, IUnitOfWork unitOfWork) : base(dbFactory, unitOfWork)
        {

        }
    }
}
