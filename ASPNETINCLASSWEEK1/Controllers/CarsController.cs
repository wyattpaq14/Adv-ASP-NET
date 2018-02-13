using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASPNETINCLASSWEEK1.Models;
using ASPNETINCLASSWEEK1.Home;

namespace ASPNETINCLASSWEEK1.Controllers
{
    public class CarsController : Controller
    {
        // GET: Cars
        public ActionResult CarsList()
        {
            var factory = new CarFactory();


            var viewModel = new CarsListViewModel(factory.Cars);
            return View(viewModel);
        }
    }
} 