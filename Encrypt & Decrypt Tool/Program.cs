using Encrypt___Decrypt_Tool;
using Encrypt_Decrypt_Tool.UI;

namespace Encrypt_Decrypt_Tool
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            bool everyOtherReversed = false;
            string UnencryptedString;
            string EncryptedString;
            int shiftAdder;

            while (true)
            {
                int option = UIManager.SelectEncryptOrDecrypt();
                if (option == 1)
                {
                    shiftAdder = UIManager.DefineShiftProgression();
                    //everyOtherReversed = UIManager.ConfirmReverseEveryOtherChar();
                    UnencryptedString = UIManager.InputStringForEncryption();

                    UIManager.EncryptionLoadingScreen();

                    Encryptor encryptor = new Encryptor(everyOtherReversed, UnencryptedString, shiftAdder);

                    Console.WriteLine("The output is:");
                    Console.WriteLine(encryptor.output);

                }

                else if (option == 2)
                {
                    shiftAdder = UIManager.DefineShiftProgression();
                    //everyOtherReversed = UIManager.ConfirmReverseEveryOtherChar();
                    EncryptedString = UIManager.InputStringForDecryption();

                    UIManager.DecryptionLoadingScreen();
                    Decryptor decryptor = new Decryptor(everyOtherReversed, EncryptedString, shiftAdder);

                    Console.WriteLine("The output is:");
                    Console.WriteLine(decryptor.output);
                    Console.WriteLine();
                }
            }

        } 
    }
}
