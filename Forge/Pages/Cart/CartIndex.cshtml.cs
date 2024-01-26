using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.JSInterop;
using System.Runtime.CompilerServices;

namespace Forge.Pages.Cart
{
    public class CartIndexModel : PageModel
    {
        public double DIGITALTAX { get { return 0.03; }}
        public double totalCost { get; set; }
        private ILogger<CartIndexModel> _logger;
        public CartHandler cartHandler;

        public CartIndexModel(ILogger<CartIndexModel> logger)
        {
            _logger = logger;
            cartHandler = new CartHandler();
        }

        public IActionResult OnGet()
        {
            return Page();
        }
    }
}
