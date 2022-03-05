using GymManagement.Application.ViewModels.TrainerViewModel;

namespace GymManagement.Application.Interfaces.ServiceInterfaces
{
    public interface IManagerService
    {
        bool CreateTrainer(TrainerCommandViewModel model);
        bool AddMissionToTrainer(int missionId, int trainerId);
    }
}
