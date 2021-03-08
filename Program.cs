using System;

namespace bankHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");

            Console.WriteLine("Let's register your team. What is a team player's name?");
            string nameInput = Console.ReadLine();

            Console.WriteLine($"Great! What is {nameInput}'s skill level?");
            string skillLevelInput = Console.ReadLine();
            int skillLevel = Int32.Parse(skillLevelInput);

            Console.WriteLine($"And what is {nameInput}'s courage factor (on a scale of 0.0 to 2.0)?");
            string CourageFactorInput = Console.ReadLine();
            double CourageFactor = Int32.Parse(CourageFactorInput);

            Console.WriteLine($"Team Member: {nameInput}");
            Console.WriteLine($"Skill Level: {skillLevel}");
            Console.WriteLine($"Courage Factor: {CourageFactor}");
        }
    }
}
