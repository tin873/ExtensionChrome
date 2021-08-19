using PCS.Extension.Data.Entities;

namespace PCS.Extension.Services
{
    public interface IBaseService<Entity> where Entity : class
    {
        ServiceResult Insert(Entity entity);
        ServiceResult Update(Entity entity, object Id);
        ServiceResult Delete(object Id);
        ServiceResult GetById(object Id);
    }
}
