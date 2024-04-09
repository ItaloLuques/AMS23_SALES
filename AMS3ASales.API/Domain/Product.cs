namespace AMS3ASales.API.Domain
{
    public class Product
    {
        public Guid id { get; set; }
        public string? Description { get; set; }
        public double stock { get; set; }
        public double price { get; set; }
        public string? ImageURL { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; }



    }
}
