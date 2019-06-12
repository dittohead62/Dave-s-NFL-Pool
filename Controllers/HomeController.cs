using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsAnalysis.Models;
using SportsAnalysis.ViewModel;

namespace SportsAnalysis.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository _repository;

        public HomeController(IRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "Sport Analysis";
            var Sports = _repository.GetAllSports();

            /*
            HomeViewModel viewModel = new HomeViewModel
            {
                Title = "Sports Analysis",
                //Sports = _repository.GetAllSports().ToList()
            };
            */
            return View(Sports);
        }
    }
}