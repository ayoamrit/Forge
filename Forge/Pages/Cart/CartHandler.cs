namespace Forge.Pages.Cart
{
    public class CartHandler
    {
        private static HashSet<int> ItemSet = new HashSet<int>();
        public static HashSet<int> _itemSet { get { return ItemSet; } }

        public bool AddItem(int gameId)
        {
            return ItemSet.Add(gameId);
        }

        public bool Exist(int gameId)
        {
            return ItemSet.Contains(gameId);
        }
    }
}
