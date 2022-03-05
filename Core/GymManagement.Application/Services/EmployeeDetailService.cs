﻿using GymManagement.Application.Extensions;
using GymManagement.Application.Interfaces.ServiceInterfaces;
using GymManagement.Application.Interfaces.UnitOfWorks;
using GymManagement.Domain.Entities;

namespace GymManagement.Application.Services
{
    public class EmployeeDetailService :IEmployeeDetailService
    {
        private readonly IUnitOfWork _unitOfWork;
        public EmployeeDetailService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public EmployeeDetail GetById(int id)
        {
            return _unitOfWork.EmployeeDetails.GetById(id);
        }

        public bool Create(EmployeeDetail model)
        {
            _unitOfWork.EmployeeDetails.Create(model);
            if (_unitOfWork.SaveChanges())
            {
                return true;
            }

            return false;
        }

        public bool Update(EmployeeDetail model, int id)
        {
            var employeeDetail =  _unitOfWork.EmployeeDetails.GetById(id);
            employeeDetail.IfIsNullThrowNotFoundException("Employee Detail", id);

            _unitOfWork.EmployeeDetails.Update(model);
            if (_unitOfWork.SaveChanges())
            {
                return true;
            }

            return false;
        }

        public bool Delete(int id)
        {
            var employeeDetail = _unitOfWork.EmployeeDetails.GetById(id);

            employeeDetail.IfIsNullThrowNotFoundException("Employee Detail", id);

            employeeDetail.IsDeleted = true;
            _unitOfWork.EmployeeDetails.Update(employeeDetail);
            if (_unitOfWork.SaveChanges())
            {
                return true;
            }

            return false;

        }
    }
}
