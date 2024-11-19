using Encrypt_Decrypt_Tool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encrypt___Decrypt_Tool

{
    internal class Encryptor
    {
        public string output;
        public int CurrentShift;
        public Encryptor(bool everyOtherReversed, string preEncryptedString, int shiftAdder)
        {
            CurrentShift = shiftAdder;

            for (int i = 0; i < preEncryptedString.Length; i++) 
            {
                char C = preEncryptedString[i];

                foreach (char c in CONSTANTS.CHARS)
                {
                    if(C == c)
                    {
                        int charArrayPosition = GetCharArrayPosition(c);
                        int shiftedCharArrayPosition = charArrayPosition + CurrentShift;

                        if (shiftedCharArrayPosition >= CONSTANTS.ARRLEN) 
                        {
                            int normalisedShiftedCharArrayPosition = NormaliseShiftPosition(shiftedCharArrayPosition);
                            output += CONSTANTS.CHARS[normalisedShiftedCharArrayPosition];
                        }
                        else output += CONSTANTS.CHARS[shiftedCharArrayPosition];





                    }
                }
                CurrentShift += shiftAdder;
            }     
        }

        private int GetCharArrayPosition(char c)
        {
            for (int i = 0; i < CONSTANTS.ARRLEN; i++)
            {
                if (CONSTANTS.CHARS[i] == c) return i;
            }
            return -1;
        }

        private int NormaliseShiftPosition(int currentShift)
        {
                return currentShift % (CONSTANTS.ARRLEN);
        }

  
    }
}
