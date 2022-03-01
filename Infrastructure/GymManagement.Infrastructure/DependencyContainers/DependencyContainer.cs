using GymManagement.Application.Interfaces.Repositories;
using GymManagement.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace GymManagement.Infrastructure.DependencyContainers
{
    public static class DependencyContainer
    {
        public static void AddInfrastructureServices(this IServiceCollection services)
        {

            services.AddScoped<ICampaignRepository, CampaignRepository>();
            
        }
    }
}
