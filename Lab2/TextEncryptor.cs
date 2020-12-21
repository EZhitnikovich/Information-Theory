namespace TI2
{
    public static class TextEncryptor
    {
        static readonly string upLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        static readonly string lowLetters = "abcdefghijklmnopqrstuvwxyz";

        public static string Encrypt(string sourceText, int module, int key)
        {
            string encryptedText = null;

            foreach (char letter in sourceText)
            {
                if (upLetters.Contains(letter))
                {
                    encryptedText += upLetters[(upLetters.IndexOf(letter) * key) % module];
                }
                else if (lowLetters.Contains(letter))
                {
                    encryptedText += lowLetters[(lowLetters.IndexOf(letter) * key) % module];
                }
                else
                {
                    encryptedText += letter;
                }
            }

            return encryptedText;
        }
    }
}
