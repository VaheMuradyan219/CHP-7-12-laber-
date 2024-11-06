using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHP
{
    internal class CaesarCipher
    {
        public static string Encrypt(string input, int key)
        {
            string result = "";

            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    char baseChar = char.IsUpper(c) ? 'A' : 'a';

                    char shiftedChar = (char)((c + key - baseChar) % 26 + baseChar);
                    result += shiftedChar;
                }
                else
                {
                    result += c;
                }
            }

            return result;
        }

        public static string Decrypt(string input, int key)
        {
            return Encrypt(input, 26 - key);
        }
    }
}
