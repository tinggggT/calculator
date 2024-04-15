using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // 全域變數
        float firstNumber, secondNumber; // firstNumber 儲存第一個數字，secondNumber 儲存第二個數字
        int operators = -1; // 記錄選擇哪一種運算符號？0:加、1:減、2:乘、3:除、-1:重新設定
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtNumber_Click(object sender, EventArgs e)
        {

        }
        private void btnDot_Click(object sender, EventArgs e)
        {
            // 確認輸入文字框中完全沒有小數點
            if (txtNumber.Text.IndexOf(".") == -1)
                txtNumber.Text = txtNumber.Text + ".";
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumber.Text = "0";
            firstNumber = 0f;
            secondNumber = 0f;
            operators = -1;
        }
        private void Add_Number(string _number)
        {
            if (txtNumber.Text == "0")
                txtNumber.Text = "";
            txtNumber.Text = txtNumber.Text + _number;
        }
        // 按下選擇「加」按鍵
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Select_Operator(0);
        }
        // 按下選擇「減」按鍵
        private void btnMinus_Click(object sender, EventArgs e)
        {
            Select_Operator(1);
        }
        // 按下選擇「乘」按鍵
        private void btnPlus_Click(object sender, EventArgs e)
        {
            Select_Operator(2);
        }
        // 按下選擇「除」按鍵
        private void btnDivide_Click(object sender, EventArgs e)
        {
            Select_Operator(3);
        }
        private void Select_Operator(int _operator)
        {
            firstNumber = Convert.ToSingle(txtNumber.Text); //將輸入文字框轉換成浮點數，存入第一個數字的全域變數
            txtNumber.Text = "0"; //重新將輸入文字框重新設定為0
            operators = _operator; //選擇「加」號
        }
        private void btnZero_Click(object sender, EventArgs e)
        {
            Add_Number("0"); // 只需要呼叫Add_Number函式，並且設定參數為數字1
        }
        private void btnOne_Click(object sender, EventArgs e)
        {
            Add_Number("1"); // 只需要呼叫Add_Number函式，並且設定參數為數字1
        }
        private void btnTwo_Click(object sender, EventArgs e)
        {
            Add_Number("2"); // 只需要呼叫Add_Number函式，並且設定參數為數字1
        }
        private void btnThree_Click(object sender, EventArgs e)
        {
            Add_Number("3"); // 只需要呼叫Add_Number函式，並且設定參數為數字1
        }
        private void btnFour_Click(object sender, EventArgs e)
        {
            Add_Number("4"); // 只需要呼叫Add_Number函式，並且設定參數為數字1
        }
        private void btnFive_Click(object sender, EventArgs e)
        {
            Add_Number("5"); // 只需要呼叫Add_Number函式，並且設定參數為數字1
        }
        private void btnSix_Click(object sender, EventArgs e)
        {
            Add_Number("6"); // 只需要呼叫Add_Number函式，並且設定參數為數字1
        }
        private void btnSeven_Click(object sender, EventArgs e)
        {
            Add_Number("7"); // 只需要呼叫Add_Number函式，並且設定參數為數字1
        }
        private void btnEight_Click(object sender, EventArgs e)
        {
            Add_Number("8"); // 只需要呼叫Add_Number函式，並且設定參數為數字1
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            Add_Number("9"); // 只需要呼叫Add_Number函式，並且設定參數為數字1
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            string number = txtNumber.Text;
            int length = number.Length;
            txtNumber.Text = number.Substring(0, length - 1);
            if (txtNumber.Text == "")
                txtNumber.Text = "0";
        }

        private void btnPercentage_Click_1(object sender, EventArgs e)
        {
            //float finalResults = 0.0f;
            string number = txtNumber.Text;
            //string.Format("{0:P2}", number);
            txtNumber.Text = string.Format("{0:P2}", number);
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            float finalResults = 0f; //宣告最後計算結果變數
            secondNumber = Convert.ToSingle(txtNumber.Text); //將輸入文字框轉換成浮點數，存入第二個數字的全域變數

            //依照四則運算符號的選擇，進行加減乘除
            switch (operators)
            {
                case 0:
                    finalResults = firstNumber + secondNumber;
                    break;
                case 1:
                    finalResults = firstNumber - secondNumber;
                    break;
                case 2:
                    finalResults = firstNumber * secondNumber;
                    break;
                case 3:
                    finalResults = firstNumber / secondNumber;
                    break;
            }

            txtNumber.Text = string.Format("{0:0.##########}", finalResults); //在輸入文字框中，顯示最後計算結果，並且轉換成格式化的字串內容

            //重置所有全域變數
            firstNumber = 0f;
            secondNumber = 0f;
            operators = -1;
        }
    }
    

}







