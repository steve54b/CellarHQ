using System;
using System.Collections.Generic;
using System.Text;

namespace CellarHQ
{
    class UserInterface
    {
        // uses .write for prompting instead of .writeline
        public static void DisplayPrompt(string message)
        {
            Console.Write(message);
        }

        public static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static String GetString()
        {
            return Console.ReadLine();
        }

        public static int GetInteger()
        {
            return int.Parse(Console.ReadLine());
        }

        public static decimal GetDecimal()
        {
            return decimal.Parse(Console.ReadLine());
        }

        public static void PromptForExit()
        {
            Console.Write("\nPRESS ANY KEY TO EXIT: ");
            Console.ReadLine();
        }

    }
}
