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
                    MaxSpeed = 123.00,
                    ImageName = "egg"
                });

                context.Cars.Add(new Models.Car()
                {
                    Model = "Egg2",
                    MaxSpeed = 12.908,
                    ImageName = "egg2"
                });

                context.Cars.Add(new Models.Car()
                {
                    Model = "Egg3",
                    MaxSpeed = 11.93,
                    ImageName = "egg3"
                });

                context.Cars.Add(new Models.Car()
                {
                    Model = "Egg2",
                    MaxSpeed = 32.90,
                    ImageName = "egg2"
                });

            }
        }
    }
}