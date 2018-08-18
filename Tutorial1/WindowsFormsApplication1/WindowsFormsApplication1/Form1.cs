using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender , EventArgs e)
        {
            string myString = "aaabcbaaa";
            char[] myArr = myString.ToArray();
            bool Palindrome = false;
            for (int i = 0; i < myArr.Count()/2; i++)
            {
                if (myArr[i] == myArr[myArr.Count() - i - 1])
                {
                    Palindrome = true;
                    continue;
                }
                else
                {
                    Palindrome = false;
                    break;
                }
            }
            if (Palindrome)
            {
                MessageBox.Show("This string is a Palindrome string");
            }
            else
            {
                MessageBox.Show("This string is not a Palindrome string");
            }
            
        }
    }
}
