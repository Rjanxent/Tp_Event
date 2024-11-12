using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorPrivateAssembly;
using System.Windows.Forms;


namespace BasicCalculator
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();

            comboBox1.Items.Add("Add");
            comboBox1.Items.Add("Subtract");
            comboBox1.Items.Add("Multiply");
            comboBox1.Items.Add("Divide");
            comboBox1.SelectedIndex = 0;
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            float num1, num2;
            if (!float.TryParse(textBox1.Text, out num1) || !float.TryParse(textBox2.Text, out num2))
            {
                textBox3.Text = "Invalid input. Please enter numbers.";
                return;
            }

            // Determine the selected operation
            string operation = comboBox1.SelectedItem.ToString();
            try
            {
                float result = 0;
                switch (operation)
                {
                    case "Add":
                        result = BasicComputation.Add(num1, num2);
                        break;
                    case "Subtract":
                        result = BasicComputation.Subtract(num1, num2);
                        break;
                    case "Multiply":
                        result = BasicComputation.Multiply(num1, num2);
                        break;
                    case "Divide":
                        result = BasicComputation.Divide(num1, num2);
                        break;
                    default:
                        textBox3.Text = "Please select an operation.";
                        return;
                }
                textBox3.Text = $"Result: {result}";
            }
            catch (DivideByZeroException ex)
            {
                textBox3.Text = ex.Message;
            }
        }
    }
}
