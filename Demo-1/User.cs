
namespace Demo_1
{
    // Base class: shared user information
    class User
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public void DisplayUser()
        {
            Console.WriteLine("\nLogged in as: " + Username);
        }
    }
}
