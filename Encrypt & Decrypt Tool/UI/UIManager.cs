using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encrypt_Decrypt_Tool.UI
{
    public static class UIManager
    {
        //*************** INPUTS *********************
        public static int SelectEncryptOrDecrypt()
        {
           return Input.SelectEncryptOrDecrypt();
        }
        public static int DefineShiftProgression()
        {
            return Input.DefineShiftProgression();
        }
        public static bool ConfirmReverseEveryOtherChar()
        {
           return Input.ConfirmReverseEveryOtherChar();
        }
        public static string InputStringForEncryption()
        {
            return Input.InputStringForEncryption();
        }
        public static string InputStringForDecryption()
        {
            return Input.InputStringForDecryption();
        }

        //*************** OUTPUTS *********************
        public static void ClearScreen()
        {
            Output.ClearScreen();
        }
        public static void EncryptionLoadingScreen()
        {
            Output.EncryptionLoadingScreen();
        }
        public static void DecryptionLoadingScreen()
        {
            Output.DecryptionLoadingScreen();
        }

    }
}
