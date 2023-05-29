using LegendsKombat.Characters;
using LegendsKombat.Factories;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        CharacterFactory factory = new AlchemistFactory();
        Character alchemist = factory.CreateCharacter("Merlin");

        factory = new SorceressFactory();
        Character sorceress = factory.CreateCharacter("Morgana");

        factory = new BarbarianFactory();
        Character barbarian = factory.CreateCharacter("Mordred");

        // User chooses characters who fight
        Console.WriteLine("Select two characters to fight:");
        Console.WriteLine("1. Alchemist");
        Console.WriteLine("2. Sorceress");
        Console.WriteLine("3. Barbarian");

        // Input the choices
        int firstChoice = GetUsersCharChoice("Enter the number of the first character: ");
        int secondChoice = GetUsersCharChoice("Enter the number of the second character: ");

        Character charFirst = GetCharacter(firstChoice);
        Character charSecond = GetCharacter(secondChoice);

        Console.WriteLine();
        Console.WriteLine($"A fight between {charFirst.Name} and {charSecond.Name} begins!");

        // Perform Fight 
        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine();
            Console.WriteLine($"Round {i}:");
            Console.WriteLine("------------------------------");

            Console.WriteLine("Press any key to make the first character perform a move...");
            Console.ReadKey();
            PerformMove(charFirst, charSecond);

            Console.WriteLine("Press any key to make the second character perform a move...");
            Console.ReadKey();
            PerformMove(charSecond, charFirst);
        }

        Console.WriteLine();
        Console.WriteLine($"The fight between {charFirst.Name} and {charSecond.Name} is over!");

        // Get the winner
        Character winner = DetermineWinner(charFirst, charSecond);
        if (winner != null)
        {
            Console.WriteLine();
            Console.WriteLine($"The winner is: {winner.Name} with a score of {winner.Score}");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("It's a tie!");
        }
    }

    public static int GetUsersCharChoice(string prompt)
    {
        int choice;
        bool isValidChoice;

        do
        {
            Console.Write(prompt);
            isValidChoice = int.TryParse(Console.ReadLine(), out choice);
            if (!isValidChoice || choice < 1 || choice > 3)
            {
                Console.WriteLine("Invalid character choice. Please try again.");
            }
        }
        while (!isValidChoice || choice < 1 || choice > 3);

        return choice;
    }

    public static Character GetCharacter(int choice)
    {
        CharacterFactory factory;
        switch (choice)
        {
            case 1:
                factory = new AlchemistFactory();
                return factory.CreateCharacter("Merlin");

            case 2:
                factory = new SorceressFactory();
                return factory.CreateCharacter("Morgana");

            case 3:
                factory = new BarbarianFactory();
                return factory.CreateCharacter("Mordred");

            default:
                throw new ArgumentException("Invalid character choice.");
        }
    }

    public static void PerformMove(Character attacker, Character defender)
    {
        Random random = new Random();
        int move = random.Next(1, 4);

        Console.WriteLine($"{attacker.Name} is making a move...");

        switch (move)
        {
            case 1:
                attacker.Attack(defender);
                Console.WriteLine($"{attacker.Name} attacked {defender.Name}!");
                break;

            case 2:
                attacker.Defend();
                Console.WriteLine($"{attacker.Name} is defending!");
                break;

            case 3:
                attacker.UseSpecialAbility(defender);
                Console.WriteLine($"{attacker.Name} used a special ability on {defender.Name}!");
                break;
        }
    }

    public static Character DetermineWinner(Character charFirst, Character charSecond)
    {
        if (charFirst.Score > charSecond.Score)
        {
            return charFirst;
        }
        else if (charSecond.Score > charFirst.Score)
        {
            return charSecond;
        }
        else
        {
            return null;
        }
    }
}
