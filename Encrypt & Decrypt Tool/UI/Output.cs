using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encrypt_Decrypt_Tool.UI
{
    internal static class Output
    {
        public static void ClearScreen()
        {
            Console.Clear();
        }

        public static void EncryptionLoadingScreen()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Encrypting.");
                Thread.Sleep(CONSTANTS.LOADWAITTIME);
                Console.Write(".");
                Thread.Sleep(CONSTANTS.LOADWAITTIME);
                Console.Write(".");
                Thread.Sleep(CONSTANTS.LOADWAITTIME);
                Console.Write(".");
                Thread.Sleep(CONSTANTS.LOADWAITTIME);
                Console.Write(".");
                Thread.Sleep(CONSTANTS.LOADWAITTIME);
                Console.Write(".");
                Thread.Sleep(CONSTANTS.LOADWAITTIME);
                Console.Write(".");
                Thread.Sleep(CONSTANTS.LOADWAITTIME);
                Console.Clear();
            }
        }
        public static void DecryptionLoadingScreen()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Decrypting.");
                Thread.Sleep(CONSTANTS.LOADWAITTIME);
                Console.Write(".");
                Thread.Sleep(CONSTANTS.LOADWAITTIME);
                Console.Write(".");
                Thread.Sleep(CONSTANTS.LOADWAITTIME);
                Console.Write(".");
                Thread.Sleep(CONSTANTS.LOADWAITTIME);
                Console.Write(".");
                Thread.Sleep(CONSTANTS.LOADWAITTIME);
                Console.Write(".");
                Thread.Sleep(CONSTANTS.LOADWAITTIME);
                Console.Write(".");
                Thread.Sleep(CONSTANTS.LOADWAITTIME);
                Console.Clear();
            }
        }

    }
}
