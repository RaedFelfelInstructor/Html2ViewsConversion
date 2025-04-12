using Html2ViewsConversion.Models;
using Html2ViewsConversion.Models.Home;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Html2ViewsConversion.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        public HomeController(
            ILogger<HomeController> logger, 
            SignInManager<IdentityUser> signInManager,
            UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            this.signInManager = signInManager;
            this.userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var homeVieModel = new HomeViewModel
            {
                CarouselItems = GetCarouselItems(),
                FeaturedProducts = GetFeaturedProducts(),
                NewArrivals = GetNewArrivals(),
                SpecialOffer = GetSpecialOffer(),
                Categories = GetCategories(),
                Testimonials = GetTestimonials(),
                CallToAction = GetCallToAction()
            };
            return View(homeVieModel);
        }

        private CallToActionViewModel GetCallToAction()
        {
            return new CallToActionViewModel
            {
                Title = "Ready to start shopping?",
                Description = "Explore our wide range of products and find exactly what you'r looking for.",
                ButtonText = "Shop Now",
                ControllerName = "Products",
                ActionName = "Index"
            };
        }

        private IEnumerable<TestimonialViewModel> GetTestimonials()
        {
            return new List<TestimonialViewModel>
            {
                new TestimonialViewModel
                {
                    Id = 1,
                    CustomerName = "John Doe",
                    Comment = "Excellent service and fast delivery. The products are of high quality and exactly as described. Will definitely shop here again!",
                    Rating = 5.0m,
                    ImageUrl = "https://placehold.co/50x50/6c757d/white?text=JD"
                },
                new TestimonialViewModel
                {
                    Id = 2,
                    CustomerName = "Jane Smith",
                    Comment = "I'm impressed with the quality of the products. The customer service was very helpful when I had questions about my order.",
                    Rating = 4.5m,
                    ImageUrl = "https://placehold.co/50x50/6c757d/white?text=JS"
                },
                new TestimonialViewModel
                {
                    Id = 3,
                    CustomerName = "Robert Johnson",
                    Comment = "Fast shipping and the product exceeded my expectations. The online shopping experience was seamless from start to finish.",
                    Rating = 5.0m,
                    ImageUrl = "https://placehold.co/50x50/6c757d/white?text=RJ"
                }
            };

        }

        private IEnumerable<CategoryViewModel> GetCategories()
        {
            return new List<CategoryViewModel>
            {
                new CategoryViewModel
                {
                    Id = 1,
                    Name = "Electronics",
                    Slug = "electronics",
                    IconClass = "fas fa-laptop",
                    Description = "The latest gadgets and tech innovations."
                },
                new CategoryViewModel
                {
                    Id = 2,
                    Name = "Clothing",
                    Slug = "clothing",
                    IconClass = "fas fa-tshirt",
                    Description = "Fashionable apparel for all ages."
                },
                new CategoryViewModel
                {
                    Id = 3,
                    Name = "Home & Kitchen",
                    Slug = "home",
                    IconClass = "fas fa-home",
                    Description = "Everything you need for your home."
                }
            };
        }

        private List<CarouselItemViewModel> GetCarouselItems()
        {
            return new List<CarouselItemViewModel>
                {
                    new CarouselItemViewModel
                    {
                        Title = "Summer Sale",
                        Subtitle = "Up to 50% off on selected items. Limited time offer!",
                        ImageUrl = "https://placehold.co/1200x400/0d6efd/white?text=Summer+Sale",
                        LinkUrl = "sale",
                        ButtonText = "Shop Now",
                        IsActive = true
                    },
                    new CarouselItemViewModel
                    {
                        Title = "New Arrivals",
                        Subtitle = "Check out our latest products for this season.",
                        ImageUrl = "https://placehold.co/1200x400/6610f2/white?text=New+Arrivals",
                        LinkUrl = "new",
                        ButtonText = "Shop Now",
                        IsActive = false
                    },
                    new CarouselItemViewModel
                    {
                        Title = "Free Shipping",
                        Subtitle = "On all orders over $50. Shop now and save!",
                        ImageUrl = "https://placehold.co/1200x400/20c997/white?text=Free+Shipping",
                        LinkUrl = "",  // No specific category
                        ButtonText = "Shop Now",
                        IsActive = false
                    }
                };
        }

        private List<ProductViewModel> GetFeaturedProducts()
        {
            return new List<ProductViewModel>
                {
                    new ProductViewModel
                    {
                        Id = 1,
                        Name = "Wireless Head Phones",
                        Price = 89.99m,
                        OldPrice = 129.99m,
                        ImageUrl="https://placehold.co/300x300/f8f9fa/0d6efd?text=Wireless+Headphones",
                        Category = "Electronics"
                    },
                    new ProductViewModel
                    {
                        Id = 2,
                        Name = "Samrt Watches",
                        Price = 199.99m,
                        OldPrice = 249.99m,
                        ImageUrl="https://placehold.co/300x300/f8f9fa/0d6efd?text=Smart+Watch",
                        Category = "Electronics"
                    },
                    new ProductViewModel
                    {
                        Id = 3,
                        Name = "Casual T-Shirt",
                        Price = 24.99m,
                        OldPrice = 34.99m,
                        ImageUrl="https://placehold.co/300x300/f8f9fa/0d6efd?text=Casual+T-Shirt",
                        Category = "Clothing"
                    },
                    new ProductViewModel
                    {
                        Id = 4,
                        Name = "Coffee Maker",
                        Price = 59.99m,
                        OldPrice = 79.99m,
                        ImageUrl="https://placehold.co/300x300/f8f9fa/0d6efd?text=Coffee+Maker",
                        Category = "Home & Kiitchen"
                    },
                };
        }

        private List<ProductViewModel> GetNewArrivals()
        {
            return new List<ProductViewModel>
                {
                    new ProductViewModel
                    {
                        Id = 5,
                        Name = "Premium Headphones",
                        Price = 79.99m,
                        OldPrice = 129.99m,
                        ImageUrl = "https://placehold.co/300x300/f0f0f0/333333?text=Headphones",
                        Category = "Electronics"
                    },
                    new ProductViewModel
                    {
                        Id = 6,
                        Name = "Fitness Smartwatch",
                        Price = 189.99m,
                        OldPrice = 249.99m,
                        ImageUrl = "https://placehold.co/300x300/f0f0f0/333333?text=Smartwatch",
                        Category = "Electronics"
                    },
                    new ProductViewModel
                    {
                        Id = 7,
                        Name = "Designer T-Shirt",
                        Price = 29.99m,
                        OldPrice = 39.99m,
                        ImageUrl = "https://placehold.co/300x300/f0f0f0/333333?text=T-Shirt",
                        Category = "Clothing"
                    },
                    new ProductViewModel
                    {
                        Id = 8,
                        Name = "Smart Coffee Maker",
                        Price = 69.99m,
                        OldPrice = 89.99m,
                        ImageUrl = "https://placehold.co/300x300/f0f0f0/333333?text=Coffee+Maker",
                        Category = "Home & Kitchen"
                    }
                };
        }

        private SpecialOfferViewModel GetSpecialOffer()
        {
            return new SpecialOfferViewModel
            {
                Title = "Special Offers",
                SubTitle = "Limited Time Offer",
                Description = "Get up to 70% off on selected items, limited stock available!",
                ButtonText = "Shop the Sale",
                Category = "sale"
            };
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }




    }
}
