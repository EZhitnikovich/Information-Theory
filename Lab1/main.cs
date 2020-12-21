using System;

namespace DSBot
{
    class DSBot
    {
        static readonly string upLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        static readonly string lowLetters = "abcdefghijklmnopqrstuvwxyz";
        
        public static bool IsCoprime(int num1, int num2)
        {
            if (num1 <= 0 || num2 <= 0)
            {
                return false;
            }

            if (num1 == num2)
            {
                return num1 == 1;
            }
            else
            {
                if (num1 > num2)
                {
                    return IsCoprime(num1 - num2, num2);
                }
                else
                {
                    return IsCoprime(num2 - num1, num1);
                }
            }
        }
        
        private static string Encrypt(int key, int module, string source)
        {
            string etext = $"Ключ: {key}, Модуль: {module}\r\n";

            //if(IsCoprime(key, module))
                etext += ModifyText(source, key, module);

            return etext;
        }

        private static string Decrypt(int key, int module, string source)
        {
            string dtext = $"Ключ: {key}, Модуль: {module}\r\n";
            
            int decKey = FindDecKey(key, module);

            //if(IsCoprime(key, module))
                dtext += ModifyText(source, decKey, module);

            return dtext;
        }

        // private static int FindDecKey(int key, int module)
        // {
        //     for (int i = 0; i < module; i++)
        //     {
        //         if ((key * i) % module == 1)
        //         {
        //             Console.WriteLine(i);
        //             return i;
        //         }
        //     }

        //     throw new Exception("Ключ не найден.");
        // }

        private static string ModifyText(string sourceText, int key, int module)
        {
            string str = null;

            foreach (char letter in sourceText)
            {
                if (upLetters.Contains(letter))
                {
                    str += upLetters[(upLetters.IndexOf(letter) * key) % module];
                }
                else if (lowLetters.Contains(letter))
                {
                    str += lowLetters[(lowLetters.IndexOf(letter) * key) % module];
                }
                else
                {
                    str += letter;
                }
            }

            return str;
        }

        private static int FindDecKey(int a, int m)
        {
            int x, y;
            int g = GCD(a, m, out x, out y);
            // if (g != 1)
            //     throw new ArgumentException();
            return (x % m + m) % m; 
        }
 
        private static int GCD(int a, int b, out int x, out int y)
        {
            if (a == 0)
            {
                x = 0;
                y = 1;
                return b;
            }
            int x1, y1;
            int d = GCD(b % a, a, out x1, out y1);
            x = y1 - (b/a)*x1;
            y = x1;
            return d;
        }

        static void Main(string[] args)
        {
            int key = 3, module = 26;
            string str = "Information";

            string etext = Encrypt(key, module, str);
            
            Console.WriteLine(etext);

            string dtext = Decrypt(key, module, etext);

            Console.WriteLine(dtext);

            Console.WriteLine(FindDecKey(3,26));
        }
    }
}