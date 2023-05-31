using System.ComponentModel.DataAnnotations;

namespace CoffeApp.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        [Display(Name = "Nazwa dostawcy")]
        public string? Name { get; set; }
        public string? PhoneNumer { get; set; }
        public string? Mail { get; set; }
    }
}