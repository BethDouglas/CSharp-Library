﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _0._011_OOPGameBuildAlong
{
    class Program
    {
        static void Main(string[] args)
        {
            //This will be used later
            SpeechSynthesizer synth = new SpeechSynthesizer();

            //Prompt for Player Information
            Console.WriteLine("Hello, person...\n" + 
                               "What's your name?");
            string inputName = Console.ReadLine();

            Console.Clear();
            Console.WriteLine($"Nice to meet you, {inputName}.");
            Thread.Sleep(1000);
            Console.WriteLine("\nWhat's your busniess?\n" +
                "1: Business 1\n" +
                "2: Business 2\n" +
                "3: Business 3\n" +
                "4: Business 4\n" +
                "5: Not your's, Inc.\n");
            //Get Value User Provided
            int inputSpec = Int32.Parse(Console.ReadLine());

            //Perform Explicit Cast from
            //int to Specialization enum type
            Player.Specialization inputSpecialization = (Player.Specialization)inputSpec;

            Console.WriteLine($"Ah ha {inputSpecialization}, an interesting choice.");

            //Create new Player Object
            Player newHero = new Player(inputName, inputSpecialization);

            Console.Clear();

            Console.WriteLine($"Your adventure begins here {newHero.Name}, the {newHero.Role}...");
            Thread.Sleep(2000);
            Console.Clear();

            Console.WriteLine("A shady figure appears...");
            Thread.Sleep(1500);


            Console.WriteLine($"You're going down {newHero.Name}.");
            synth.Speak($"You're going down {newHero.Name}, the {newHero.Role}.");
            Thread.Sleep(1000);

            Enemy robot = new Enemy("Bad Guy", newHero.Level);
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
                              "1: Head Butt\n" +
                              "2: Ear Box\n");
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
                    case Player.Action.HeadButt:
                        Console.Clear();
                        Console.WriteLine($"{newHero.Name} head butts {robot.Name}");
                        Thread.Sleep(1500);
                        synth.Speak("Ouch?!");
                        Console.Clear();
                        Console.WriteLine($"{robot.Name} falls down");
                        break;
                    case Player.Action.EarBox:
                        Console.Clear();
                        Console.WriteLine($"{newHero.Name} attempts to box {robot.Name}'s ears");
                        Thread.Sleep(1500);
                        synth.Speak($"That was mean, {newHero.Role}");
                        Console.Clear();
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
