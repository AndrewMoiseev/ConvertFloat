using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace FloatCnv
{
    public partial class Form1 : Form
    {
        public Single ValueFromConvert;

        const string formatter = "{0,16}";

        public static string GetBytesSingle(float argument)
        {
            byte[] byteArray = BitConverter.GetBytes(argument);
            return String.Format(formatter, argument,
                BitConverter.ToString(byteArray));
        }

        public byte[] BtsBytes ;

        public Form1()
        {
            InitializeComponent();
            textFloatToConvert.Validating +=new CancelEventHandler(Number_Validating);
            BtsBytes = new byte[4];
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            ValueFromConvert = Convert.ToSingle(textFloatToConvert.Text.Replace('.',','));
            
            byte[] byteArray = BitConverter.GetBytes(ValueFromConvert);

            textResult.Text = "HEX: " + String.Format(formatter, BitConverter.ToString(byteArray));
            textResult.Text += "    DEC: ";
            foreach (var VARIABLE in byteArray)
            {
                textResult.Text += " " + VARIABLE.ToString();
            }

            textHex1.Text = BitConverter.ToString(byteArray, 3, 1);
            textHex1.Text += "  DEC:" + byteArray[3].ToString();
            textHex2.Text = BitConverter.ToString(byteArray, 2, 1);
            textHex2.Text += "  DEC:" + byteArray[2].ToString();
            textHex3.Text = BitConverter.ToString(byteArray, 1, 1);
            textHex3.Text += "  DEC:" + byteArray[1].ToString();
            textHex4.Text = BitConverter.ToString(byteArray, 0, 1);
            textHex4.Text += "  DEC:" + byteArray[0].ToString();


        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            byte[] byteArray = new byte[4];
            float flRres;
            string ResStr = "";
            string ResStrHex = "";
            if (byte.TryParse(textHexToCnv1.Text, out byteArray[0]))
            {
                ResStr += byteArray[0].ToString();
                ResStrHex += BitConverter.ToString(byteArray, 0, 1);
            }
            if (byte.TryParse(textHexToCnv2.Text, out byteArray[1]))
            {
                ResStr += "-" + byteArray[1].ToString();
                ResStrHex += "-" + BitConverter.ToString(byteArray, 1, 1);
            }
            if (byte.TryParse(textHexToCnv3.Text, out byteArray[2]))
            {
                ResStr += "-" + byteArray[2].ToString();
                ResStrHex += "-" + BitConverter.ToString(byteArray, 2, 1);
            }
            if (byte.TryParse(textHexToCnv4.Text, out byteArray[3]))
            {
                ResStr += "-" + byteArray[3].ToString();
                ResStrHex += "-" +BitConverter.ToString(byteArray, 3, 1);
            }

            label1.Text = ResStr;
            label2.Text ="HEX:  "+ ResStrHex;

            flRres = BitConverter.ToSingle(byteArray, 0);
            textFloat.Text = flRres.ToString();
        }
        private void Number_Validating(object sender, CancelEventArgs e)
        {
            float val;
            TextBox tb = sender as TextBox;
            if (!float.TryParse(tb.Text, out val))
            {
                MessageBox.Show(tb.Tag + " должны быть только числа.");
                tb.Undo();
                e.Cancel = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
