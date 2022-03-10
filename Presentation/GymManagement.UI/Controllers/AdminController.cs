using System.Linq;
using GymManagement.Application.Interfaces.ServiceInterfaces;
using GymManagement.Application.ViewModels.MemberViewModel;
using GymManagement.Application.ViewModels.TrainerViewModel;
using GymManagement.UI.Models;
using Microsoft.AspNetCore.Mvc;

namespace GymManagement.UI.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAuthService _authService;
        private readonly IManagerService _managerService;
        private readonly ITrainerService _trainerService;
        private readonly IMissionService _missionService;
        private readonly IEquipmentService _equipmentService;

        public AdminController(IAuthService authService, IManagerService managerService, ITrainerService trainerService, IMissionService missionService, IEquipmentService equipmentService)
        {
            _authService = authService;
            _managerService = managerService;
            _trainerService = trainerService;
            _missionService = missionService;
            _equipmentService = equipmentService;
        }

        [HttpPost]
        public IActionResult Login(MemberLoginViewModel model)
        {
            var token = _authService.Login(model);
            if (token is null)
            {
                return NotFound();
            }

            return RedirectToAction("Dashboard");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Dashboard()
        {
           var members =  _managerService.GetAll();

           if (members is null)
           {
               return NotFound();
           }

           return View(members);
        }
        public IActionResult Members()
        {
            var members = _managerService.GetAll();
            return View(members);
        }
        public IActionResult Trainers()
        {
            var trainers = _trainerService.GetTrainersWithEmployeeDetail();
            TrainerMissionViewModel model = new TrainerMissionViewModel();
            model.Trainers = _trainerService.GetTrainersWithEmployeeDetail();
            model.Missions = _missionService.GetAll().Take(11);

            return View(model);
        }

        [HttpPost]
        public IActionResult AddTrainer(TrainerCommandViewModel model)
        {
            if (model is not null)
            {
                _managerService.CreateTrainer(model);
            }
            return View("Trainers");
        }

        [HttpGet]
        public IActionResult AddTrainer()
        {
            return View();
        }

        public IActionResult Billign()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult Equipment()
        {
            var equipments = _equipmentService.GetEquipmentsWithTrainer();

            return View(equipments);
        }

    }
}
