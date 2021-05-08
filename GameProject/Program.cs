using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, BirthYear = 1999, FirstName = "BÜŞRA", LastName = "ŞAHİN", IdentityNumber = 123456 });
        }
    }
}
