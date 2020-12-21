using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static TI1.Manager;

namespace TI1
{
    class TextHandler
    {

        static readonly string upLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        static readonly string lowLetters = "abcdefghijklmnopqrstuvwxyz";

        public static string Encrypt(string sourceText, int module, int key)
        {
            string encryptedText = $"Ключ: {key}, Модуль: {module}\r\n";

            if (IsCoprime(module, key))
            {

                encryptedText += ModifyText(sourceText, key, module);

            }
            else
            {
                encryptedText += $"{module} и {key} не взаимно простные";
            }

            return encryptedText;
        }

        public static string Decrypt(string sourceText, int module, int key)
        {
            string decryptedText = $"Ключ: {key}, Модуль: {module}\r\n";

            if (IsCoprime(module, key))
            {

                int decKey = InverseKey(key, module);

                decryptedText += ModifyText(sourceText, decKey, module);

            }
            else
            {
                decryptedText += $"{module} и {key} не взаимно простные";
            }

            return decryptedText;
        }

        private static string ModifyText(string sourceText, int key, int module)
        {
            string pattern = "";

            foreach (char letter in sourceText)
            {
                if (upLetters.Contains(letter))
                {
                    pattern += upLetters[(upLetters.IndexOf(letter) * key) % module];
                }
                else if (lowLetters.Contains(letter))
                {
                    pattern += lowLetters[(lowLetters.IndexOf(letter) * key) % module];
                }
                else
                {
                    pattern += letter;
                }
            }

            return pattern;
        }

        private static int InverseKey(int key, int module)
        {
            for (int i = 1; i < module; i++)
            {
                if ((key * i) % module == 1)
                {
                    return i;
                }
            }
            return 1;
        }

    }
}
