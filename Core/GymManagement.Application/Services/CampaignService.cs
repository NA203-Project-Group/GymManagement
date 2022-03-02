using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManagement.Application.Interfaces.Repositories;
using GymManagement.Application.Interfaces.ServiceInterfaces;
using GymManagement.Application.Interfaces.UnitOfWorks;
using GymManagement.Application.ViewModels.CampaignViewModel;

namespace GymManagement.Application.Services
{
    public class CampaignService : ICampaignService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CampaignService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public List<CampaignQueryViewModel> GetAll()
        {
            var campaigns =  _unitOfWork.Campaigns.GetAll();

            return null;
        }

        public bool Create(CampaignCommandViewModel model)
        {
            throw new NotImplementedException();
        }

        public bool Update(CampaignCommandViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
