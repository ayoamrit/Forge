using Forge.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Forge.Model;

namespace Forge.Pages
{
    public class IndexModel : PageModel
    {
        private readonly DataContext _dataContext;
        public  IEnumerable<Game> _dbGames { get; set; }

        public IndexModel(DataContext _dataContext)
        {
            this._dataContext = _dataContext;
            _dbGames = _dataContext.Game;
        }

        public void OnGet()
        {

        }
    }
}