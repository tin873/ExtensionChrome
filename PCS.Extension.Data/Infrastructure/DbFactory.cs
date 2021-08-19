using Microsoft.EntityFrameworkCore;
using PCS.Extension.Data.EF;

namespace PCS.Extension.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private ExtensionContext DbContext;
        private ExtensionContext _dbContext;
        public DbFactory(ExtensionContext dbContext)
        {
            _dbContext = dbContext;
        }
        public ExtensionContext Init() => DbContext ?? (DbContext = _dbContext);

        protected override void DisposeCore()
        {
            if (_dbContext != null)
            {
                _dbContext.Dispose();
            }
        }
    }
}
