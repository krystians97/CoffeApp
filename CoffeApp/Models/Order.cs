namespace CoffeApp.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int Sugar { get; set; }
        public bool Milk { get; set; }
        public bool DoublePortion { get; set; }
        public int OfferId { get; set; }
        virtual public Offer? Offer { get; set; }


        // Odwo³anie siê do danych z modelu Offer
        public string? OfferTitle => Offer?.Title;
        public string? OfferSupplier => Offer?.Supplier?.Name;
        public string? OfferDescription => Offer?.Description;
        public string? OfferPrice => Offer?.Description;
    }
}
