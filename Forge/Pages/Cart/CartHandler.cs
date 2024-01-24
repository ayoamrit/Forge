using System.Reflection.Metadata.Ecma335;

namespace Forge.Pages.Cart
{
    public class CartHandler
    {

        public class CartList
        {
            public static IList<CartHandler> ItemList = new List<CartHandler>();
        }


        //Properties for game details
        public int GameID { get; set; }
        public string GameTitle { get; set; }
        public double GamePrice { get; set; }


        //Method to add an item to the cart
        public bool AddItem(int gameId, string gameTitle, double gamePrice)
        {
            //check if the item with the given GameId already exists in the cart
            if (Exist(gameId))
            {
                //Item already exists in the cart
                return false;
            }

            //Create a new CartHandler object with the provided details
            CartList.ItemList.Add(new CartHandler() {GameID = gameId, GameTitle = gameTitle, GamePrice = gamePrice});
            return true;
            
        }

        //Function to check if an item already exists in the list or not 
        public bool Exist(int gameId)
        {
            //Iterate through each item in the cart
            for(int x = 0; x < CartList.ItemList.Count; x++)
            {
                if (CartList.ItemList[x].GameID == gameId)
                {
                    return true;
                }
            }

            //Return false if an item does not exist in the cart
            return false;
        }
    }
}
