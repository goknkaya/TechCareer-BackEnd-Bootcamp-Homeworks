using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeworkCalculator
{
    public partial class Form1 : Form
    {
        char Character;

        public Form1()
        {
            InitializeComponent();
        }
        
        private int InsertValue(int Number)
        {
            if (TxtScreen.Text == "0") // Ekranda ilk yazan değer 0 ise TextBox' un içini boşalt ve sonradan eklemeye başla.
            {
                TxtScreen.Text = ""; // Ekranda 0 yazılıyken girilecek 123 sayısını 0123 olarak almaması için...
            }
            TxtScreen.Text += Number; // Sayıları yanyana yazabilmek için += dedik
            return Number;
        }

        private void Memory(char MathSign)
        {
            LblFirstNumber.Text = TxtScreen.Text;
            LblSign.Text = Character.ToString();
            TxtScreen.Text = "";
        }

        private int Result(ref int Value1, ref int Value2, char Symbol)
        {
            int LastValue = 0;
            switch (Symbol) //Matematiksel işlemin yapıldığı kısım
            {
                case '+': 
                    LastValue = Value1 + Value2; 
                    break;
                case '-': 
                    LastValue = Value1 - Value2; 
                    break;
                case '*': 
                    LastValue = Value1 * Value2; 
                    break;
                case '/': 
                    LastValue = Value1 / Value2; 
                    break;
                default:
                    MessageBox.Show("İşlem hatalı");
                    break;
            }

            return LastValue;
        }

        //Butonlara tıklandığında ekrana sayılar yazdırılıyor...

        #region 

        private void Form1_Load(object sender, EventArgs e)
        {
            InsertValue(0);
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            InsertValue(0);
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            InsertValue(1);
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            InsertValue(2);
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            InsertValue(3);
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            InsertValue(4);
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            InsertValue(5);
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            InsertValue(6);
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            InsertValue(7);
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            InsertValue(8);
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            InsertValue(9);
        }

        private void BtnClear_Click(object sender, EventArgs e) //C tuşu
        {
            TxtScreen.Text = "";
            LblFirstNumber.Text = "";
            LblSecondNumber.Text = "";
            LblSign.Text = "";
            InsertValue(0);
        }
        #endregion

        //+ - / * tuşlarına basıldığında ilgili işlemin işaretini Character isimli değişkene atıyor ve bu değişkenle beraber Memory procedure'üne gidiyor
        private void BtnPlus_Click(object sender, EventArgs e)
        {
            Character = '+';
            Memory(Character);
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            Character = '-';
            Memory(Character);
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            Character = '*';
            Memory(Character);
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            Character = '/';
            Memory(Character);
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            int FirstValue, SecondValue, FinallyResult;
            char Sign = Convert.ToChar(LblSign.Text);
            LblSecondNumber.Text = TxtScreen.Text;
            FirstValue = Convert.ToInt32(LblFirstNumber.Text);
            SecondValue = Convert.ToInt32(LblSecondNumber.Text);
            FinallyResult = Result(ref FirstValue, ref SecondValue, Sign); // Matematiksel işlemin yapıldığı fonksiyon
            TxtScreen.Text = FinallyResult.ToString();
        }
    }
}
