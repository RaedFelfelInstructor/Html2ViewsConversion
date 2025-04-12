namespace Html2ViewsConversion.Models.Home
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? OldPrice { get; set; }
        public decimal Price { get; set;}
        public string ImageUrl { get; set; }
        public string Category { get; set; }

    }
}
