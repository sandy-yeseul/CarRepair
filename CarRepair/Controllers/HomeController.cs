using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRepair.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarRepair.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
        [HttpGet]
        public ViewResult Register()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Register(Car car)
        {
            Repository.AddCar(car);
            return View("ThankYou", car);

        }
        public ViewResult List()
        {
            return View(Repository.Cars.OrderBy(c => c.OwnerName));
        }
        public ViewResult ViewCar(string ownerName)
        {
            return View(Repository.Cars.FirstOrDefault(c => c.OwnerName == ownerName));
        }
    }
}