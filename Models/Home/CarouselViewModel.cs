namespace Html2ViewsConversion.Models.Home
{
    public class CarouselItemViewModel
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string ImageUrl { get; set; }
        public string LinkUrl { get; set; }
        public string ButtonText { get; set; }
        public bool IsActive { get; set; } 
    }

    public class CarouselViewModel
    {
        public IEnumerable<CarouselItemViewModel> Items { get; set; }
    }

}
