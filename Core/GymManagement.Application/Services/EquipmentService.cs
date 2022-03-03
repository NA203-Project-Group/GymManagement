using System;
using System.Collections.Generic;
using AutoMapper;
using GymManagement.Application.Interfaces.ServiceInterfaces;
using GymManagement.Application.Interfaces.UnitOfWorks;
using GymManagement.Application.ViewModels.EquipmentViewModel;

namespace GymManagement.Application.Services
{
    public class EquipmentService :IEquipmentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public EquipmentService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public List<EquipmentQueryViewModel> GetEquipmentsWithTrainer()
        {
            var equipments =  _unitOfWork.Equipments.GetEquipmentsWithTrainer();
            return  _mapper.Map<List<EquipmentQueryViewModel>>(equipments);
        }
    }
}
