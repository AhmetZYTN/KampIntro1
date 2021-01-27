using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, BirtYear = 1985, FirstName = "engin", Lastname = "Demiroğ", IdentityNumber = 12345 });
            Console.WriteLine("j j!");
        }
    }
}
