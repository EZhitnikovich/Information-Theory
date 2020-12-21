using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4v2
{
    public partial class Form1 : Form
    {
        Random rand = new Random(DateTime.Now.Millisecond);
        static readonly char[] lowLetters = "#abcdefghijklm nopqrstuvwxyz1234567890".ToCharArray();

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonEnc_Click(object sender, EventArgs e)
        {
            if (int.TryParse(EncNText.Text, out int N) && int.TryParse(EncKoText.Text, out int key))
            {
                string res = RSA_Encode(EncOutput, SourceInput.Text, N, key);
                //EncOutput.Text = @res;
            }
            else
            {
                MessageBox.Show("Введены некорректные параметры.");
            }
        }

        private void ButtonDec_Click(object sender, EventArgs e)
        {
            if (int.TryParse(EncNText.Text, out int N) && int.TryParse(DecKcText.Text, out int key))
            {
                SourceOutput.Text = RSA_Decode(EncSource.Text, N, key);
            }
            else
            {
                MessageBox.Show("Введены некорректные параметры.");
            }
        }

        private void generateKeysButton_Click(object sender, EventArgs e)
        {
            int p = 0, q = 0;
            if (pInput.Text == "" && qInput.Text == "")
            {
                GeneratePQ(ref p, ref q);

                nOutput.Text = (p * q).ToString();

                int f = (p - 1) * (q - 1);
                fOutput.Text = f.ToString();

                GenerateKeys(f);
            }
            else
            {
                if (pInput.Text == "")
                {
                    MessageBox.Show("Введите p");
                    return;
                }
                else if (qInput.Text == "")
                {
                    MessageBox.Show("Введите q");
                    return;
                }

                p = int.Parse(pInput.Text);
                q = int.Parse(qInput.Text);

                if (p == q)
                {
                    MessageBox.Show("Значения не могут быть равны");
                    return;
                }

                if (!IsPrime.IsPrimeNumber(p) || !IsPrime.IsPrimeNumber(q))
                {
                    MessageBox.Show("Числа должны быть простыми");
                    return;
                }

                nOutput.Text = (p * q).ToString();

                int f = (p - 1) * (q - 1);
                fOutput.Text = f.ToString();

                GenerateKeys(f);
            }
        }

        private string RSA_Decode(string text, int N, int Key)
        {
            string result = null;

            foreach(char ch in text)
            {
                int index = (int)(BigInteger.Pow(ch, Key) % N);
                
                char resCh;

                if (index >= 0 && index < lowLetters.Length)
                    resCh = lowLetters[index];
                else
                    resCh = Convert.ToChar(index);

                //if (resCh == '7')
                //    resCh = ' ';

                result += resCh;
            }

            return result;
        }

        private string RSA_Encode(TextBox tb ,string text, int N, int Key)
        {
            string result = null;
            tb.Clear();

            foreach (char ch in text.ToLower())
            {
                //char newCh;
                if (lowLetters.Contains(ch))
                    tb.Text += Convert.ToChar((int)(BigInteger.Pow(Array.IndexOf(lowLetters, ch), Key) % N));
                else
                    tb.Text += Convert.ToChar((int)(BigInteger.Pow(ch, Key) % N));

                //result += newCh;
            }

            return result;
        }

        private void GenerateKeys(int f)
        {
            int kc = rand.Next(2, 200), ko = rand.Next(2,200);
            bool kcReady = false;
            if (kcOutput.Text != "" && int.TryParse(kcOutput.Text, out int tokc) && IsPrime.IsCoprime(tokc, f))
            {
                kc = tokc;
                kcReady = true;
            }
            else if(kcOutput.Text == "")
            {
                kcReady = false;
            }
            else
            {
                MessageBox.Show("Kc и φ не взаимно просты\r\n" +
                                "Kc будет сгененирован случайно");
            }

            while (!kcReady)
            {
                if (!IsPrime.IsCoprime(f, kc))
                {
                    kc = rand.Next(2, 200);
                }
                else
                {
                    kcOutput.Text = kc.ToString();
                    break;
                }
            }

            while ((kc * ko) % f != 1)
            {
                ko++;
            }

            koOutput.Text = ko.ToString();
        }

        private void GeneratePQ(ref int p, ref int q)
        {
            while (true)
            {
                p = rand.Next(0, 256);
                if (!IsPrime.IsPrimeNumber(p))
                {
                    p = rand.Next(0, 256);
                }
                else
                {
                    pInput.Text = p.ToString();
                    break;
                }
            }

            while (true)
            {
                q = rand.Next(0, 256);
                if (!IsPrime.IsPrimeNumber(q) || q == p)
                {
                    q = rand.Next(0, 256);
                }
                else
                {
                    qInput.Text = q.ToString();
                    break;
                }
            }
        }
    }
}
