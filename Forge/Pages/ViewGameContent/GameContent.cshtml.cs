using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Forge.Model;
using Microsoft.Identity.Client;
using Forge.Data;

namespace Forge.Pages.ViewGameContent
{
    public class GameContentModel : PageModel
    {
        public int GameID { get; set; }
        public string GameTitle { get; set; } = String.Empty;
        public string GameDescription { get; set; } = String.Empty;
        public double GamePrice { get; set; }
        public string GameBackgroundImage { get; set; } = String.Empty;
        public string GameCoverImage { get; set; } = String.Empty;
        private DataContext _dataContext;

        public GameContentModel(DataContext _dataContext)
        {
            this._dataContext = _dataContext;
        }

        public IActionResult OnGet(int GameID)
        {
            this.GameID = GameID;
            SetProperties();


            return Page();
        }

        private void SetProperties()
        {
            this.GameTitle = _dataContext.Games.ToList()[GameID - 1].Title;
            this.GameDescription = _dataContext.Games.ToList()[GameID - 1].Description;
            this.GamePrice = (double) _dataContext.Games.ToList()[GameID - 1].Price;
            this.GameBackgroundImage = $"https://raw.githubusercontent.com/ayoamrit/Forge/main/Forge/Resources/Cover/{GameID}c.jpg";
            this.GameCoverImage = _dataContext.Games.ToList()[GameID - 1].ImagePath;
        }

    }
}
