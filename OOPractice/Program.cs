using System;

namespace OOPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Character CharSample = new Character(25, 25, "John Doe", "Oficinista");
            Hero CharHero = new Hero(50, 50, "Great John", "Paladín");

            Console.WriteLine(CharSample.CharacterName);
            Console.WriteLine(CharHero.ClassName);

            CharSample.Attack();
            CharHero.Attack();
            CharSample.Parry();
            CharHero.Parry();
            CharHero.CastBuff();

            Console.ReadKey();

        }
    }
}
