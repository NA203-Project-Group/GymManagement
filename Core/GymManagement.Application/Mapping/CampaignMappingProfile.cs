using AutoMapper;
using GymManagement.Application.ViewModels.CampaignViewModel;
using GymManagement.Domain.Entities;

namespace GymManagement.Application.Mapping
{
    public class CampaignMappingProfile : Profile
    {
        public CampaignMappingProfile()
        {
            CreateMap<Campaign, CampaignQueryViewModel>();
           

        }
    }
}
