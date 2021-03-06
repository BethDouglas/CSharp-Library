﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //NewThis will be used later
            SpeechSynthesizer synth = new SpeechSynthesizer();

            //Prompt for Player Information
            Console.WriteLine("Hi!\n" +
                               "What's your name?");
            string inputName = Console.ReadLine();

            Console.Clear();
            Console.WriteLine($"Glad to meet you, {inputName}.");
            Thread.Sleep(1000);
            Console.WriteLine("\nWhat's your business?\n" +
                "1: Business 1\n" +
                "2: Business 2\n" +
                "3: Business 3\n" +
                "4: Business 4\n" +
                "5: Business 5\n");
                
            //Get Value User Provided
            int inputSpec = Int32.Parse(Console.ReadLine());

            //Perform Explicit Cast from
            //int to Specialization enum type
            Player.Specialization inputSpecialization = (Player.Specialization)inputSpec;

            Console.WriteLine($"Ah ha... a {inputSpecialization}, interesting choice.");

            //Create new Player Object
            Player newHero = new Player(inputName, inputSpecialization);

            Console.Clear();

            Console.WriteLine($"Your journey begins here {newHero.Name}, the {newHero.Role}...");
            Thread.Sleep(2000);
            Console.Clear();

            Console.WriteLine("A shady figure appears...");
            Thread.Sleep(1500);


            Console.WriteLine($"You're going down {newHero.Name}.");
            synth.Speak($"You're going down {newHero.Name}, the {newHero.Role}.");
            Thread.Sleep(1000);

            Enemy robot = new Enemy("Jay", newHero.Level);
            Console.WriteLine("BATTLE INSTANTIATED!");
            synth.Speak("BATTLE INSTANTIATED!");

            //Battle Loop
            while (newHero.IsAlive && robot.IsAlive)
            {
                Console.Clear();
                Console.WriteLine($"{newHero.Name}'s Health: {newHero.Health}\n" +
                                  $"{robot.Name} Health: {robot.Health}\n\n");
                Console.WriteLine("=======================\n" +
                                  "         ACTIONS   \n" +
                                  "=======================");
                Console.Write("0: Attack\n" +
                              "1: Run\n" +
                              "2: Hide\n");
                int inputAction = Int32.Parse(Console.ReadLine());
                Player.Action heroAction = (Player.Action)inputAction;

                //Handle Hero Action
                switch (heroAction)
                {
                    case Player.Action.Attack:
                        //Generate Attacks
                        int heroAttack = newHero.Attack();
                        Thread.Sleep(500);
                        int robotAttack = robot.Attack();

                        //Adjust Health Values
                        newHero.Health -= Convert.ToInt32(robotAttack);
                        robot.Health -= Convert.ToInt32(heroAttack);

                        //Display Attack Stuff in the Console
                        Console.Clear();
                        Console.WriteLine("=======================\n" +
                                         $"{newHero.Name} Deals {heroAttack} to {robot.Name}\n" +
                                          "=======================\n");
                        Thread.Sleep(1000);
                        Console.WriteLine("=======================\n" +
                                         $"{robot.Name} Deals {robotAttack} to {newHero.Name}\n" +
                                          "=======================\n");
                        Thread.Sleep(1500);
                        break;
                    case Player.Action.Run:
                        Console.Clear();
                        Console.WriteLine($"{newHero.Name} attempts to make a run for it!");
                        Thread.Sleep(1500);
                        synth.Speak("Where do you think you're going?!");
                        Console.Clear();
                        Console.WriteLine($"{robot.Name} pulls {newHero.Name} back into the fight!");
                        break;
                    case Player.Action.Hide:
                        Console.Clear();
                        Console.WriteLine($"{newHero.Name} attempts to hide...");
                        Thread.Sleep(1500);
                        synth.Speak($"You can't hide from me {newHero.Role}");
                        Console.Clear();
                        Console.WriteLine($"{robot.Name} found {newHero.Name}!");
                        break;
                    default:
                        Console.WriteLine("Enter 0, 1, or 2 to perform an action!");
                        synth.Speak("I know I make computers slow, but this is just ridiculous!");
                        Thread.Sleep(2000);
                        break;
                }


                //Check to see if Anyone is Dead
                if (newHero.Health < 0)
                {
                    newHero.IsAlive = false;
                    Thread.Sleep(2000);
                    Console.Clear();
                    Console.WriteLine($"{robot.Name} has defeated {newHero.Name}!");
                    Thread.Sleep(1000);
                    synth.Speak("Defeating you was exclamation mark difficult. hahahahahahah.");
                }
                if (robot.Health < 0)
                {
                    robot.IsAlive = false;
                    Thread.Sleep(2000);
                    Console.WriteLine($"{newHero.Name} has defeated {robot.Name}!");
                    Thread.Sleep(1000);
                    synth.Speak("What!?!?! NOOOOOOOOOOOOOOOO!");
                }
            }
            Console.ReadLine();
        }
    }
}
