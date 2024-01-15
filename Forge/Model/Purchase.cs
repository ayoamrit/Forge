namespace Forge.Model
{
    public class Purchase
    {
        public int PurchaseID { get; set; }
        public int UserID { get; set; }
        public int GameID { get; set; }
        public DateTime PurchaseDate { get; set; }

        public Game Game { get; set; }
        public User User { get; set; }
    }
}
