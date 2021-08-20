using Microsoft.EntityFrameworkCore;
using PCS.Extension.Data.EF;
using PCS.Extension.Data.Infrastructure;

namespace PCS.Extension.Data.Repositories
{
    public class BaseRepository<Entity> : IBaseRepository<Entity> where Entity : class
    {
        private ExtensionContext _dbContext;
        private readonly DbSet<Entity> _dbSet;
        protected readonly IUnitOfWork _unitOfWork;

        protected IDbFactory DbFactory { get; set; }
        protected ExtensionContext DbContext => _dbContext ?? (_dbContext = DbFactory.Init());
        public BaseRepository(IDbFactory dbFactory, IUnitOfWork unitOfWork)
        {
            DbFactory = dbFactory;
            _dbSet = DbContext.Set<Entity>();
            _unitOfWork = unitOfWork;
        }

        public int Delete(Entity entity)
        {
            _dbSet.Remove(entity);
            return _unitOfWork.Commit();
        }

        public Entity Insert(Entity entity)
        {
            _dbSet.Add(entity);
            _unitOfWork.Commit();
            return entity;
        }

        public int Update(Entity entity)
        {
            _dbSet.Update(entity);
            return _unitOfWork.Commit();
        }

        public Entity GetById(object Id)
        {
            return _dbSet.Find(Id);
        }
    }
}
