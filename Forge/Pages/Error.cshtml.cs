using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace Forge.Pages
{
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    [IgnoreAntiforgeryToken]
    public class ErrorModel : PageModel
    {
        public string? Heading { get; set; }
        public string? Message { get; set; }


        private readonly ILogger<ErrorModel> _logger;

        public ErrorModel(ILogger<ErrorModel> logger)
        {
            _logger = logger;
        }


        public IActionResult OnGet()
        {
            Heading = TempData["CustomErrorHeading"] as string;
            Message = TempData["CustomErrorMessage"] as string;
            return Page();
        }
    }
}