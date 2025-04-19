using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Html2ViewsConversion.Models.Products
{
    public class ProductEditViewModel
    {
        public int Id { get; set; }

        // Basic Information
        [Required(ErrorMessage = "Product name is required")]
        [Display(Name = "Product Name")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "SKU is required")]
        [Display(Name = "SKU (Stock Keeping Unit)")]
        public string Sku { get; set; } = string.Empty;

        [Required(ErrorMessage = "Category is required")]
        [Display(Name = "Category")]
        public string CategoryId { get; set; } = string.Empty;

        [Display(Name = "Brand")]
        public string Brand { get; set; } = string.Empty;

        // Image
        [Display(Name = "Product Image")]
        public IFormFile? ImageFile { get; set; }
        public string? ImageUrl { get; set; }

        // Pricing & Inventory
        [Required(ErrorMessage = "Regular price is required")]
        [Display(Name = "Regular Price ($)")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0")]
        public decimal Price { get; set; }

        [Display(Name = "Sale Price ($)")]
        public decimal? SalePrice { get; set; }

        [Display(Name = "Product is on sale")]
        public bool OnSale { get; set; }

        [Display(Name = "Stock Quantity")]
        public int? StockQuantity { get; set; }

        [Display(Name = "Low Stock Threshold")]
        public int? LowStockThreshold { get; set; }

        [Display(Name = "Track inventory for this product")]
        public bool TrackInventory { get; set; } = true;

        // Display Settings
        [Display(Name = "Product is active")]
        public bool IsActive { get; set; } = true;

        [Display(Name = "Feature this product")]
        public bool IsFeatured { get; set; }

        [Display(Name = "Mark as new arrival")]
        public bool IsNew { get; set; }

        // Tags
        [Display(Name = "Product Tags")]
        public string Tags { get; set; } = string.Empty;

        [Display(Name = "Product Weight (kg)")]
        public decimal? Weight { get; set; }

        [Display(Name = "Length (cm)")]
        public decimal? Length { get; set; }

        [Display(Name = "Width (cm)")]
        public decimal? Width { get; set; }

        [Display(Name = "Height (cm)")]
        public decimal? Height { get; set; }

        // Description & Details
        [Display(Name = "Short Description")]
        public string ShortDescription { get; set; } = string.Empty;

        [Display(Name = "Full Description")]
        public string Description { get; set; } = string.Empty;

        [Display(Name = "Key Features")]
        public List<string> Features { get; set; } = new List<string>();

        // For dropdowns
        public IEnumerable<SelectListItem> Categories { get; set; } = new List<SelectListItem>();
    }
}
