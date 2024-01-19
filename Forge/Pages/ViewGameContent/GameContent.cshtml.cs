using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Forge.Model;

namespace Forge.Pages.ViewGameContent
{
    public class GameContentModel : PageModel
    {
        public IList<Game> gameList { get; set; }
        public string Firstname { get; set; }

        public IActionResult OnGet(IList<Game> gameList)
        {
            this.gameList = gameList;
            return Page();
        }

    }
}
