using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureGame2
{
    class CenterText
    {
        public static void centerText(string message)
        {
            int screenWidth = Console.WindowWidth;
            int stringWidth = message.Length;
            int spaces = (screenWidth / 2) + (stringWidth / 2);

            Console.WriteLine("\n");


            Console.WriteLine(message.PadLeft(spaces));
        }
    }
}
