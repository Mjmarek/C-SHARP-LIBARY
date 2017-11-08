using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _0._11_OOP_GameBuildAlong
{
    class Program
    {
        static void Main(string[] args)
        {
            //This will be used later
            SpeechSynthesizer synth = new SpeechSynthesizer();

            //Prompt for player information
            Console.WriteLine("Hello, wanderer...\n" +
                              "What be thy name?");
            string inputName = Console.ReadLine();

            Console.Clear();

            Console.WriteLine(string.Format("Nice to meet you, {0}.", inputName));
            Thread.Sleep(1000);
            Console.WriteLine("\nWhat's your specialization, friend?\n" +
                "0: Horse Mange\n" +
                "1: Troll Cat\n" +
                "2: Knight Templator\n" +
                "3: Demogorg\n" +
                "4: Vampire\n" +
                "5: Bovine Frog");
            //Get value user provided
            int inputSpec = Int32.Parse(Console.ReadLine());

            //Perform explicit cast from int to Specialization enum type
            Player.Specialization inputSpecialization = (Player.Specialization)inputSpec;

            //if user enters 0-5, print this line; else print
            //"Please select a specialization from the list provided."
            Console.WriteLine(string.Format("Ahh... a {0}, an interesting choice.", inputSpecialization));
            Thread.Sleep(2000);

            //Create new Player object
            Player hero = new Player(inputName, inputSpecialization);

            Console.Clear();

            Console.WriteLine(string.Format("Your journey begins here {0}, the {1}!", hero.Name, hero.Role));
            Thread.Sleep(2000);
            Console.Clear();

            Console.WriteLine("A shady figure appears...");
            Thread.Sleep(1500);

            Console.WriteLine(string.Format("You're going down, {0}!", hero.Name));
            synth.Speak(string.Format("You're going down {0}, the {1}", hero.Name, hero.Role));
            Thread.Sleep(1000);

            Enemy robot = new Enemy("Dark Wizard", hero.Level);
            Console.WriteLine("BATTLE INITIATED!");
            synth.Speak("BATTLE INITIATED!");

            //Battle Loop
            while(hero.IsAlive && robot.IsAlive)
            {
                Console.Clear();
                Console.WriteLine(string.Format("{0}'s Health: {1}\n", hero.Name, hero.Health) +
                                  string.Format("{0}'s Health: {1}\n\n", robot.Name, robot.Health));
                Console.WriteLine("=======================\n" +
                                  "         ACTIONS   \n" +
                                  "=======================");
                Console.Write("0: Attack\n" +
                              "1: Run\n" +
                              "2: Hide\n");
                int inputAction = Int32.Parse(Console.ReadLine());
                Player.Action heroAction = (Player.Action)inputAction;

                //Handle hero action
                switch (heroAction)
                {
                    case Player.Action.Attack:
                        //Generate attacks
                        int heroAttack = hero.Attack();
                        int robotAttack = robot.Attack();
                        //Adjust health values
                        hero.Health -= robotAttack;
                        robot.Health -= heroAttack;

                        //Display attack stuff in the console
                        Console.Clear();
                        Console.WriteLine("=====================================\n" +
                                         string.Format("{0} Deals {1} to {2}\n", hero.Name, heroAttack, robot.Name) +
                                          "=====================================\n");
                        Thread.Sleep(1000);
                        Console.WriteLine("=====================================\n" +
                                         string.Format("{0} Deals {1} to {2}\n", robot.Name, robotAttack, hero.Name) +
                                          "=====================================\n");
                        Console.WriteLine(robot.Taunt(hero.Health));
                        synth.Speak(robot.Taunt(hero.Health));
                        Thread.Sleep(1000);
                        break;
                    case Player.Action.Run:
                        Console.Clear();
                        Console.WriteLine(string.Format("{0} attempts to make a run for it!", hero.Name));
                        Thread.Sleep(1500);
                        synth.Speak("Where do you think you're going?!");
                        Console.Clear();
                        Console.WriteLine(string.Format("{0} pulls {1} back into the fight!", robot.Name, hero.Name));
                        Thread.Sleep(2000);
                        break;
                    case Player.Action.Hide:
                        Console.Clear();
                        Console.WriteLine(string.Format("{0} attempts to hide...", hero.Name));
                        Thread.Sleep(1500);
                        synth.Speak(string.Format("You can't hide from me {0}", hero.Role));
                        Console.Clear();
                        Console.WriteLine(string.Format("{0} found {1}!", robot.Name, hero.Name));
                        Thread.Sleep(2000);
                        break;
                    default:
                        Console.WriteLine("Enter 0, 1, or 2 to perform an action!");
                        synth.Speak("I know I make computers slow, but this is just ridiculous!");
                        Thread.Sleep(2000);
                        break;
                }

                //Check to see if anoyone is dead
                if (robot.Health <= 0)
                {
                    robot.IsAlive = false;
                    Thread.Sleep(2000);
                    Console.WriteLine(string.Format("{0} has defeated {1}!", hero.Name, robot.Name));
                    Thread.Sleep(1000);
                    synth.Speak("What!?!?! NOOOOOOOOOOOOOOOO!");
                    break;
                }

                if (hero.Health <= 0)
                {
                    hero.IsAlive = false;
                    Thread.Sleep(2000);
                    Console.Clear();
                    Console.WriteLine(string.Format("{0} has defeated {1}!", robot.Name, hero.Name));
                    Thread.Sleep(1000);
                    synth.Speak("Defeating you was exclamation mark difficult. Hahahahahaha.");
                }

            }Console.ReadLine();

        }
    }
}
