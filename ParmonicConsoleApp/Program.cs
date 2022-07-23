using ConsoleLib;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ParmonicConsoleApp
{
     class Program
    {
        #region Fields
        private static ProgramManager programManager = null;
        private static IConsoleManager consoleManager = null;
        #endregion

        static void Main(string[] args)
        {
            StandardKernel kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            consoleManager = kernel.Get<IConsoleManager>();

            programManager = new ProgramManager(consoleManager);
            programManager.Run(args);
        }
    }
}
