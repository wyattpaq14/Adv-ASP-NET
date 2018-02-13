using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASPNETINCLASSWEEK1.Models;
using System.Web.Mvc;


namespace ASPNETINCLASSWEEK1.Home
{
    public class CarsListViewModel
    {
        public IEnumerable<SelectListItem> CarsList { get; private set; }

        public Car FastestCar { get; set; }

        public CarsListViewModel(IEnumerable<Car> cars)
        {
            CarsList = cars.Select(c => new SelectListItem() { Text = c.Model });

            FastestCar = cars.OrderByDescending(c => c.MaxSpeed).FirstOrDefault();

        }
    }
}