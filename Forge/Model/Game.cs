namespace Forge.Model
{
    public class Game
    {
        public int GameID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImagePath { get; set; }

        //A game can be associated with multiple purchases, and a purchase belongs to one game.
        public ICollection<Purchase> Purchases { get; set; }
        public SystemRequirement SystemRequirement { get; set; }
    }
}
