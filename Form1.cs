using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FinalExam_topping
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            // Button 3 - Multiply
            if (double.TryParse(textBox1.Text, out double num1) && double.TryParse(textBox2.Text, out double num2))
            {
                double result = num1 * num2;
                listBox1.Items.Add($"Multiplication Result: {result}");
            }
            else
            {
                listBox1.Items.Add("Invalid input. Please enter valid numbers.");
            }
        }

        private void compareButton_Click(object sender, EventArgs e)
        {
            // Button 4 - Compare
            if (double.TryParse(textBox1.Text, out double num1) && double.TryParse(textBox2.Text, out double num2))
            {
                if (num1 > num2)
                    listBox1.Items.Add($"{num1} is bigger than {num2}");
                else if (num1 < num2)
                    listBox1.Items.Add($"{num2} is bigger than {num1}");
                else
                    listBox1.Items.Add($"{num1} and {num2} are equal");
            }
            else
            {
                listBox1.Items.Add("Invalid input. Please enter valid numbers.");
            }
        }

        private void forLoopButton_Click(object sender, EventArgs e)
        {
            // Button 5 - For Loop
            listBox1.Items.Add("Numbers 1 to 10:");
            for (int i = 1; i <= 10; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Button 6 - Clear
            listBox1.Items.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Button 7 - Exit
            Close();
        }

        private void methodWithReturnValueButton_Click(object sender, EventArgs e)
        {
            // Button 8 - Method with Return Value
            string message = GetMessageFromMethod();
            listBox1.Items.Add(message);
        }

        private string GetMessageFromMethod()
        {
            // Method for Button 8
            return "This button calls a method in step #8.";
        }

        private void methodWithOutputButton_Click(object sender, EventArgs e)
        {
            // Button 9 - Method with Output
            DisplayMessageFromMethod();
        }

        private void DisplayMessageFromMethod()
        {
            // Method for Button 9
            listBox1.Items.Add("The method #9 has been called.");
        }

        private void arrayButton_Click(object sender, EventArgs e)
        {
            // Button 10 - Array
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            listBox1.Items.Add("Array Values:");
            foreach (int value in array)
            {
                listBox1.Items.Add(value);
            }
        }
    }
}
