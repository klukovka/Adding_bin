using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Add_binary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        string AddBinaryNumbers(string first="0", string second="0")
        {

            string result = "";
            int len = first.Length > second.Length ? first.Length : second.Length;
            first = first.PadLeft(len, '0');
            second = second.PadLeft(len, '0');
            first = Reverse(first);
            second = Reverse(second);
            string temp = "0";
            for (int i = 0; i < len; i++)
            {
                if (temp == "0")
                {
                    if (first[i]=='0' && second[i]=='0')
                    {
                        result += "0";
                        temp = "0";
                    }
                    else if (first[i]=='1' && second[i] == '1')
                    {
                        result += "0";
                        temp = "1";
                    }
                    else
                    {
                        result += "1";
                        temp = "0";
                    }
                }
                else
                {
                    if (first[i] == '0' && second[i] == '0')
                    {
                        result += "1";
                        temp = "0";
                    }
                    else if (first[i] == '1' && second[i] == '1')
                    {
                        result += "1";
                        temp = "1";
                    }
                    else
                    {
                        result += "0";
                        temp = "1";
                    }
                }
            }
            if (temp == "1")
                result += temp;
            result = Reverse(result);
           
            return result;
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if ((e.KeyChar <= 47 || e.KeyChar >= 50) && e.KeyChar != 8 && e.KeyChar!=127)
            {
                e.Handled = true;
            }
        }

        private void GetRes(object sender, EventArgs e)
        {
            Result.Text = AddBinaryNumbers(First.Text, Second.Text);
        }
    }
}
