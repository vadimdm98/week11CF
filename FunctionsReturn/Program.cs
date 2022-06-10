using System;

namespace FunctionsReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] heroes = { "Harry Potter", "Luke Skywalker", "Superman", "Biblo Baggins", "Lara Croft" };
            string[] villains = { "Voldermort", "Darth Vader", "Sauron", "Joker", "Harley Quinn" };
            string[] weapon = { "plastic fork", "banana", "magic wand", "flip-flop", "sharp mind" };

            string hero = GetRandomValueFromArray(heroes);
            string villain = GetRandomValueFromArray(villains);

            string heroWeapon = GetRandomValueFromArray(weapon);
            string villainWeapon = GetRandomValueFromArray(weapon);

            int heroHP = GenerateHP(heroes);
            int villainHP = GenerateHP(villains);

            Console.WriteLine($"{hero}: {heroHP} HP will fight {villain}: {villainHP} HP.");
            Console.WriteLine($"{hero}: will fight with {heroWeapon}.");
            Console.WriteLine($"{villain}: will fight with {villainWeapon}.");

            while (heroHP > 0 && villainHP > 0)
            {
                heroHP = heroHP - Hit(villain, villainWeapon);
                villainHP = villainHP - Hit(hero, heroWeapon);
            }


            if (heroHP <= 0)
            {
                Console.WriteLine("Dark Side wins!");
            }
            else
            {
                Console.WriteLine($"{hero} saves the day!");
            }

        }

        public static string GetRandomValueFromArray(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            return someArray[randomIndex];
        }

        public static int GenerateHP(string[] characterName)
        {
            Random rnd = new Random();
            int randomHP = rnd.Next(0, characterName.Length + 1);
            return randomHP;
        }

        public static int Hit(string characterName, string weapon)
        {
            Random rnd = new Random();
            int strike = rnd.Next(0, weapon.Length + 1);

            if(strike == 0)
            {
                Console.WriteLine($"Oops. {characterName} missed the target.");
            }
            else if(strike == weapon.Length + 1)
            {
                Console.WriteLine($"Awesome. {characterName} make a CRITICAL HIT.");
            }else
            {
                Console.WriteLine($"{characterName} hit {strike}.");
            }

            return strike;
        }
    }
}
