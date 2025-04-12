namespace Html2ViewsConversion.Models.Home
{
    public class HomeViewModel
    {
        public IEnumerable<CarouselItemViewModel> CarouselItems { get; set; }
        public IEnumerable<ProductViewModel> FeaturedProducts { get; set; }
        public IEnumerable<ProductViewModel> NewArrivals { get; set; }

    }
}
