using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input text: ");
            string text = Console.ReadLine();

            Console.Write("input Key: ");
            int key = int.Parse(Console.ReadLine());

            string encryptedText = CaesarCipher.Encrypt(text, key);
            Console.WriteLine("Encrypted Text by Caesar: " + encryptedText);

            string decryptedText = CaesarCipher.Decrypt(encryptedText, key);
            Console.WriteLine("Dexrypted text by Caesar: " + decryptedText);

            string encoded = RLE.Encode(encryptedText);
            Console.WriteLine("Encrypted Text by Caesar: " + encoded);

            string decoded = RLE.Decode(encoded);
            Console.WriteLine("Dexrypted text by Caesar: " + decoded);

            Console.ReadKey();
        }
    }
}
