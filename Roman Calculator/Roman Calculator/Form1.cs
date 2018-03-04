using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roman_Calculator
{
    public partial class Form1 : Form
    {
        //the string for holding the attributes to the switch
        private string input;

        //holding the first input
        private int[] firstNumber = new int[] { 0, 1 };

        //global value of the result to use throughout the program
        private int result;

        // variable to hold the value of the input (converted to int)
        private int number;


        public Form1()
        {
            InitializeComponent();
        }

        //the buttons made for input. They also add a physical number to private int number
        private void btnOne_Click(object sender, EventArgs e)
        {
            input = input + "I";
            InAndOutPutBox.Text = input;
            number = number + 1;
        }
        
        private void btnFour_Click(object sender, EventArgs e)
        {
            input = input + "IV";
            InAndOutPutBox.Text = input;
            number = number + 4 ;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            input = input + "V";
            InAndOutPutBox.Text = input;
            number = number + 5;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            input = input + "IX";
            InAndOutPutBox.Text = input;
            number = number + 9;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            input = input + "X";
            InAndOutPutBox.Text = input;
            number = number + 10;
        }

        private void btnForty_Click(object sender, EventArgs e)
        {
            input = input + "XL";
            InAndOutPutBox.Text = input;
            number = number + 40;
        }

        private void btnFifty_Click(object sender, EventArgs e)
        {
            input = input + "L";
            InAndOutPutBox.Text = input;
            number = number + 50;
        }

        private void btnNinety_Click(object sender, EventArgs e)
        {
            input = input + "XC";
            InAndOutPutBox.Text = input;
            number = number + 90;
        }

        private void btnHundred_Click(object sender, EventArgs e)
        {
            input = input + "C";
            InAndOutPutBox.Text = input;
            number = number + 100;
        }

        private void btnFourHundred_Click(object sender, EventArgs e)
        {
            input = input + "CD";
            InAndOutPutBox.Text = input;
            number = number + 400;
        }

        private void btnFiveHundred_Click(object sender, EventArgs e)
        {
            input = input + "D";
            InAndOutPutBox.Text = input;
            number = number + 500;
        }

        private void btnNineHundred_Click(object sender, EventArgs e)
        {
            input = input + "CM";
            InAndOutPutBox.Text = input;
            number = number + 900;
        }

        private void btnThousand_Click(object sender, EventArgs e)
        {
            input = input + "M";
            InAndOutPutBox.Text = input;
            number = number + 1000;
        }

        //the stirng use for the slection in the swicth
        string output;

        //the button setting up the switch for add
        private void btnAddUp_Click(object sender, EventArgs e)
        {
            if (input == null)
            {
                firstNumber[0] = 0;
                InAndOutPutBox.Text = "0";
            }
            else
            {
                try
                {
                    firstNumber[0] = number;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Wrong entry.Try again!");
                }
            }
           
            //this sets the switch to add up
            output = "+";

            //clearing the variables for the second input
            input = "";
            InAndOutPutBox.Text = String.Empty;
            number = 0;
        }

        //the button setting up the switch for subtraction
        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (input == null)
            {
                firstNumber[0] = 0;
                InAndOutPutBox.Text = "0";
            }
            else
            {
                try
                {
                    firstNumber[0] = number;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Wrong entry.Try again!");
                }
            }

            //this sets the switch to subtract
            output = "-";

            //clearing the variables for second input
            input = "";
            InAndOutPutBox.Text = String.Empty;
            number = 0;
        }

        //the button setting up the switch for division
        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (input == null)
            {
                firstNumber[0] = 0;
                InAndOutPutBox.Text = "0";
            }
            else
            {
                try
                {
                    firstNumber[0] = number;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Wrong entry.Try again!");
                }
            }

            //this sets the switch to divide
            output = "/";

            //clearing the variables for second input
            input = "";
            InAndOutPutBox.Text = String.Empty;
            number = 0;
        }

        //the button setting up the switch for multiplying
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (input == null)
            {
                firstNumber[0] = 0;
                InAndOutPutBox.Text = "0";
            }
            else
            {
                try
                {
                    firstNumber[0] = number;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Wrong entry.Try again!");
                }
            }

            //this sets the switch to multiply
            output = "*";

            //clearing the variables for second input
            input = "";
            InAndOutPutBox.Text = String.Empty;
            number = 0;
        }

        //the button clears all the variables and sets the int[] to 0
        private void btnClear_Click(object sender, EventArgs e)
        {
            input = String.Empty;
            firstNumber[0] = 0;
            firstNumber[1] = 0;
            number = 0;
            InAndOutPutBox.Text = String.Empty;
            labelTest.Text = String.Empty;

            //setting the buttons in the on status
            btnAddUp.Enabled        = true;
            btnSubtract.Enabled     = true;
            btnDivide.Enabled       = true;
            btnMultiply.Enabled     = true;
            btnEquals.Enabled       = true;
            btnOne.Enabled          = true;
            btnFour.Enabled         = true;
            btnFive.Enabled         = true;
            btnNine.Enabled         = true;
            button3.Enabled         = true;
            btnForty.Enabled        = true;
            btnFifty.Enabled        = true;
            btnNinety.Enabled       = true;
            btnHundred.Enabled      = true;
            btnFourHundred.Enabled  = true;
            btnFiveHundred.Enabled  = true;
            btnNineHundred.Enabled  = true;
            btnThousand.Enabled     = true;
        }

        //here the calculations are made. The calculations depend on the "output" string.
        //from here the program goes to the recursive Calculation(int numberIs)
        private void btnEquals_Click(object sender, EventArgs e)
        {
            switch (output)
            {
                case "+":
                    
                    firstNumber[1] = number;
                    InAndOutPutBox.Text = String.Empty;
                    input = String.Empty;
                    if (input == null)
                    {
                        InAndOutPutBox.Text = String.Empty;
                    }
                    else
                        
                        result = firstNumber[0] + firstNumber[1];
                    if (result != 0)
                    {
                        Calculation(result);
                         //InAndOutPutBox.Text = String.Empty;
                    }
                    if(result == 0)
                    {
                        break;
                    }
                    break;
                case "-":
                    firstNumber[1] = number;
                    InAndOutPutBox.Text = String.Empty;
                    input = String.Empty;
                    if (input == null)
                    {
                        InAndOutPutBox.Text = String.Empty;
                    }
                    else

                        result = firstNumber[0] - firstNumber[1];
                    if (result != 0)
                    {
                        Calculation(result);
                    }
                    break;
                case "*":
                    firstNumber[1] = number;
                    InAndOutPutBox.Text = String.Empty;
                    input = String.Empty;
                    if (input == null)
                    {
                        InAndOutPutBox.Text = String.Empty;
                    }
                    else

                        result = firstNumber[0] * firstNumber[1];
                    if (result != 0)
                    {
                        Calculation(result);
                    }
                    break;
                case "/":
                    firstNumber[1] = number;
                    InAndOutPutBox.Text = String.Empty;
                    input = String.Empty;
                    if (input == null)
                    {
                        InAndOutPutBox.Text = String.Empty;
                    }
                    else

                        result = firstNumber[0] / firstNumber[1];
                    if (result != 0)
                    {
                        Calculation(result);
                    }
                    break;
                default:
                    break;
            }
            //showing the result in arabic numbers
            labelTest.Text = Convert.ToString(result);

            //setting the buttons in the off status
            btnAddUp.Enabled        = false;
            btnSubtract.Enabled     = false;
            btnDivide.Enabled       = false;
            btnMultiply.Enabled     = false;
            btnEquals.Enabled       = false;
            btnOne.Enabled          = false;
            btnFour.Enabled         = false;
            btnFive.Enabled         = false;
            btnNine.Enabled         = false;
            button3.Enabled         = false;
            btnForty.Enabled        = false;
            btnFifty.Enabled        = false;
            btnNinety.Enabled       = false;
            btnHundred.Enabled      = false;
            btnFourHundred.Enabled  = false;
            btnFiveHundred.Enabled  = false;
            btnNineHundred.Enabled  = false;
            btnThousand.Enabled     = false;
        }

        //the recursive part of the progra that handles the amount of visual aspect that will be shown in the InAndOutPutBox
        //it iterates just as long as the numberIs is not 0. After it reaches 0 the program breaks
        private void Calculation(int numberIs)
        {
            for (int i = 0; i <= numberIs + 1; i++)
            {

                if (numberIs == 0 || numberIs > 3999)
                { 
                    break;
                }
                if (numberIs == 0)
                {
                    input = String.Empty;
                }
                if (numberIs >= 1000 && numberIs < 3999)
                {
                    InAndOutPutBox.Text = InAndOutPutBox.Text + "M ";
                    numberIs = numberIs - 1000;
                }
                if (numberIs >= 900 && numberIs < 1000)
                {
                    InAndOutPutBox.Text = InAndOutPutBox.Text + "CM ";
                    numberIs = numberIs - 900;
                }
                if (numberIs >= 500 && numberIs < 900)
                {
                    InAndOutPutBox.Text = InAndOutPutBox.Text + "D ";
                    numberIs = numberIs - 500;
                }
                if (numberIs >= 400 && numberIs < 500)
                {
                    InAndOutPutBox.Text = InAndOutPutBox.Text + "CD ";
                    numberIs = numberIs - 400;
                }
                if (numberIs >= 100 && numberIs < 900)
                {
                    InAndOutPutBox.Text = InAndOutPutBox.Text + "C";
                    numberIs = numberIs - 100;
                }
                if (numberIs >= 90 && numberIs < 100)
                {
                    InAndOutPutBox.Text = InAndOutPutBox.Text + "XC ";
                    numberIs = numberIs - 90;
                }
                if (numberIs >= 50 && numberIs < 90)
                {
                    InAndOutPutBox.Text = InAndOutPutBox.Text + "L ";
                    numberIs = numberIs - 50;
                }
                if (numberIs >= 40 && numberIs < 50)
                {
                    InAndOutPutBox.Text = InAndOutPutBox.Text + "XL ";
                    numberIs = numberIs - 40;
                }
                if (numberIs >= 10 && numberIs < 40)
                {
                    InAndOutPutBox.Text = InAndOutPutBox.Text + "X ";
                    numberIs = numberIs - 10;
                }
                if (numberIs == 9)
                {
                    InAndOutPutBox.Text = InAndOutPutBox.Text + "IX ";
                    numberIs = numberIs - 9;
                }
                if (numberIs >= 5 && numberIs < 9)
                {
                    InAndOutPutBox.Text = InAndOutPutBox.Text + "V ";
                    numberIs = numberIs - 5;
                }
                if (numberIs >= 4 && numberIs < 5)
                {
                    InAndOutPutBox.Text = InAndOutPutBox.Text + "IV ";
                    numberIs = numberIs - 4;
                }
                if (numberIs >= 1 && numberIs < 5)
                {
                    InAndOutPutBox.Text = InAndOutPutBox.Text + "I ";
                    numberIs = numberIs - 1;
                }
            }
                if(numberIs > 3999)
                {
                    MessageBox.Show("Exit et magnis" + Environment.NewLine + "Deze grote ontgaat zelfs mij!");

                    //setting the buttons in the off status
                    btnAddUp.Enabled        = false;
                    btnSubtract.Enabled     = false;
                    btnDivide.Enabled       = false;
                    btnMultiply.Enabled     = false;
                    btnEquals.Enabled       = false;
                    btnOne.Enabled          = false;
                    btnFour.Enabled         = false;
                    btnFive.Enabled         = false;
                    btnNine.Enabled         = false;
                    button3.Enabled         = false;
                    btnForty.Enabled        = false;
                    btnFifty.Enabled        = false;
                    btnNinety.Enabled       = false;
                    btnHundred.Enabled      = false;
                    btnFourHundred.Enabled  = false;
                    btnFiveHundred.Enabled  = false;
                    btnNineHundred.Enabled  = false;
                    btnThousand.Enabled     = false;

                }
        }       
    }
}


