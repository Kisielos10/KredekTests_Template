using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KredekTests_Template.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private Vehicle[] _vehicle = new []
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
        [HttpGet]
        public ActionResult<List<Vehicle>> Get()
        {
            return Ok(_vehicle);
        }

        [HttpGet("{year}")]
        public ActionResult<Vehicle> GetByYear(int year)
        {
            return Ok(_vehicle.FirstOrDefault(vehicle => vehicle.yearOfProduction == year));
        }

        [HttpPost]
        public void Post([FromBody] string manufacturer,[FromBody] string model,[FromBody] int worth,[FromBody] int yearOfProduction)
        {
            _vehicle =_vehicle.Concat(new[] {new Vehicle(manufacturer,model,yearOfProduction,worth)}).ToArray();
        }

        [HttpPut("{year}")]
        public ActionResult<Vehicle> Put(int year, [FromBody] int worth)
        {
            var result = _vehicle.FirstOrDefault(vehicle => vehicle.yearOfProduction == year);

            result.worth = worth;

            return Ok(result);
        }

        [HttpDelete("{year}")]
        public ActionResult Delete(int year)
        {
            var result = _vehicle.FirstOrDefault(vehicle => vehicle.yearOfProduction == year);

            _vehicle = _vehicle.Where(vehicle => vehicle.yearOfProduction != year).ToArray();

            return NoContent();
        }
    }
}
