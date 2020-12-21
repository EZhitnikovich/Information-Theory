using System.Collections.Generic;

namespace TI2
{
    public static class MainTextEditor
    {
        public static string EncryptText(string keyStr, string moduleStr, string sourceText)
        {
            int key = Converter.ConvertToInt(keyStr);
            int module = Converter.ConvertToInt(moduleStr);

            string answer = null;

            if (!CoprimeNums.IsCoprime(module, key))
                answer += "Module and key is not coprime\r\n";

            answer += TextEncryptor.Encrypt(sourceText, module, key);

            return answer;
        }

        public static string ReplaceChars(string source, Dictionary<string, string> dict)
        {
            return TextDecryptor.ReplaceChars(source, dict);
        }
    }
}
