using PCS.Extension.Data.Entities;
using PCS.Extension.Data.Repositories;
using PCS.Extension.Services.interfaces;

namespace PCS.Extension.Services.implement
{
    public class SourcePageService : BaseService<SourcePage>, ISourcePageService
    {
        public SourcePageService(IBaseRepository<SourcePage> baseRepository) : base(baseRepository)
        {

        }
    }
}
