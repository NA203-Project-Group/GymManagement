
using System.Collections.Generic;
using GymManagement.Domain.Entities;

namespace GymManagement.Application.Interfaces.ServiceInterfaces
{
    public interface ITrainerService
    {
        List<Trainer> GetAll();
        bool AddMemberExerciseProgram(int memberId);
        bool EquipmentMaintenanceControl(int equipmentId);
    }
}

