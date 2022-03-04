using GymManagement.Application.Interfaces.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace GymManagement.WebAPI.Controllers
{
    //http://localhost:5000/api/campaign
    [Route("api/[controller]")]
    [ApiController]
    public class CampaignController : ControllerBase
    {
        private readonly ICampaignService _campaignService;

        public CampaignController(ICampaignService campaignService)
        {
            _campaignService = campaignService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _campaignService.GetAll();
            return Ok(result);
        }



    }
}


