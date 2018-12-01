using System;

namespace AdventureGame2
{
    public static class Game
    {
        static bool run = true;
        static int choice;
        static string input;
        static bool goal = false;

        private static void Start()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            CenterText.centerText("ASCII fonts Intro");
            CenterText.centerText("press enter to continue");
            Console.ReadKey();

        }

        private static void End()
        {
            if (goal)
            {
                Console.WriteLine("Success!");

                Console.WriteLine("Press enter to continue...");
                Console.ReadLine();
            }
            else
            {
                EndScene.EndTitleBlue();
                EndScene.EndTitleYellow();
                EndScene.EndTitleRed();
                Environment.Exit(0); // exit the game
                
             
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

        private static void Menu()
        {
            Console.Clear();
            CenterText.centerText("press 1. Big Money 2. Doh 3. Isometric 4. Slant 5. Exit");
            string pressEnterCont = "Press enter to continue";
            choice = Convert.ToInt32(Console.ReadLine().Trim());
            if (choice == 5)
            {
                run = false;
            }
            else
            {
                switch (choice)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        ASCIIFonts.BigMoney();
                        Console.WriteLine();
                        CenterText.centerText(pressEnterCont);
                        Console.ReadLine();
                        break;

                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        ASCIIFonts.Doh();
                        CenterText.centerText(pressEnterCont);
                        Console.ReadLine();
                        break;

                    case 3:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        ASCIIFonts.Isometric();
                        CenterText.centerText(pressEnterCont);
                        Console.ReadLine();
                        break;

                    case 4:
                        Console.ForegroundColor = ConsoleColor.Red;
                        ASCIIFonts.SlantandRelief();
                       
                        CenterText.centerText(pressEnterCont);
                        Console.ReadLine();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        input = Console.ReadLine();
                        if (int.TryParse(input, out choice))
                        {
                            if (choice > 5)
                            {
                                run = false;
                                
                            }
                            else
                            {
                              
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
