using CalculatorLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /*it injects the  instance of the calcOperator class created in the ConnectConfig class
             * into the form(calculator form)
             */
            
            Application.Run(new Form1(ConnectConfig.MyCalc));
        }
    }
}
