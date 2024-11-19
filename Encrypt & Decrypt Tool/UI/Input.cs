using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encrypt_Decrypt_Tool.UI
{
    internal class Input
    {
        public static int SelectEncryptOrDecrypt()
        {
            while (true)
            {
                Console.WriteLine("Please define what you would like to do");
                Console.WriteLine("Press 'e' to encrypt. Press 'd' to decrypt.");
                ConsoleKeyInfo OutputChar = Console.ReadKey(intercept: true);
                if (OutputChar.Key == ConsoleKey.E)
                {
                    Console.WriteLine("You selected encrypt");
                    UIManager.ClearScreen();
                    return 1;
                }
                else if (OutputChar.Key == ConsoleKey.D)
                {
                    Console.WriteLine("You selected decrypt");
                    UIManager.ClearScreen();
                    return 2;
                }
                else
                {
                    Console.WriteLine("Please press a valid key");
                    Thread.Sleep(500);
                    UIManager.ClearScreen();
                }
                
            }
        }
        public static int DefineShiftProgression()
        {
            while (true)
            {
                Console.WriteLine("please enter the dynamic incermental shift amount");
                string amountString = Console.ReadLine();
                if (int.TryParse(amountString, out int amount))
                {
                    UIManager.ClearScreen();
                    return amount;
                }
                else 
                { 
                    Console.WriteLine("Please enter a valid integer");
                    Thread.Sleep(500);
                    UIManager.ClearScreen();
                }
            }
        }
        public static bool ConfirmReverseEveryOtherChar()
        {
            while (true)
            {
                Console.WriteLine("would you like to decrement for every other letter. Press 'y', or 'n'.");
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(intercept: true);

                if (consoleKeyInfo.Key == ConsoleKey.Y)
                {
                    UIManager.ClearScreen();
                    return true;
                }
                else if (consoleKeyInfo.Key == ConsoleKey.N)
                {
                    UIManager.ClearScreen();
                    return false;
                }
                else
                {
                    Console.WriteLine("Please enter 'y' or 'n'.");
                    Thread.Sleep(500);
                    UIManager.ClearScreen();
                }
            }
        }
        public static string InputStringForEncryption()
        {
            Console.WriteLine("Please enter the string you would like to encrypt.");
            string output = Console.ReadLine();
            UIManager.ClearScreen();
            return output;

        }
        public static string InputStringForDecryption()
        {
            Console.WriteLine("Please enter the string you would like to Decrypt.");
            string output = Console.ReadLine();
            UIManager.ClearScreen();
            return output;

        }
    }
}
