using System.Linq;

namespace KredekTests_Template
{
    internal class DbInitializer
    {
        public static void Initialize(VehicleDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Vehicles.Any())
            {
                return;
            }


            var vehicles = new[]
            {
                new Vehicle()
                {
                    manufacturer = "VW",
                    model = "Golf",
                    worth = 5000,
                    yearOfProduction = 2000
                },
                new Vehicle()
                {
                    manufacturer = "Renault",
                    model = "Megane",
                    worth = 7000,
                    yearOfProduction = 2003
                },
                new Vehicle()
                {
                    manufacturer = "Honda",
                    model = "Civic",
                    worth = 4000,
                    yearOfProduction = 1999
                }

            };

            foreach (var vehicle in vehicles)
            {
                context.Vehicles.Add(vehicle);
            }

            context.SaveChanges();
        }
    }
}