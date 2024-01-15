namespace Forge.Model
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //A user can make multiple purchases, and each purchase belongs to one user.
        public ICollection<Purchase> Purchases { get; set; }

        //A user can have multiple games in their library, and each game in the library belongs to one user
        public ICollection<UserLibrary> UserLibraries { get; set; }
    }
}
