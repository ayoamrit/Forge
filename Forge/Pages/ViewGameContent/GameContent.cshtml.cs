using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Forge.Model;
using Microsoft.Identity.Client;
using Forge.Data;
using Forge.Pages.Cart;
using Microsoft.JSInterop;
using Forge.ExceptionHandler;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Forge.Pages.ViewGameContent
{
    public class GameContentModel : PageModel
    {
        //Properties representing the details of a game
        public int GameID { get; set; }
        public string GameTitle { get; set; } = String.Empty;
        public string GameDescription { get; set; } = String.Empty;
        public double GamePrice { get; set; }
        public string GameBackgroundImage { get; set; } = String.Empty;
        public string GameCoverImage { get; set; } = String.Empty;
        public string GameVideoClip { get; set; } = String.Empty;

        //Data context and handler instances
        private DataContext _dataContext;
        public CartHandler cartHandler;
        public SystemRequirement systemRequirement { get; set; }
        public Random random;
        private readonly ILogger<GameContentModel> _logger;

        //Init constructor
        public GameContentModel(DataContext _dataContext, ILogger<GameContentModel> logger)
        {
            this._dataContext = _dataContext;
            this._logger = logger;
            cartHandler = new CartHandler();
            random = new Random();
        }

        //Handles HTTP GET requests for displaying game content
        public IActionResult OnGet(int GameID)
        {
            this.GameID = GameID;
            try
            {
                SetProperties();  //Set properties based on the specified GameID
            }catch(IndexOutOfRange ex)
            {
                //Log an error message for IndexOutOfRange Exception
                _logger.LogError("An error occurred: IndexOutOfBound");

                //Log an information message for IndexOutOfRange Exception
                _logger.LogInformation("IndexOutOfBound: Redirecting to the error page");

                //Store custom error information in TempData for the error page
                TempData["CustomErrorHeading"] = "Index Out Of Range";
                TempData["CustomErrorMessage"] = $"{ex.Message}";

                //Redirect to the error page
                return RedirectToPage("/Error");
            }
            catch(Exception ex)
            {
                //Log an error message for Unexpected Exception
                _logger.LogError("An error occurred: Unexpected error occurred");
                //Log an information message for Unexpected Exception
                _logger.LogInformation("Unexpected Exception: Redirecting to the error page");

                //Store custom error information in TempData for the error page
                TempData["CustomExceptionHeading"] = "Unexpected Error Occurred";
                TempData["CustomErrorMessage"] = $"{ex.Message}";

                //Redirect to the error page
                return RedirectToPage("/Error");
            }
            
            
            return Page();  //Render the Razor page
        }

        //Helper method to set properties based on the GameID
        private void SetProperties()
        {
            try
            {
                //Retrieve game details and set properties
                this.GameTitle = _dataContext.Games.ToList()[GameID - 1].Title;
                this.GameDescription = _dataContext.Games.ToList()[GameID - 1].Description;
                this.GamePrice = (double)_dataContext.Games.ToList()[GameID - 1].Price;
                this.GameBackgroundImage = $"https://raw.githubusercontent.com/ayoamrit/Forge/main/Forge/Resources/Cover/{GameID}c.jpg";
                this.GameCoverImage = _dataContext.Games.ToList()[GameID - 1].ImagePath;
                this.GameVideoClip = $"https://raw.githubusercontent.com/ayoamrit/Forge/main/Forge/Resources/play.mp4";

                //Retrieve system requirements for the game
                this.systemRequirement = _dataContext.SystemRequirements.ToList()[GameID - 1];
            }catch(ArgumentOutOfRangeException ex)
            {
                throw new IndexOutOfRange("The index that you are trying to reach does not exist in the current context");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        //Function to add the current game to the cart
        [JSInvokable]
        public bool AddToCart()
        {
            try
            {
                return cartHandler.AddItem(GameID, GameTitle, GamePrice);
            }
            catch (Exception)
            {
                _logger.LogError("An error occurred: Adding selected game to the cart");
                _logger.LogInformation("Redirecting to the error page");

                TempData["CustomErrorHeading"] = "Add to Cart Exception";
                TempData["CustomErrorMessage"] = "The selected item is not being added to the cart due to an unexpected error. " +
                    "We apologize for the inconvenience and will get back to you as soon as possible";
                RedirectToPage("/Error");

            }

            return false;
            
        }
    }
}
