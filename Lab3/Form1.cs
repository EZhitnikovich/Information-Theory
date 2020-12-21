using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Math;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        byte Capacity;
        public Form1()
        {
            InitializeComponent();
            Capacity = 8;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int value))
            {
                if (value < 9 && value > 0)
                {
                    Capacity = Convert.ToByte(textBox1.Text);
                    dataGrid.ColumnCount = Convert.ToInt16(textBox1.Text);
                    dataGrid.RowCount = 3;
                    for (int i = 0; i < dataGrid.ColumnCount; i++)
                    {
                        dataGrid.Columns[i].Name = Convert.ToString(i + 1);
                        dataGrid.Columns[i].Width = 40;
                        dataGrid.Rows[0].Cells[i].Value = i % 2;
                        dataGrid.Rows[1].Cells[i].Value = 0;
                        if(i == 0 || i == dataGrid.ColumnCount - 1)
                            dataGrid.Rows[2].Cells[i].Value = 1;
                        else
                            dataGrid.Rows[2].Cells[i].Value = 0;
                    }
                    dataGrid.RowHeadersWidth = 170;
                    dataGrid.Rows[0].HeaderCell.Value = "Изначальное состояние";
                    dataGrid.Rows[1].HeaderCell.Value = "Промежуточные";
                    dataGrid.Rows[2].HeaderCell.Value = "Отводы";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int value))
            {

                textBox2.Clear();


                int loop = ((int)Pow(2, value) - 1) * 2;

                int g = 1;
                for (int i = 0; i < Capacity; i++)
                    dataGrid.Rows[1].Cells[i].Value = dataGrid.Rows[0].Cells[i].Value;
                while (loop != 0)
                {
                    textBox2.Text += $"{g} - ";
                    for (int i = 0; i < value; i++)
                    {
                        textBox2.Text += dataGrid.Rows[1].Cells[i].Value;
                    }

                    textBox2.Text += "\r\n";
                    loop--;
                    g++;
                    GetNewKey();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Capacity; i++)
                dataGrid.Rows[1].Cells[i].Value = dataGrid.Rows[0].Cells[i].Value;

            string source = sourceOriginal.Text;

            outCipher.Text = TransformText(source);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Capacity; i++)
                dataGrid.Rows[1].Cells[i].Value = dataGrid.Rows[0].Cells[i].Value;

            string source = sourceCipher.Text;

            outOriginal.Text = TransformText(source);
        }

        private string TransformText(string source)
        {
            string result = null;

            int c = 0;

            for (int i = 0; i < source.Length; i++)
            {
                string key = GetKey();
                GetNewKey();
                c++;
                result += Convert.ToChar(source[i] ^ BinToByte(key));
            }

            return result;
        }

        string GetKey()
        {
            string key_str = "";
            for (int i = 0; i < Capacity; i++)
                key_str += dataGrid.Rows[1].Cells[i].Value;
            return key_str;
        }

        void GetNewKey()
        {

            int temp = 1;
            List<int> next = new List<int>();

            for (int i = 0; i < Capacity; i++)
            {
                if (Convert.ToInt16(dataGrid.Rows[2].Cells[i].Value) == 1)
                {
                    temp = i;
                    next.Add(Convert.ToInt16(dataGrid.Rows[1].Cells[i].Value));
                    break;
                }
            }

            for (int i = temp + 1; i < Capacity; i++)
            {
                if (Convert.ToInt16(dataGrid.Rows[2].Cells[i].Value) == 1)
                {
                    next[0] = next[0] ^ Convert.ToInt16(dataGrid.Rows[1].Cells[i].Value) ^ 1;
                }
            }

            for (int i = 0; i < Capacity - 1; i++)
            {
                next.Add(Convert.ToInt16(dataGrid.Rows[1].Cells[i].Value));
            }

            for (int i = 0; i < Capacity; i++)
                dataGrid.Rows[1].Cells[i].Value = next[i];
        }

        byte BinToByte(string binary)
        {
            byte result = 0, val = 0;
            for (int i = 0; i < Capacity; i++)
            {
                if (binary[i] == '0') val = 0;
                else val = 1;
                result += Convert.ToByte(Math.Truncate(val * Math.Exp(Math.Log10(2) * (Capacity - i))));
            }
            return result;
        }
    }
}
