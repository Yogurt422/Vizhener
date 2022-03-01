using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._02_2
{
    internal class Vi
    {
        private static string AlphabetRU =
                "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
       //Привет
       //ДОмДом
       //012345
        public static string Encrypty(string input, string key)
        {
            input = input.ToUpper();
            key = key.ToUpper();
            int counter = 0;
            string output = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                if (!char.IsLetter(input[i]))
                {
                    counter++;
                    continue;
                }
                int inputIndex = AlphabetRU.IndexOf(input[i]);
                int keyIndex = AlphabetRU.IndexOf(key[(i-counter)%key.Length]);
                output += AlphabetRU[(inputIndex + keyIndex)
                           % AlphabetRU.Length];

            }
            return output;
        }
        public static string Decrypt(string input, string key)
        {
            input = input.ToUpper();
            key = key.ToUpper();
            int counter = 0;
            string output = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                if (!char.IsLetter(input[i]))
                {
                    counter++;
                    continue;
                }
                int inputIndex = AlphabetRU.IndexOf(input[i]);
                int keyIndex = AlphabetRU.IndexOf(key[(i - counter) % key.Length]);
                output += AlphabetRU[(AlphabetRU.Length + inputIndex - keyIndex)
                           % AlphabetRU.Length];

            }
            return output;

        }
    }
}
