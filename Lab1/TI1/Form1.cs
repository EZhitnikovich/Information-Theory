using System;
using System.Windows.Forms;
using static TI1.Manager;
using static TI1.TextHandler;

namespace TI1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEnc_Click(object sender, EventArgs e)
        {
            int module = ConvertToInt(textBoxSM.Text);
            int key = ConvertToInt(textBoxSK.Text);
            module = CheckModule(module);
            key = CheckKey(key);
            string source = textBoxSource.Text;

            textBoxEnc.Text = Encrypt(source, module, key);
        }

        private void buttonDec_Click(object sender, EventArgs e)
        {
            int module = ConvertToInt(textBoxDM.Text);
            int key = ConvertToInt(textBoxDK.Text);
            module = CheckModule(module);
            key = CheckKey(key);
            string source = textBoxEncSource.Text;

            textBoxDec.Text = Decrypt(source, module, key);
        }
    }
}
