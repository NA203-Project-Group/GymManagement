using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManagement.Application.Interfaces.ServiceInterfaces;
using GymManagement.Application.Interfaces.UnitOfWorks;
using GymManagement.Domain.Entities;

namespace GymManagement.Application.Services
{
    public class TrainerService :ITrainerService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TrainerService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public List<Trainer> GetAll()
        {
            return null;
        }

        public bool AddMemberExerciseProgram(int memberId)
        {
            throw new NotImplementedException();
        }

        public bool EquipmentMaintenanceControl(int equipmentId)
        {
            throw new NotImplementedException();
        }
    }
}
