using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Calculator

{
    public partial class Form1 : Form
    {
        List<string> operator_ = new List<string>();
        List<float> number_ = new List<float>();
        string number = "";

        public Form1()
        {
            InitializeComponent();
            button1.Text = "1";
            button2.Text = "2";
            button3.Text = "3";
            button4.Text = "4";
            button5.Text = "5";
            button6.Text = "6";
            button7.Text = "7";

            button8.Text = "8";
            button9.Text = "9";
            button10.Text = "0";
            button11.Text = ".";
            button12.Text = "/";
            button13.Text = "+";
            button14.Text = "-";
            button15.Text = "*";
            button16.Text = "=";
            button17.Text = "C";

        }
        
      


        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";

        }
        //liste mit zahlen 2 te liste mit operatoren
        private void button16_Click(object sender, EventArgs e)
        {
            
            number_.Clear();
            operator_.Clear();
            number = "";
            int Opcount = 0; 
            foreach (char ss in textBox1.Text)
            {
                if (ss.ToString() == "+"|| ss.ToString() == "-" || ss.ToString() == "*" || ss.ToString() == "/")
                {
                    
                    Opcount++;
                    operator_.Add(ss.ToString());
                    

                    number_.Add(float.Parse(number));
                    number = "";

                }
                else
                {
                    number += ss.ToString();


                }
               
            }
            number_.Add(float.Parse(number));

            float value = number_[0];
            for (int tc = 1; tc < number_.Count; tc++)
            {
                textBox1.Text = (tc - 1).ToString();
                
                if (operator_[tc - 1] == "+")
                {
                    textBox1.Text = (tc-1).ToString();
                    value =  value + number_[tc];
                    
                }
                if (operator_[tc - 1] == "-")
                {
                    value = value - number_[tc];
                }

                if (operator_[tc - 1] == "*")
                {
                    value = value * number_[tc];
                }
                if (operator_[tc - 1] == "/")
                {
                    value = value / number_[tc];
                }






            }
            
            string kk = value.ToString();
            textBox2.Text = $"\r\n->{kk}{textBox2.Text}";


            textBox1.Text = value.ToString();
            
            








        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";

        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";

        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";

        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
