using PCS.Extension.Data.Entities;
using PCS.Extension.Data.Enum;
using PCS.Extension.Data.Repositories;
using System;

namespace PCS.Extension.Services
{
    public class BaseService<Entity> : IBaseService<Entity> where Entity : class
    {
        protected readonly IBaseRepository<Entity> _baseRepository;
        protected ServiceResult _serviceResult;
        public BaseService(IBaseRepository<Entity> baseRepository)
        {
            _baseRepository = baseRepository;
            _serviceResult = new ServiceResult();
        }

        public ServiceResult Delete(object Id)
        {
            try
            {
                var entity = _baseRepository.GetById(Id);
                if (entity != null)
                {
                    var result = _baseRepository.Delete(entity);
                    if(result > 0)
                    {
                        _serviceResult.IsSuccess = true;
                        _serviceResult.Data = result;
                        _serviceResult.UserMsg.Add("Xóa thành công!");
                        _serviceResult.ExtensionCode = ExtensionCode.Success;
                        return _serviceResult;
                    }   
                    else
                    {
                        _serviceResult.IsSuccess = false;
                        _serviceResult.Data = result;
                        _serviceResult.UserMsg.Add("Không xóa được bản ghi!");
                        _serviceResult.ExtensionCode = ExtensionCode.NotValid;
                        return _serviceResult;
                    }    
                }   
                else
                {
                    _serviceResult.IsSuccess = false;
                    _serviceResult.Data = null;
                    _serviceResult.UserMsg.Add("Không tồn tại bản ghi.");
                    _serviceResult.ExtensionCode = ExtensionCode.NoContent;
                    return _serviceResult;
                }    
            }
            catch (Exception)
            {
                _serviceResult.IsSuccess = false;
                _serviceResult.UserMsg.Add("Lỗi hệ thống!.");
                _serviceResult.ExtensionCode = ExtensionCode.Exeption;
                return _serviceResult;
            }
        }

        public ServiceResult GetById(object Id)
        {
            try
            {
                var entity = _baseRepository.GetById(Id);
                if (entity == null)
                {
                    _serviceResult.IsSuccess = false;
                    _serviceResult.Data = entity;
                    _serviceResult.UserMsg.Add("Id không tồn tại.");
                    _serviceResult.ExtensionCode = ExtensionCode.NoContent;
                    return _serviceResult;
                }
                else
                {
                    _serviceResult.IsSuccess = true;
                    _serviceResult.Data = entity;
                    _serviceResult.UserMsg.Add("Lấy dữ liệu thành công.");
                    _serviceResult.ExtensionCode = ExtensionCode.Success;
                    return _serviceResult;
                }
            }
            catch (Exception)
            {
                _serviceResult.IsSuccess = false;
                _serviceResult.UserMsg.Add("Lỗi hệ thống!.");
                _serviceResult.ExtensionCode = ExtensionCode.Exeption;
                return _serviceResult;
            }
        }


        public ServiceResult Insert(Entity entity)
        {
            try
            {
                var result = _baseRepository.Insert(entity);
                _serviceResult.IsSuccess = true;
                _serviceResult.UserMsg.Add("Thêm mới thành công.");
                _serviceResult.ExtensionCode = ExtensionCode.Success;
                _serviceResult.Data = result;
                return _serviceResult;
            }
            catch (Exception)
            {
                _serviceResult.IsSuccess = false;
                _serviceResult.UserMsg.Add("Lỗi hệ thống!.");
                _serviceResult.ExtensionCode = ExtensionCode.Exeption;
                return _serviceResult;
            }
        }


        public ServiceResult Update(Entity entity, object Id)
        {
            try
            {
                var checkEntity = _baseRepository.GetById(Id);
                if(checkEntity != null)
                {
                    var result = _baseRepository.Update(entity);
                    _serviceResult.IsSuccess = true;
                    _serviceResult.UserMsg.Add("Sửa thông tin thành công.");
                    _serviceResult.Data = result;
                    _serviceResult.ExtensionCode = ExtensionCode.Success;
                    return _serviceResult;
                }  
                else
                {
                    _serviceResult.IsSuccess = false;
                    _serviceResult.UserMsg.Add("Không tồn tại bản ghi.");
                    _serviceResult.Data = null;
                    _serviceResult.ExtensionCode = ExtensionCode.NoContent;
                    return _serviceResult;
                }    
            }
            catch (Exception)
            {
                _serviceResult.IsSuccess = false;
                _serviceResult.UserMsg.Add("Lỗi hệ thống.");
                _serviceResult.ExtensionCode = ExtensionCode.Exeption;
                return _serviceResult;
            }
        }
    }
}
