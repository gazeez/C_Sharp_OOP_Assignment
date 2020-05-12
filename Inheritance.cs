using System;

namespace inheritance
{
    class Painting
    {
        public string PaintingName = "GAME OF ARTS";
        public void greet()
        {
            Console.WriteLine("Welcome Back!");
        }
    }

    class User : Painting
    {
        public string userName = "Jungle";
        public string userArtist = "Justice";
        public string userMedium = "Africanized";
        public string userYear = "2020";
    }
    class Program
    {
        static void Main(string[] args)
        {
            User newUser = new User();
            newUser.greet();
            Console.WriteLine(newUser.userName + " is a member of " + newUser.PaintingName);
            Console.WriteLine("AKA " + newUser.userArtist + ".");
            Console.WriteLine("Mode is " + newUser.userMedium + " medium");
            Console.WriteLine("Style of Arts released in " + newUser.userYear + ".");
        }
    }
}
