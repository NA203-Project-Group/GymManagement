using System.Collections.Generic;
using GymManagement.Application.ViewModels.EquipmentViewModel;

namespace GymManagement.Application.Interfaces.ServiceInterfaces
{
    public interface IEquipmentService
    {
        public List<EquipmentQueryViewModel> GetEquipmentsWithTrainer();
    }
}

