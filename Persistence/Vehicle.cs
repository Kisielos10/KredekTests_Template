using System.ComponentModel.DataAnnotations;

namespace KredekTests_Template
{
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string manufacturer { get; set; }
        public string model { get; set; }
        public int? yearOfProduction { get; set; }
        public int? worth { get; set; }

        public Vehicle()
        {
        }

        public Vehicle(string manufacturer, string model, int yearOfProduction, int worth)
        {
            this.manufacturer = manufacturer;
            this.model = model;
            this.yearOfProduction = yearOfProduction;
            this.worth = worth;
        }
    }
}
