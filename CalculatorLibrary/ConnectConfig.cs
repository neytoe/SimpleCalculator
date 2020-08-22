using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLibrary
{
    public static class ConnectConfig
    {   //creates an instance of the calcoperator class using IcalcOperator

        public static ICalcOperator MyCalc = new CalcOperator();
    }
}
