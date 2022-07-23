using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUnitTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Input :
            Console.WriteLine("Enter input :");
            var input = Console.ReadLine();
            IOperation obj = new OperationClass();
            Console.WriteLine( obj.Operation(input));
            Console.WriteLine("Do you want to make operation again ? press 'y' for Yes or 'n' for No ");
             var userAction=  Console.ReadLine();
            if (userAction != null && userAction == "y")
                goto Input;
         
        }
    }
}
