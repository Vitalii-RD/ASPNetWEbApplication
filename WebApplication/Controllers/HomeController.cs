using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;
using WebApplication.ViewModels;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMaterialRepository _materialRepository;

        public HomeController(IMaterialRepository materialRepository)
        {
            _materialRepository = materialRepository;
        }

        public IActionResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel()
            {
                MaterialsOfTheWeek = _materialRepository.MaterialsOfTheWeek
            };

            return View(homeViewModel);
        }
    }
}
