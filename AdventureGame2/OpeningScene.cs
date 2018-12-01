using System;
using System.Globalization;
using System.Collections.Generic;

// http://programmingisfun.com/learn/c-sharp-adventure-game/c_sharp_12_framework_summary/

namespace AdventureGame2
{
    public static class OpeningScene
    {
        public static void ArtTitle()
        {

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.Title = "ASCII Art";
            Console.WriteLine(); // breakline
            Console.WriteLine(); // breakline
            Console.WriteLine(); // breakline
            string title =
                @"
                                
                             
                         
                     .----------------.  .----------------.  .----------------.  .----------------.  .----------------. 
                    | .--------------. || .--------------. || .--------------. || .--------------. || .--------------. |
                    | |      __      | || |    _______   | || |     ______   | || |     _____    | || |     _____    | |
                    | |     /  \     | || |   /  ___  |  | || |   .' ___  |  | || |    |_   _|   | || |    |_   _|   | |
                    | |    / /\ \    | || |  |  (__ \_|  | || |  / .'   \_|  | || |      | |     | || |      | |     | |
                    | |   / ____ \   | || |   '.___`-.   | || |  | |         | || |      | |     | || |      | |     | |
                    | | _/ /    \ \_ | || |  |`\____) |  | || |  \ `.___.'\  | || |     _| |_    | || |     _| |_    | |
                    | ||____|  |____|| || |  |_______.'  | || |   `._____.'  | || |    |_____|   | || |    |_____|   | |
                    | |              | || |              | || |              | || |              | || |              | |
                    | '--------------' || '--------------' || '--------------' || '--------------' || '--------------' |
                     '----------------'  '----------------'  '----------------'  '----------------'  '----------------' 


                                                                 

                ";

            Console.WriteLine(title);
            Console.WriteLine(); // breakline
            Console.ForegroundColor = ConsoleColor.Blue;
            CenterText.centerText("Press enter to continue...");
            Console.ReadKey();
            Console.Clear();


        }
    }
}

