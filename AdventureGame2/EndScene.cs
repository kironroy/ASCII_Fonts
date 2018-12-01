using System;
using System.Globalization;
using System.Collections.Generic;

// http://programmingisfun.com/learn/c-sharp-adventure-game/c_sharp_12_framework_summary/

namespace AdventureGame2
{
    public static class EndScene
    {
        public static void EndTitleBlue()
        {

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.Title = "ASCII Art";
            Console.WriteLine(); // breakline
            string titleBlue =
             @"
                                        d888888b db   db d88888b      d88888b d8b   db d8888b. 
                                        `~~88~~' 88   88 88'          88'     888o  88 88  `8D 
                                           88    88ooo88 88ooooo      88ooooo 88V8o 88 88   88 
                                           88    88~~~88 88~~~~~      88~~~~~ 88 V8o88 88   88 
                                           88    88   88 88.          88.     88  V888 88  .8D 
                                           YP    YP   YP Y88888P      Y88888P VP   V8P Y8888D' 
                                                       
           ";

            Console.WriteLine(titleBlue);
            Console.WriteLine(); // breakline
            Console.ForegroundColor = ConsoleColor.Blue;

        } // blue method end

       
        
        // Yellow

        public static void EndTitleYellow()
        {

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.Title = "ASCII Art";
            Console.WriteLine(); // breakline
            string titleBlue =
             @"
                                        d888888b db   db d88888b      d88888b d8b   db d8888b. 
                                        `~~88~~' 88   88 88'          88'     888o  88 88  `8D 
                                           88    88ooo88 88ooooo      88ooooo 88V8o 88 88   88 
                                           88    88~~~88 88~~~~~      88~~~~~ 88 V8o88 88   88 
                                           88    88   88 88.          88.     88  V888 88  .8D 
                                           YP    YP   YP Y88888P      Y88888P VP   V8P Y8888D' 
                                                       
           ";

            Console.WriteLine(titleBlue);
            Console.WriteLine(); // breakline
            Console.ForegroundColor = ConsoleColor.Blue;

        } //  yellow method end

        // Red

        public static void EndTitleRed()
        {

            Console.ForegroundColor = ConsoleColor.Red;

            Console.Title = "ASCII Art";
            Console.WriteLine(); // breakline
           
            string titleBlue =
           @"
                                        d888888b db   db d88888b      d88888b d8b   db d8888b. 
                                        `~~88~~' 88   88 88'          88'     888o  88 88  `8D 
                                           88    88ooo88 88ooooo      88ooooo 88V8o 88 88   88 
                                           88    88~~~88 88~~~~~      88~~~~~ 88 V8o88 88   88 
                                           88    88   88 88.          88.     88  V888 88  .8D 
                                           YP    YP   YP Y88888P      Y88888P VP   V8P Y8888D' 
                                                       
           ";

            Console.WriteLine(titleBlue);
            Console.WriteLine(); // breakline
            Console.ForegroundColor = ConsoleColor.Blue;

        } // method end











































    } // namespace end
} // class end

