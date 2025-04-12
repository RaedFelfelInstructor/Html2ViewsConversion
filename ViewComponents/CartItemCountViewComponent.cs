using Microsoft.AspNetCore.Mvc;

namespace Html2ViewsConversion.ViewComponents
{
    public class CartItemCountViewComponent : ViewComponent
    {
        public CartItemCountViewComponent() { }

        public Task<IViewComponentResult> InvokeAsync()
        {
            int cartItemCount = 0;
            return Task.FromResult<IViewComponentResult>(
                Content(cartItemCount.ToString()));
        }
    }
}
