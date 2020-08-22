using System;
using System.Runtime.CompilerServices;

namespace CalculatorLibrary
{
    //This class inherits the from the ICalcOperator
    public class CalcOperator : ICalcOperator
    {

        //This implements the add method 
        #region The Add method
        //This receives the input method from the calculator as a string
        //converts to a double and performs the addition of the two inputs
        public double Add (string firstNumber, string LastNumber)
        {

            return double.Parse(firstNumber) + double.Parse(LastNumber);
        }
        #endregion



        //This implements the subtract method 
        #region The Subtract Method
        //it receives the input method from the calculator as a string
        //converts to a double and performs the subtraction of the two inputs
        public double Subtract(string firstNumber, string LastNumber)
        {

            return double.Parse(firstNumber) - double.Parse(LastNumber);
        }
        #endregion



        //This implements the Divide method 
        #region The Divide Method

        //This receives the input method from the calculator as a string
        //converts to a double and performs the Division of the two inputs
        public double Divide(string firstNumber, string LastNumber)
        {
            if(LastNumber == "0")
            {
                //checks if the second item clicked is zero and throws an error
                throw new DivideByZeroException();
            }
            return double.Parse(firstNumber) / double.Parse(LastNumber);
        }
        #endregion




        //This implements the Multiply method 
        #region The Multiply Method

        //This receives the input method from the calculator as a string
        //converts to a double and performs the Multiplication of the two inputs
        public double Multiply(string firstNumber, string LastNumber)
        {

            return double.Parse(firstNumber) * double.Parse(LastNumber);
        }
        #endregion




        //This implements the EqualTo method 
        #region The EqualTo Method
        //This receives the input method  and operator from the calculator as a string
        //converts to a double and performs the received Operator method for the two inputs
        public double EqualTo (string firstNumber, string LastNumber,string Operator )
        {
            double result = 0;

            switch (Operator)
            {
                case "+":
                 result=Add(firstNumber, LastNumber);
                    break;
                case "-":
                  result=Subtract(firstNumber, LastNumber);
                    break;
                case "×":
                  result= Multiply(firstNumber, LastNumber);
                    break;
                case "÷":
                  result=Divide(firstNumber, LastNumber);
                    break;
                default:
                    break;


            }

            return result;
            

        }
        #endregion

    }
}
