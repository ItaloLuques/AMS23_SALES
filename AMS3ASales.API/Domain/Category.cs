namespace AMS3ASales.API.Domain
{
    public class Category
    {
        public Guid id { get; set; }
        public bool IsActive { get; set; }
        public string? description { get; set; }
        public string? ImageURL { get; set; }


    }
}
