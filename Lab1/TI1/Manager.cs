using System;
using System.Windows.Forms;
using static System.Math;

namespace TI1
{
    class Manager
    {

        public static int ConvertToInt(string textValue)
        {
            try
            {
                int doubleValue = Convert.ToInt32(textValue);
                return doubleValue;
            }
            catch (System.FormatException)
            {
                return 0;
            }
        }

        public static bool IsCoprime(int num1, int num2)
        {
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

        public static int CheckModule(int module)
        {
            if (module < 0)
            {
                DialogResult dialogResult = MessageBox.Show("Значение не может быть отрацательным\n" +
                                                            "Будет взят модуль значения (|M|)\n", "Ошибка", MessageBoxButtons.OK);
                module =  Abs(module);
                
            }

            if (module > 26)
            {
                DialogResult dialogResult = MessageBox.Show("Модуль имеет значение больше допустимого\n" +
                                                            "Уменьшить значение до максимально допустимого?\n" +
                                                            "(В противном случаем может произойти ошибка.)", "Да/нет", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    while(module > 26)
                    {
                        module -= 26;
                    }

                }
            }

            return module;
        }

        public static int CheckKey(int key)
        {
            if (key < 0)
            {
                DialogResult dialogResult = MessageBox.Show("Значение не может быть отрацательным\n" +
                                                            "Будет взят модуль значения (|K|)\n", "Ошибка", MessageBoxButtons.OK);
                key = Abs(key);

            }

            return key;
        }

    }
}
