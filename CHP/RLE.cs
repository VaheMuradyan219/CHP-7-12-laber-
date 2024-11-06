using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHP
{
    internal class RLE
    {
        public static string Encode(string input)
        {
            if (string.IsNullOrEmpty(input))
                return "";

            StringBuilder encoded = new StringBuilder();
            int count = 1;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == input[i - 1])
                {
                    count++;
                }
                else
                {
                    encoded.Append(input[i - 1]);
                    encoded.Append(count);
                    count = 1;
                }
            }

            encoded.Append(input[input.Length - 1]);
            encoded.Append(count);

            return encoded.ToString();
        }

        public static string Decode(string encoded)
        {
            if (string.IsNullOrEmpty(encoded))
                return "";

            StringBuilder decoded = new StringBuilder();

            for (int i = 0; i < encoded.Length; i++)
            {
                char symbol = encoded[i];
                i++;

                StringBuilder countStr = new StringBuilder();
                while (i < encoded.Length && char.IsDigit(encoded[i]))
                {
                    countStr.Append(encoded[i]);
                    i++;
                }
                i--;

                int count = int.Parse(countStr.ToString());

                decoded.Append(symbol, count);
            }

            return decoded.ToString();
        }

    }
}
