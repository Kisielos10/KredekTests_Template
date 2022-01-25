using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KredekTests_Template
{
    public class StatisticsCalculator
    {
        public decimal CalculateMeanWorth(List<Vehicle> vehicle)
        {
            if (vehicle == null)
            {
                throw new ArgumentNullException("This value should not be null");
            }

            if (vehicle.Count == 0)
            {
                return 0;
            }

            var sum = vehicle.Sum(x => x.Worth);

            var result = sum / vehicle.Count;

            return decimal.Round((decimal)result, 2);
        }

        public decimal CalculateMeanWorthPerPower(List<Vehicle> vehicle)
        {
            if (vehicle == null)
            {
                throw new ArgumentNullException("This value should not be null");
            }

            if (vehicle.All(dto => dto.Worth == 0))
            {
                return 0;
            }

            if (vehicle.Any(dto => dto.Worth <= 0 ) || vehicle.Any(dto => dto.Power <= 0 ))
            {
                throw new ArgumentOutOfRangeException("Area and Price should have a valid value");
            }

            var sumWorth = vehicle.Sum(x => x.Worth);
            var sumPower = vehicle.Sum(x => x.Power);

            var result = sumWorth / sumPower;

            return decimal.Round((decimal)result,2);
        }
    }
}
