using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUnitTestApp
{
    internal class OperationClass : IOperation
    {
        public string Operation(string input)
        {
            
                if(input == null)
                    throw new ArgumentNullException("input");
                int value;
            if (int.TryParse(input, out value))
            {
                if (value % 3 == 0 && value % 5 == 0)
                    return "FizzBuzz";
                else if (value % 3 == 0)
                    return "Fizz";
                else if (value % 5 == 0)
                    return "Buzz";
                else
                    return value.ToString();
            }
            else
                throw new ArgumentException("input is not integer");
                   
            
        }
    }
}
