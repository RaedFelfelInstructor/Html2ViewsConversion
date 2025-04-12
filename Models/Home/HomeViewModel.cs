﻿namespace Html2ViewsConversion.Models.Home
{
    public class HomeViewModel
    {
        public IEnumerable<CarouselItemViewModel> CarouselItems { get; set; }
        public IEnumerable<ProductViewModel> FeaturedProducts { get; set; }
        public IEnumerable<ProductViewModel> NewArrivals { get; set; }
        public SpecialOfferViewModel? SpecialOffer { get; set; }
        public IEnumerable<CategoryViewModel> Categories { get; set; }
        public IEnumerable<TestimonialViewModel> Testimonials { get; set; }
        public CallToActionViewModel CallToAction { get; set; }


    }
}
