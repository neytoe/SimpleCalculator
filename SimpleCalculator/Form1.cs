using CalculatorLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        //create the variables
       //double secondValue = 0;
        double firstValue = 0;
        string operationPerformed = "";
        bool isOperationPerformed = false;
        readonly ICalcOperator AddInjector;
        bool EqualsPressed = false;


        //constructs the form with an instance of ICalcOperator
        public Form1(ICalcOperator addInject)
        {

            InitializeComponent();
            this.AddInjector = addInject;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //this handles events that occurs when the backspace button is clicked
        //it implements by starting from the end and removes numbers added to the textbox
        private void Btn_BackSpace_Click(object sender, EventArgs e)
        {
            //text.Display represents the what is shown on the textbox
            //if the text.Display has any item then remove the last item.
            if (textDisplay.Text.Length > 0)
            {
                textDisplay.Text = textDisplay.Text.Remove(textDisplay.Text.Length - 1, 1);
            }
            //if the text.Display doesn't have any item, set the text.Display to string zero
            if (textDisplay.Text == "")
            {
                textDisplay.Text = "0";
            }
        }


        //This handles events that occurs when the number buttons and dot button is clicked
        private void Button_Number_Click(object sender, EventArgs e)
        {

            if (EqualsPressed)
            {
                textDisplay.Text = string.Empty;
                EqualsPressed = false;
            }


            if (textDisplay.Text == "0" || (isOperationPerformed)) textDisplay.Clear();
            isOperationPerformed = false;

            Button button = (Button)sender;
            if (button.Text == ".")
            {   /*if the text.Display does not contain ".", 
                 * this means that the display is either empty or it contains a number in string form,
                 * then add the "." .
                 */
                if (!textDisplay.Text.Contains("."))
                {
                    textDisplay.Text +=  button.Text;
                }
            }
            // if the button clicked is a number, add it to the textDisplay
            else
                textDisplay.Text +=  button.Text;
        }



        //This  handles events that occurs when an operator Button is clicked
        private void Operator_click(object sender, EventArgs e)
        {
            
            Button button = (Button)sender;
     
            /*if the firstValue variable is not equal to zero and equals button is not clicked,
             * then call the equalTo method.set operation performed to true
             */
            if (firstValue != 0 && !EqualsPressed)
            {
                btnEqual.PerformClick();
                operationPerformed = button.Text;
               isOperationPerformed = true;
           
            }

            
            operationPerformed = button.Text;
            firstValue = Double.Parse(textDisplay.Text);

            isOperationPerformed = true;
        }



       //This handles the events that occurs when the cancel button is clicked
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            /*clears the textDisplay, sets it zero,
        * sets the operatoraperformed variable to empty
        *  and sets the firstValue to zero.            
        */
            textDisplay.Clear();
            textDisplay.Text = "0";
            operationPerformed = "";
           firstValue = 0;
        }


        private void BtnEqual_Click(object sender, EventArgs e)
        {
            //if there is no operation performed/clicked it should return 
            if (operationPerformed == "") return;
            EqualsPressed = true;
      
            try {
                /*calls the EqualTo method which is now accessible because the instance of the class
                has been called inside this class.Performs the function and assigns the result to
                the display (text.Display)*/
                textDisplay.Text = AddInjector.EqualTo(firstValue.ToString(), textDisplay.Text, operationPerformed).ToString();
                firstValue = double.Parse(textDisplay.Text);
            }
            //catches any exception thrown and shows it in the message box
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }


        //This handles the event that occurs when the Negate button is clicked 
        private void BtnNegate_Click(object sender, EventArgs e)
        {
            /*when the text.Display is not empty,it converts the item to a double and multiplies it by -1.
             * then converts it back to a string and sets the text.Display to the string value
             */

            if(textDisplay.Text != "0")
            {
                textDisplay.Text = (double.Parse(textDisplay.Text) * -1).ToString();
            }
        }
    }
}
