using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLibrary
{
    public interface ICalcOperator
    {
        //This interface acts as a blueprint for the CalcOperator class


        //The Add method the CalcOperator class should implement
        public double Add(string firstNumber, string LastNumber);


        //The subtract method the CalcOperator class should implement
        public double Subtract(string firstNumber, string LastNumber);


        //The Divide method the CalcOperator class should implement
        public double Divide(string firstNumber, string LastNumber);


        //The Multiply method the CalcOperator class should implement
        public double Multiply(string firstNumber, string LastNumber);


        //The EqualTo method the CalcOperator class should implement
        public double EqualTo(string firstNumber, string lastNumber, string Operator);
    }
}
