using Forge.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Forge.Model;

namespace Forge.Pages
{
    public class IndexModel : PageModel
    {
        private readonly DataContext _dataContext;
        public  IList<Game> _dbGames { get; set; }
        public string[] gameCardsHeading { get; set; } = { "Featured", "Top Sellers", "Most Played" };

        public IndexModel(DataContext _dataContext)
        {
            this._dataContext = _dataContext;
        }

        public void OnGet()
        {
            _dbGames = _dataContext.Games.ToList();
        }
    }
}