using System.ComponentModel.DataAnnotations;

namespace CoffeApp.Models
{
    public class Offer
    {
        public int Id { get; set; }
        [Display(Name = "Rodzaj kawy")]
        public string? Title { get; set; }
        [Display(Name = "Opis kawy")]
        public string? Description { get; set; }
        [Display(Name = "Cena")]
        [Range(0, double.MaxValue)]
        public double Price { get; set; }
        public int SupplierId { get; set; }
        [Display(Name = "Dostawca")]
        public virtual Supplier? Supplier { get; set; }
        [Display(Name = "Dostępny")]
        public bool IsAvailable { get; set; }
        [Display(Name = "Ocena")]
        public double? Rate { get; set; }
        [Display(Name = "Link")]
        public string? Link { get; set; }
    }
}