using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dawn_of_reckoning
{
    public class AricThorneStory
    {
        public void Display()
        {
            Console.WriteLine("Aric Thorne\n");
            Console.WriteLine(
                "As I stood atop the ancient battlements of Altdorf, the first light of dawn breaking over the horizon, I felt a sense of purpose wash over me. " +
                "Clad in my family's gleaming armor, the sword at my side a testament to my noble lineage, I knew my destiny was clear. Born into a family of warriors, " +
                "I trained relentlessly, guided by the tales of valor and sacrifice my father shared. Now, the forces of Chaos threaten the very heart of the Empire. " +
                "With unwavering resolve, I lead my comrades into battle, my sense of duty putting me in the forefront of danger. I am Aric Thorne, a beacon of hope " +
                "for my people, ready to defend humanity against the encroaching darkness. \n\n"



            );
            Console.ReadKey();
            Console.Clear();

            ContinueAricThorneStory();
        }

        public static void ContinueAricThorneStory()
        {
            // list of decsisons 
            List<string> Decisions = new()
        {
        "Inspect the Defenses (Explore the city and gain insights about its vulnerabilities.)",
        "Rally the Troops (Boost morale among your comrades.)",
        "Meditate with Stormbreaker (Unlock a vision of the coming battle and the shadowy figure.)"
    };

            string asciiArt = @"



████████╗██╗  ██╗███████╗    ███████╗██╗███████╗ ██████╗ ███████╗     ██████╗ ███████╗     █████╗ ██╗  ████████╗██████╗  ██████╗ ██████╗ ███████╗
╚══██╔══╝██║  ██║██╔════╝    ██╔════╝██║██╔════╝██╔════╝ ██╔════╝    ██╔═══██╗██╔════╝    ██╔══██╗██║  ╚══██╔══╝██╔══██╗██╔═══██╗██╔══██╗██╔════╝
   ██║   ███████║█████╗      ███████╗██║█████╗  ██║  ███╗█████╗      ██║   ██║█████╗      ███████║██║     ██║   ██║  ██║██║   ██║██████╔╝█████╗  
   ██║   ██╔══██║██╔══╝      ╚════██║██║██╔══╝  ██║   ██║██╔══╝      ██║   ██║██╔══╝      ██╔══██║██║     ██║   ██║  ██║██║   ██║██╔══██╗██╔══╝  
   ██║   ██║  ██║███████╗    ███████║██║███████╗╚██████╔╝███████╗    ╚██████╔╝██║         ██║  ██║███████╗██║   ██████╔╝╚██████╔╝██║  ██║██║     
   ╚═╝   ╚═╝  ╚═╝╚══════╝    ╚══════╝╚═╝╚══════╝ ╚═════╝ ╚══════╝     ╚═════╝ ╚═╝         ╚═╝  ╚═╝╚══════╝╚═╝   ╚═════╝  ╚═════╝ ╚═╝  ╚═╝╚═╝     
                                                                                                                                                 


";

            Console.WriteLine(asciiArt);
            // Display the game introduction
            Console.WriteLine("The Empire stands on the brink of annihilation. You, Aric Thorne, must rally the defenders, uncover the secrets of your lineage," +
                              " and wield the ancient power of Stormbreaker to face the oncoming darkness. " +
                              "The choices you make will shape the fate of humanity.\n");

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
            Console.Clear();

            // Update console title for the next section

            Console.WriteLine("CHAPTER 1 \n");

            string asciiArt1 = @"

██████╗  █████╗ ██╗    ██╗███╗   ██╗     ██████╗ ███████╗    ██████╗ ███████╗███████╗████████╗██╗███╗   ██╗██╗   ██╗    
██╔══██╗██╔══██╗██║    ██║████╗  ██║    ██╔═══██╗██╔════╝    ██╔══██╗██╔════╝██╔════╝╚══██╔══╝██║████╗  ██║╚██╗ ██╔╝    
██║  ██║███████║██║ █╗ ██║██╔██╗ ██║    ██║   ██║█████╗      ██║  ██║█████╗  ███████╗   ██║   ██║██╔██╗ ██║ ╚████╔╝     
██║  ██║██╔══██║██║███╗██║██║╚██╗██║    ██║   ██║██╔══╝      ██║  ██║██╔══╝  ╚════██║   ██║   ██║██║╚██╗██║  ╚██╔╝      
██████╔╝██║  ██║╚███╔███╔╝██║ ╚████║    ╚██████╔╝██║         ██████╔╝███████╗███████║   ██║   ██║██║ ╚████║   ██║       
╚═════╝ ╚═╝  ╚═╝ ╚══╝╚══╝ ╚═╝  ╚═══╝     ╚═════╝ ╚═╝         ╚═════╝ ╚══════╝╚══════╝   ╚═╝   ╚═╝╚═╝  ╚═══╝   ╚═╝       
                                                                                                                    
";
            Console.WriteLine(asciiArt1);
            Console.WriteLine("As the first light of dawn breaks over the ancient battlements of Altdorf, you stand clad in your family's armor, its polished surface gleaming with the golden hue of the rising sun." +
                              " Below, the bustling city awakens, unaware of the dark forces gathering beyond its walls." +
                              " Your sword, Stormbreaker, hangs at your side—a relic of your noble lineage and a symbol of hope for your people.\n");

            // Present choices to the player
            Console.WriteLine("What will you do today?");
            for (int i = 0; i < Decisions.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Decisions[i]}");
            }

            // Get player input
            Console.Write("\nEnter the number of your choice: ");
            string option1 = Console.ReadLine();

            // Handle player choice
            switch (option1)
            {
                case "1":
                    Console.WriteLine(
                        "You stride along the battlements, your boots echoing on the cold stone. The air is thick with the scent of damp earth and iron. Soldiers nod as you pass, their faces weary but resolute. Below, the city stirs to life, merchants hurrying to secure their wares while blacksmiths labor tirelessly to forge weapons for the coming battle.\n\n" +
                        "As you examine the gatehouse, you notice cracks in the portcullis mechanism. The soldiers stationed there seem oblivious, their focus entirely on the horizon where the forces of Chaos gather.\n\n" +
                        "You call out to one of the guards, 'Captain, the portcullis mechanism is compromised. Have a team repair it immediately. We cannot afford any weaknesses when the enemy arrives.'\n\n" +
                        "The captain snaps to attention and barks orders to his men. As they begin their work, you feel a presence at your side. Turning, you find the royal advisor.\n\n" +
                        "'Lord Thorne, I have troubling news,' the advisor begins. 'A scout has reported sightings of a Chaos warband moving through the forest. They are closer than we anticipated.'\n\n" +
                        "You nod, steeling yourself for the imminent conflict. 'We must be ready. Gather the commanders. We need a strategy meeting immediately.\n\n"

                    );



                    List<string> NextSteps = new()
                {
                        "Prepare for the Strategy Meeting: Head to the war room and discuss the plan with your commanders.",
                        "Scout the Enemy's Position: Personally lead a reconnaissance mission to gather more information about the approaching warband.",

                    };

                    Console.WriteLine("What do you do next?");
                    for (int i = 0; i < NextSteps.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {NextSteps[i]}");
                    }
                    // Get player input
                    Console.WriteLine("Pick an Option:");
                    string menu1 = Console.ReadLine(); ;
                    // handle user input 
                    switch (menu1)
                    {
                        case "1":
                            DisplayCommandersAroundTable();

                            break;

                        case "2":
                            ScoutEnemies();
                            break;


                        default:
                            Console.WriteLine("Go back to menu");
                            break;

                    }

                    break;

                case "2":
                    Console.WriteLine("\nYou rally your troops, moving through the barracks and addressing your comrades with words of encouragement." +
                                         " You remind them of the strength of the Empire and the courage that flows through their veins.\n");
                    break;

                case "3":
                    Console.WriteLine("\nYou find a quiet place within the keep and draw Stormbreaker from its scabbard. The ancient blade hums faintly in your hands, its light casting shifting patterns on the stone walls." +
                                        " As you meditate, a vision begins to form, showing a shadowy figure and a dire warning of the battle ahead.\n");
                    break;

                default:
                    Console.WriteLine("\nInvalid choice. Please restart and select a valid option.");
                    break;
            }
        }

        static void DisplayCommandersAroundTable()
        {
            string[] frames = new string[]
            {
        @"
        ___________________________
       |                           |
       |       War Room            |
       |___________________________|
            /               \
           /    _____  _____  \
          /    |     ||     |  \
         /_______________________\
        /                         \
       /___________________________\
      /        COMMANDERS          \
     /_____________________________\
    /                               \
   /_________________________________\
",
        @"
        ___________________________
       |                           |
       |       War Room            |
       |___________________________|
            /     _____  _____     \
           /_____/     ||     \_____\
          /     |     ||     |      \
         /___________________________\
        /     _____  _____  _____    \
       /_____/     ||     ||     \____\
      /     |     ||     ||     |     \
     /_______________________________\
    /        COMMANDERS                \
   /____________________________________\
",
        @"
        ___________________________
       |                           |
       |       War Room            |
       |___________________________|
            /   _____  _____   \
           /__/     ||     \__\
          /   |     ||     |   \
         /_______________________\
        /  _____  _____  _____   \
       /__/     ||     ||     \__\
      /   |     ||     ||     |   \
     /___________________________\
    /          COMMANDERS          \
   /______________________________\
",
        @"
        ___________________________
       |                           |
       |       War Room            |
       |___________________________|
            /               \
           /    _____  _____  \
          /    |     ||     |  \
         /_______________________\
        /                         \
       /___________________________\
      /        COMMANDERS          \
     /_____________________________\
    /                               \
   /_________________________________\

   Together, you and your commanders formulate a plan to defend the city and counter the advancing enemy. After the meeting, you feel a renewed sense of purpose and determination.
",
            };

            foreach (var frame in frames)
            {

                Console.WriteLine(frame);
                Thread.Sleep(550); // Adjust the speed of animation
            }


            Console.WriteLine("The battle ahead will be difficult, but you are confident in the strength and resolve of your forces.");
            Console.ReadKey();

            TheReckoningofThrones();
            Console.ReadKey();


        }

        static void ScoutEnemies()
        {
            Console.WriteLine("As you approach the enemy forces, you notice that their numbers are dwindling rapidly." +
             "You begin to gather intel on their weaknesses and vulnerabilities, and your commanders provide you with valuable insights");
            Console.ReadKey();

            Console.WriteLine("Your commanders lead you to a hidden cave entrance, where you can observe the enemy forces closely. They appear to be using stealth and camouflage to blend in, and you quickly become a target." +
                "With a cautious approach, you approach the cave and engage the enemy forces in a close-quarters battle.");
            Console.ReadKey();

        }

        static async void TheReckoningofThrones()

        {
            string art3 = @"
  
  
████████╗██╗  ██╗███████╗    ██████╗ ███████╗ ██████╗██╗  ██╗ ██████╗ ███╗   ██╗██╗███╗   ██╗ ██████╗      ██████╗ ███████╗    ████████╗██╗  ██╗██████╗  ██████╗ ███╗   ██╗███████╗███████╗
╚══██╔══╝██║  ██║██╔════╝    ██╔══██╗██╔════╝██╔════╝██║ ██╔╝██╔═══██╗████╗  ██║██║████╗  ██║██╔════╝     ██╔═══██╗██╔════╝    ╚══██╔══╝██║  ██║██╔══██╗██╔═══██╗████╗  ██║██╔════╝██╔════╝
   ██║   ███████║█████╗      ██████╔╝█████╗  ██║     █████╔╝ ██║   ██║██╔██╗ ██║██║██╔██╗ ██║██║  ███╗    ██║   ██║█████╗         ██║   ███████║██████╔╝██║   ██║██╔██╗ ██║█████╗  ███████╗
   ██║   ██╔══██║██╔══╝      ██╔══██╗██╔══╝  ██║     ██╔═██╗ ██║   ██║██║╚██╗██║██║██║╚██╗██║██║   ██║    ██║   ██║██╔══╝         ██║   ██╔══██║██╔══██╗██║   ██║██║╚██╗██║██╔══╝  ╚════██║
   ██║   ██║  ██║███████╗    ██║  ██║███████╗╚██████╗██║  ██╗╚██████╔╝██║ ╚████║██║██║ ╚████║╚██████╔╝    ╚██████╔╝██║            ██║   ██║  ██║██║  ██║╚██████╔╝██║ ╚████║███████╗███████║
   ╚═╝   ╚═╝  ╚═╝╚══════╝    ╚═╝  ╚═╝╚══════╝ ╚═════╝╚═╝  ╚═╝ ╚═════╝ ╚═╝  ╚═══╝╚═╝╚═╝  ╚═══╝ ╚═════╝      ╚═════╝ ╚═╝            ╚═╝   ╚═╝  ╚═╝╚═╝  ╚═╝ ╚═════╝ ╚═╝  ╚═══╝╚══════╝╚══════╝
                                                                                                                                                                                           

  
  ";

            Console.Clear();
            Console.WriteLine("Your forces have defeated the enemy forces and emerge victorious. The city of Thrones is now safe for all its inhabitants.");
            Console.ReadKey();

            string frames = @"/-\|";

            Console.CursorVisible = false;
            await Animate(frames);

            Console.CursorVisible = true;

            async Task Animate(string frames)
            {
                while (Console.KeyAvailable is false)
                {
                    foreach (var frame in frames)
                    {
                        Console.Write($"{frame}");
                        await Task.Delay(300);
                    }
                }
            }


            Console.WriteLine(art3);
        }


    }
}