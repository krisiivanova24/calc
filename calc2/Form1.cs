using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace calc2
{
    public partial class Form1 : Form
    {
        double result = 0;
        double num1 = 0;
        double num2 = 0;
        List<string> allOperations = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Text += "2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(textBox1.Text, out num1))
                {
                    label3.Text += textBox1.Text + " + ";
                    textBox1.Text = "";
                }
                else
                {
                    MessageBox.Show("Бялото поле може да съдържа само числа!", "error", MessageBoxButtons.OK);
                    textBox1.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Моля, първо въведете числа от бутоните по-долу или се свъжете с администатор!");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(textBox1.Text, out num1))
                {
                    label3.Text += textBox1.Text + " - ";
                    textBox1.Text = "";
                }
                else
                {
                    MessageBox.Show("Бялото поле може да съдържа само числа!", "error", MessageBoxButtons.OK);
                    textBox1.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Моля, първо въведете числа от бутоните по-долу или се свъжете с администатор!");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(textBox1.Text, out num1))
                {
                    label3.Text += textBox1.Text + " * ";
                    textBox1.Text = "";
                }
                else
                {
                    MessageBox.Show("Бялото поле може да съдържа само числа!", "error", MessageBoxButtons.OK);
                    textBox1.Text = "";
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Моля, първо въведете числа от бутоните по-долу или се свъжете с администатор!");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(textBox1.Text, out num1))
                {
                    label3.Text += textBox1.Text + " / ";
                    textBox1.Text = "";
                }
                else
                {
                    MessageBox.Show("Бялото поле може да съдържа само числа!", "error", MessageBoxButtons.OK);
                    textBox1.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Моля, първо въведете числа от бутоните по-долу или се свъжете с администатор!");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(textBox1.Text, out num1))
                {
                    label3.Text += textBox1.Text + " ^ ";
                    textBox1.Text = "";
                }
                else
                {
                    MessageBox.Show("Бялото поле може да съдържа само числа!", "error", MessageBoxButtons.OK);
                    textBox1.Text = "";
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Моля, първо въведете числа от бутоните по-долу или се свъжете с администатор!");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(textBox1.Text, out num1))
                {
                    label3.Text += textBox1.Text + " √ ";
                    textBox1.Text = "";
                }
                else
                {
                    MessageBox.Show("Бялото поле може да съдържа само числа!", "error", MessageBoxButtons.OK);
                    textBox1.Text = "";
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Моля, първо въведете числа и тогава правете изчисления!");
                label3.Text = "";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            textBox1.Text = "";
            result = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calculate()
        {
            try
            {
                if (double.TryParse(textBox1.Text, out num1))
                {
                    string symb = label3.Text.Substring(label3.Text.Length - 2, 1);
                    double num1 = 0;
                    if (symb != "√")
                    {
                        num1 = double.Parse(label3.Text.Substring(0, label3.Text.Length - 3));
                    }

                    double num2 = double.Parse(textBox1.Text);
                    switch (symb)
                    {
                        case "+":

                            result = num1 + num2;
                            break;

                        case "-":

                            result = num1 - num2;
                            break;

                        case "*":

                            result = num1 * num2;
                            break;

                        case "/":

                            result = num1 / num2;
                            break;

                        case "^":

                            result = Math.Pow(num1, num2);
                            break;

                        case "√":

                            result = Math.Sqrt(num2);
                            break;
                    }
                    label3.Text = result.ToString();
                    textBox1.Text = "";
                }
                else
                {
                    MessageBox.Show("Бялото поле може да съдържа само числа!", "error", MessageBoxButtons.OK);
                    textBox1.Text = "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Моля, не изчислявайте преди да сте задали числа или изчислявайте последователно!", "error", MessageBoxButtons.OK);
                label3.Text = "";
            }
        }
    }


}
