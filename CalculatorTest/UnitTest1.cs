using CalculatorLibrary;
using System;
using Xunit;

namespace CalculatorTest
{
    //Unit test to verify all methods are working as it should
    public class UnitTest1
    {
        [Fact]
        #region AddMethodTest
        //This test that the Add method outputs correctly
        public void AddOperator()
        {
            //Arrange
            /*The num1 and num2 is a string because the Add method receives a string
           as input and parses it into a double */
            var num1 = "15";
            var num2 = "16";
           
            /*creates and instance of the CalcOperator class to enable the test access the Add 
           method*/
            var operation = new CalcOperator();
            var expected = 31;

            //Act
            var actual = operation.Add(num1, num2);
          

            //Assert
            Assert.Equal(actual, expected);
        }
        #endregion


        [Fact]
        #region SubtractMethodTest
        //This test that the subtract method outputs correctly
        public void SubtractOperator()
        {
            //Arrange
            /*The num1 and num2 is a string because the subtract method receives a string
            as input and parses it into a double */
            var num1 = "15";
            var num2 = "16";

            /*creates and instance of the CalcOperator class to enable the test access the subtract 
            method*/
            var operation = new CalcOperator();
            var expected = -1;

            //Act
            var actual= operation.Subtract(num1, num2);
            

            //Assert
            Assert.Equal(actual, expected);
        }
        #endregion


        [Fact]
        #region DivideMethodTest
        //This test that the Divide method outputs correctly
        public void DivideOperator()
        {
            //Arrange
            /*The num1 and num2 is a string because the Divide method receives a string
           as input and parses it into a double */
            var num1 = "15";
            var num2 = "16";
            /*creates an instance of the CalcOperator class to enable the test access the Divide 
           method*/
            var operation = new CalcOperator();
            var expected = 0.9375;

            //Act
            var actual= operation.Divide(num1, num2);
            

            //Assert
            Assert.Equal(actual, expected);
        }
        #endregion


        [Fact]
        #region MultiplyMethodTest
        //This test that the Multiply method outputs correctly
        public void MultiplyOperator()
        {
            //Arrange
            /*The num1 and num2 is a string because the Multiply method receives a string
           as input and parses it into a double */
            var num1 = "15";
            var num2 = "16";
            /*creates an instance of the CalcOperator class to enable the test access the Multiply 
           method*/
            var operation = new CalcOperator();
            var expected = 240;
           
            //Act
            var actual = operation.Multiply(num1, num2);
           

            //Assert
            Assert.Equal(actual, expected);
        }
        #endregion


        [Fact]
        #region CheckDivisionByZeroError
        //This test verifies that an error is returned if a number is divided by zero
        public void CheckDivisionError()
        {
            //Arrange
            var num1 = "20";
            var num2 = "0";
            CalcOperator operation = new CalcOperator();

            //Assert
            Assert.Throws<DivideByZeroException>(
                () => operation.Divide(num1, num2)
            );
        }
        #endregion
    }
}
