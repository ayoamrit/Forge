namespace Forge.Model
{
    public class UserLibrary
    {
        public int LibraryID { get; set; }
        public int UserID { get; set; }
        public int GameID { get; set; }
        public int PurchaseID { get; set; }

        public User User { get; set; }
    }
}
