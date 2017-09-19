/*
 * Author:      Dante Jones
 * CLID:        daj3817
 * Class:       CMPS 358
 * Assignment:  Project 1
 * Due Date:    11:55pm / 20 March 2017
 * Description: I am using a windows form in this project to create a calculator.
 * I cerifty that this program was done by myself.
 */

using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p1_daj3817
{
    public partial class FormCalculator : Form
    {
        //to save textbox value
        double num = 0;

        //save the answer
        double numAnswer = 0;

        //queue saves the operands to do the math function during equal
        Queue aQueue = new Queue();

        public FormCalculator()
        {
            InitializeComponent();
        }

        private void FormCalculator_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //align the text to the right
            textBox1.TextAlign = HorizontalAlignment.Right;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBox selection for clear
            if (comboBox1.SelectedIndex == 0)
            {
                //clear reset textBox text
                textBox1.ResetText();

                //reset num and numAnswer
                numAnswer = 0;
                num = 0;
            }
            //comboBox selection for quit
            else if (comboBox1.SelectedIndex == 1)
            {
                //close program
                this.Close();
            }
        }

        private void buttonBksp_Click(object sender, EventArgs e)
        {
            try
            {
                //remove the back char of textBox text
                textBox1.Text = textBox1.Text.Remove(textBox1.TextLength - 1);
            }
            catch { }
            

        }

        private void buttonClr_Click(object sender, EventArgs e)
        {
            //clear textBox text
            textBox1.ResetText();
            numAnswer = 0;
            num = 0;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            //check if num = 0 then clear text
            if (num == 0) { textBox1.ResetText(); }

            //placing 0 to the back of the textBox text
            textBox1.AppendText(Convert.ToString(0));

            //convert text to double save value in num
            num = Convert.ToDouble(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //check if num = 0 then clear text
            if (num == 0) { textBox1.ResetText(); }

            //placing 1 to the back of the textBox text
            textBox1.AppendText(Convert.ToString(1));

            //convert text to double save value in num
            num = Convert.ToDouble(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //check if num = 0 then clear text
            if (num == 0) { textBox1.ResetText(); }

            //placing 2 to the back of the textBox text
            textBox1.AppendText(Convert.ToString(2));

            //convert text to double save value in num
            num = Convert.ToDouble(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //check if num = 0 then clear text
            if (num == 0) { textBox1.ResetText(); }

            //placing 3 to the back of the textBox text
            textBox1.AppendText(Convert.ToString(3));

            //convert text to double save value in num
            num = Convert.ToDouble(textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //check if num = 0 then clear text
            if (num == 0) { textBox1.ResetText(); }

            //placing 4 to the back of the textBox text
            textBox1.AppendText(Convert.ToString(4));

            //convert text to double save value in num
            num = Convert.ToDouble(textBox1.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //check if num = 0 then clear text
            if (num == 0) { textBox1.ResetText(); }

            //placing 5 to the back of the textBox text
            textBox1.AppendText(Convert.ToString(5));

            //convert text to double save value in num
            num = Convert.ToDouble(textBox1.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //check if num = 0 then clear text
            if (num == 0) { textBox1.ResetText(); }

            //placing 6 to the back of the textBox text
            textBox1.AppendText(Convert.ToString(6));

            //convert text to double save value in num
            num = Convert.ToDouble(textBox1.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //check if num = 0 then clear text
            if (num == 0) { textBox1.ResetText(); }

            //placing 7 to the back of the textBox text
            textBox1.AppendText(Convert.ToString(7));

            //convert text to double save value in num
            num = Convert.ToDouble(textBox1.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //check if num = 0 then clear text
            if (num == 0) { textBox1.ResetText(); }

            //placing 8 to the back of the textBox text
            textBox1.AppendText(Convert.ToString(8));

            //convert text to double save value in num
            num = Convert.ToDouble(textBox1.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //check if num = 0 then clear text
            if (num == 0) { textBox1.ResetText(); }

            //placing 9 to the back of the textBox text
            textBox1.AppendText(Convert.ToString(9));

            //convert text to double save value in num
            num = Convert.ToDouble(textBox1.Text);
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            //check if num = 0 then clear text
            if (num == 0) { textBox1.ResetText(); }
            
            //placing the text into a charArray then checking if it contains '.'
            char[] charArray = textBox1.Text.ToCharArray();
            if (charArray.Contains('.')) { }
            else
            {
                textBox1.AppendText(".");
                //num = 1 so that the . will be saved
                num = 1;
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            //catch error if just pressing +
            try
            {
                //convert text to double save value in num
                num = Convert.ToDouble(textBox1.Text);


                //numAnswer = num
                numAnswer += num;

                //reset num enqueue + sign
                num = 0;
                aQueue.Enqueue('+');
            }
            catch { }
        }

        private void buttonNeg_Click(object sender, EventArgs e)
        {
            //catch error if just pressing -
            try
            {
                //convert text to double save value in num
                num = Convert.ToDouble(textBox1.Text);

                //numAnswer = num
                numAnswer -= num;

                //reset num enqueue - sign
                num = 0;
                aQueue.Enqueue('-'); ;
            }
            catch { }
            
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            //catch error if just pressing *
            try
            {
                //convert text to double save value in num
                num = Convert.ToDouble(textBox1.Text);

                //check if numAnswer = 0 if so make numAnser = 1 to save num
                if (numAnswer == 0) { numAnswer = 1; }

                //numAnswer = num
                numAnswer *= num;

                //reset num and enqueue * sign
                num = 0;
                aQueue.Enqueue('*');
            }
            catch { }
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            //catch error if just pressing /
            try
            {
                //convert text to double save value in num
                num = Convert.ToDouble(textBox1.Text);

                //check if numAnswer = 0 if so make numAnser = 1 to save num
                if (numAnswer == 0) { numAnswer = 1; }

                //numAnswer = num
                numAnswer = num / numAnswer;

                //reset num and enqueue / sign
                num = 0;
                aQueue.Enqueue('/');
            }
            catch { }
        }

        private void buttonInverse_Click(object sender, EventArgs e)
        {
            //catch error if just pressing +/-
            try
            {
                //convert text to double save value in i         
                double i = Convert.ToDouble(textBox1.Text);

                //check if i is greater than 0 if so make the textBox text a negative 
                if (i > 0)
                    textBox1.Text = "-" + textBox1.Text;
                //else make it a positive
                else
                    textBox1.Text = Convert.ToString(-1 * i);
            }
            catch { }
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            //search the queue for operand signs
            foreach (char element in aQueue)
            {
                if (element == '+')
                {
                    //convert text to double save it in num so that nothing entered would still do math
                    num = Convert.ToDouble(textBox1.Text);

                    //add num to numAnswer
                    numAnswer += num;

                    //reset num
                    num = 0;
                }
                else if (element == '-')
                {
                    //convert text to double save it in num so that nothing entered would still do math
                    num = Convert.ToDouble(textBox1.Text);

                    //minus num to numAnswer
                    numAnswer -= num;

                    //reset num
                    num = 0;
                }
                else if (element == '*')
                {
                    //convert text to double save it in num so that nothing entered would still do math
                    num = Convert.ToDouble(textBox1.Text);

                    //multiply num to numAnswer
                    numAnswer *= num;

                    //reset num
                    num = 0;
                }
                else if (element == '/')
                {
                    //convert text to double save it in num so that nothing entered would still do math
                    num = Convert.ToDouble(textBox1.Text);

                    //divide num to numAnswer
                    numAnswer /= num;

                    //reset num
                    num = 0;
                }
            }

            //reset queue 
            for (int i = 0; i <= aQueue.Count; i++)
                aQueue.Dequeue();

            
            //Convert numAnswer to string so that it can be seen as textBox text
            textBox1.Text = Convert.ToString(numAnswer);

            //placing the text into a charArray then checking if it contains '.'
            char[] charArray = textBox1.Text.ToCharArray();  
            if (charArray.Contains('.'))
            {
                //convert to decimal for one decimal place operation
                decimal num2 = Convert.ToDecimal(numAnswer);
                textBox1.Text = String.Format("{0:0.0}", num2);
            }
            
            //rest numAnswer
            numAnswer = 0;
        }

    }
}
