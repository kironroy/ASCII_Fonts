using System;
using System.Globalization;
using System.Collections.Generic;

namespace AdventureGame2
{
    public static class Game
    {
        static bool run = true;
        static int choice;
        static string input;
        static bool goal = false;

        public static void Start()
        {
            Console.Clear();
            Console.WriteLine("Adventure Game");

            Console.WriteLine("introductory text to outline a goal");
            Console.WriteLine("press enter to continue");
            Console.ReadKey();

        }

        public static void End()
        {
            if (goal)
            {
                Console.WriteLine("Success!");

                Console.WriteLine("Press enter to continue...");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Try again!");

                Console.WriteLine("Press enter to continue...");
                Console.ReadLine();
                run = true;
                Play();
            }

        }

        public static void Play()
        {
            Start();
                while (run == true)
                {
                    Menu();
                }
            End();

        }

        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("1) A 2) B 3) C 4) D 5) Exit");
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 5)
            {
                run = false;
            }
            else
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("A content...");
                        //content here....
                        Console.WriteLine("Press enter to continue...");
                        Console.ReadLine();
                        break;

                    case 2:
                        Console.WriteLine("B content...");
                        //content here....
                        Console.WriteLine("Press enter to continue...");
                        Console.ReadLine();
                        break;

                    case 3:
                        Console.WriteLine("C content...");
                        //content here....
                        Console.WriteLine("Press enter to continue...");
                        Console.ReadLine();
                        break;

                    case 4:
                        Console.WriteLine("D content...");
                        //content here....
                        Console.WriteLine("Press enter to continue...");
                        Console.ReadLine();
                        break;
                    default:
                        input = Console.ReadLine();
                        if (int.TryParse(input, out choice))
                        {
                            if (choice >= 5)
                            {
                                run = false;
                            }
                            else
                            {
                                //switch statement here
                            }
                        }
                        else
                        {
                            Console.WriteLine("Please enter a number 1-5.");
                            Console.WriteLine("Press enter to continue...");
                            Console.ReadLine();
                            Menu();
                        }
                        break;
                }
            }
        }

    }
}
