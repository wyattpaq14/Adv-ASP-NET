using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ASPNETINCLASSWEEK1.Models
{
    public class CarFactory : DbContext
    {
        public DbSet<Car> Cars { get; set; }

        public CarFactory() : base("name=DefaultConnection")
        {
            Database.SetInitializer(new CarIntitalizer());
        }
         
    }

    public class CarIntitalizer : DropCreateDatabaseIfModelChanges<CarFactory>
    {
        protected override void Seed(CarFactory context)
        {
            {
                context.Cars.Add(new Models.Car()
                {
                    Model = "Egg",
                    MaxSpeed = 123.00
                });

                context.Cars.Add(new Models.Car()
                {
                    Model = "Shoe",
                    MaxSpeed = 12.908
                });

                context.Cars.Add(new Models.Car()
                {
                    Model = "Man",
                    MaxSpeed = 11.93
                });

                context.Cars.Add(new Models.Car()
                {
                    Model = "Potato",
                    MaxSpeed = 32.90
                });

            }
        }
    }
}