using ConsoleLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParmonicConsoleApp
{
    public class ProgramManager
    {
        #region Fields
        private IConsoleManager consoleManager = null;
        #endregion

        #region Constructors
        public ProgramManager(IConsoleManager consoleManager)
        {
            this.consoleManager = consoleManager;
        }
        #endregion

        #region Methods
        public void Run(string[] args)
        {
            string input = string.Empty;                
            consoleManager.Write("Please enter a valid int number: ");
               
               input = consoleManager.ReadLine().Trim();
            if (string.IsNullOrEmpty(input.Trim()))
            {
                consoleManager.Write("Invalid input");                
            }
            else
            {
                int value;
                if (int.TryParse(input, out value))
                {

                    if (value % 3 == 0 && value % 5 == 0)
                    {
                        consoleManager.WriteLine("FizzBuzz");
                    }
                    else if (value % 3 == 0)
                    {
                        consoleManager.WriteLine("Fizz");
                    }
                    else if (value % 5 == 0)
                    {
                        consoleManager.WriteLine("Buzz");
                    }
                    else
                        consoleManager.WriteLine(value.ToString());
             
                }
                else
                {
                    consoleManager.Write("Invalid input");                  
                }
            }
            consoleManager.ReadKey();
        }
        #endregion
    }
}
