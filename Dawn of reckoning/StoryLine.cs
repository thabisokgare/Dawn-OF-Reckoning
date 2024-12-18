using System;
using System.Collections.Generic;

namespace Dawn_of_reckoning
{
    public class StoryLine
    {
        public static void DisplayStoryline(string? select, List<string> players)
        {
            Console.Clear();
            switch (select)
            {
                case "1":
                    AricThorneStory aricThorneStory = new AricThorneStory();
                    aricThorneStory.Display();
                    break;

                case "2":
                    Console.WriteLine($"Welcome: {players[1]}");
                    Console.WriteLine("Walking among the towering spires of Ulthuan, my homeland, I felt the ancient magic coursing through me...");
                    break;

                case "3":
                    Console.WriteLine($"Welcome: {players[2]}");
                    Console.WriteLine("The rhythmic clang of my hammer echoed through the caverns as I worked tirelessly in my forge deep beneath the World's Edge Mountains...");
                    break;

                case "4":
                    Console.WriteLine($"Welcome: {players[3]}");
                    Console.WriteLine("Moving silently through the enchanted forests of Athel Loren, I felt a deep connection to the natural world around me...");
                    break;

                case "5":
                    Console.WriteLine($"Welcome: {players[4]}");
                    Console.WriteLine("The harsh winds of the frozen wastelands of the North whipped through my wild hair as I led my tribe...");
                    break;

                default:
                    Console.WriteLine("Invalid Player");
                    break;
            }
        }

        public static void ShowStoryLine()
        {
            Console.WriteLine("Select your player:");
            Console.WriteLine("1. Aric Thorne");
            Console.WriteLine("2. Elara Moonshadow");
            Console.WriteLine("3. Gorak Stonefist");
            Console.WriteLine("4. Lyria Nightshade");
            Console.WriteLine("5. Grimnar Bloodfang");

            string select = Console.ReadLine();

            List<string> players = new List<string> { "Player1", "Player2", "Player3", "Player4", "Player5" };
            DisplayStoryline(select, players);
        }
    }
}
