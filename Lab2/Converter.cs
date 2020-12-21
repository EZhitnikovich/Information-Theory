using System;

namespace TI2
{
    public static class Converter
    {
        public static int ConvertToInt(string source)
        {
            if (int.TryParse(source, out int result))
            {
                return result;
            }
            else
            {
                throw new Exception("Can't convert string to int");
            }
        }
    }
}
