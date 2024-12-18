using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace Dawn_of_reckoning
{
    public class Game
    {
        public void Start()
        {
            LoadingAnimation();
            Title = "WarHammer Dawn of Reckoning";
            RunmainMenu();
        }

        public void LoadingAnimation()
        {
            int width = WindowWidth;
            int height = WindowHeight;
            for (int i = 1; i <= 100; i++)
            {
                Clear();
                // Calculate padding for centering 
                int paddingLeft = (width / 2) - 10;
                // Adjust the value '10' based on your text length
                int paddingTop = height / 2;
                for (int j = 0; j < paddingTop; j++)
                {
                    WriteLine();
                }
                WriteLine($"{new string(' ', paddingLeft)}Loading... {i}%");
                Thread.Sleep(200);
                // Adjust the delay as needed 
            }
            Clear();
            WriteLine($"{new string(' ', width / 2 - 10)}Loading complete!");
            Thread.Sleep(1000);
            // Hold for a moment after completion 
        }

        private void RunmainMenu()
        {
            string prompt = @"
            

    ________  ________  ___       __   ________           ________  ________      ________  _______   ________  ___  __    ________  ________   ___  ________   ________         
    |\   ___ \|\   __  \|\  \     |\  \|\   ___  \        |\   __  \|\  _____\    |\   __  \|\  ___ \ |\   ____\|\  \|\  \ |\   __  \|\   ___  \|\  \|\   ___  \|\   ____\        
    \ \  \_|\ \ \  \|\  \ \  \    \ \  \ \  \\ \  \       \ \  \|\  \ \  \__/     \ \  \|\  \ \   __/|\ \  \___|\ \  \/  /|\ \  \|\  \ \  \\ \  \ \  \ \  \\ \  \ \  \___|        
    \ \  \ \\ \ \   __  \ \  \  __\ \  \ \  \\ \  \       \ \  \\\  \ \   __\     \ \   _  _\ \  \_|/_\ \  \    \ \   ___  \ \  \\\  \ \  \\ \  \ \  \ \  \\ \  \ \  \  ___      
    \ \  \_\\ \ \  \ \  \ \  \|\__\_\  \ \  \\ \  \       \ \  \\\  \ \  \_|      \ \  \\  \\ \  \_|\ \ \  \____\ \  \\ \  \ \  \\\  \ \  \\ \  \ \  \ \  \\ \  \ \  \|\  \     
    \ \_______\ \__\ \__\ \____________\ \__\\ \__\       \ \_______\ \__\        \ \__\\ _\\ \_______\ \_______\ \__\\ \__\ \_______\ \__\\ \__\ \__\ \__\\ \__\ \_______\    
        \|_______|\|__|\|__|\|____________|\|__| \|__|        \|_______|\|__|         \|__|\|__|\|_______|\|_______|\|__| \|__|\|_______|\|__| \|__|\|__|\|__| \|__|\|_______|    
                                                                                                                        
                                                                                                                    
            ";
            string[] options = { "Play", "About", "Exit" };

            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            ReadKey(true);

            switch (selectedIndex)
            {
                case 0:
                    StoryLine.ShowStoryLine();
                    break;

                case 1:
                    Clear();
                    DisplayAboutInfo();
                    break;
                case 2:
                    ExistGame();
                    break;



            }
        }

        private void ExistGame()
        {
            WriteLine("\n Press any key to exist");
            ReadKey(true);
            Environment.Exit(0);
        }

        private void DisplayAboutInfo()
        {
            WriteLine("## How to Play Warhammer: The Dawn of Reckoning\n");

            WriteLine("Embark on an epic journey through a world filled with mystery, magic, and relentless battles. Here’s a quick guide to get you started:\n");

            WriteLine("### Getting Started\n");
            WriteLine("1. **Loading Screen**: Watch the loading animation as the game sets up. Once done, you'll see a welcome message along with some impressive ASCII art.\n");
            WriteLine("2. **Introduction**: The game begins with an introduction to the world of Warhammer, where you'll learn about the factions and the overarching conflict.\n");

            WriteLine("### Selecting Your Character\n");
            WriteLine("3. **Choose Your Hero**: You'll be presented with a list of heroes to choose from. Each hero has a unique backstory and set of skills:\n");
            WriteLine("   - Aric Thorne: A noble warrior.\n   - Elara Moonshadow: A powerful sorceress.\n   - Gorak Stonefist: A master engineer.\n   - Lyria Nightshade: A skilled archer and tracker.\n   - Grimnar Bloodfang: A fierce tribal leader.\n");

            WriteLine("4. **Make Your Choice**: Type the number corresponding to the hero you want to play as and hit Enter.\n");

            WriteLine("### Playing the Game\n");
            WriteLine("5. **Experience the Story**: As you journey through the game, you'll be presented with various scenarios and options. Your choices will determine the direction of the story and the fate of your hero.\n");
            WriteLine("6. **Decision-Making**: Read through the dialogues and descriptions carefully. When prompted, select from the available options by typing your choice and pressing Enter.\n");

            WriteLine("### Tips for Success\n");
            WriteLine("- **Think Strategically**: Every decision you make will impact your journey. Consider the strengths and weaknesses of your hero and choose wisely.\n");
            WriteLine("- **Embrace the Role**: Immerse yourself in the character’s story, make decisions as if you were them, and enjoy the immersive narrative.\n");
            WriteLine("- **Explore & Learn**: Pay attention to the details in the story, as they might provide clues and insights that can help you in your quest.\n");

            WriteLine("### Example Scenario\n");
            WriteLine("*As Aric Thorne stands on the battlements of Altdorf, he sees a shadowy figure in the distance. What should he do?*\n");
            WriteLine("1. Investigate the figure.\n2. Call for reinforcements.\n3. Ignore and continue preparations.\n");
            WriteLine("Type the number of your choice and press Enter to continue the adventure.\n");

            Write("\n Press ANY KEY TO RETURN TO MENU");
            ReadKey(true);

            RunmainMenu();

        }

        
    }
}
