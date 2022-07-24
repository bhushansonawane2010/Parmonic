using ConsoleLib;
using ParmonicConsoleApp;

namespace ParmonicConsoleAppTests.Test
{
    public class UnitTest1
    {
        #region Fields
        private ConsoleManagerStub consoleManager = null;
        private ProgramManager programManager = null;
        #endregion

        public UnitTest1()
        {
            consoleManager = new ConsoleManagerStub();
            programManager = new ProgramManager(consoleManager);
        }


        [Theory]
        [InlineData("3")]
        public void TestForValidConditionFizz(string input)
        {
            consoleManager.UserInputs.Enqueue(input);
            consoleManager.UserInputs.Enqueue(new ConsoleKeyInfo());

            List<string> expectedOutput = new List<string>();
            expectedOutput.Add("Please enter a valid int number: ");
            expectedOutput.Add("Please enter a valid int number: 3\r\n");            
            expectedOutput.Add("Please enter a valid int number: 3\r\nFizz\r\n");
         
            
            consoleManager.OutputsUpdated += (int outputEntryNumber) => {
                Assert.Equal(expectedOutput[outputEntryNumber - 1], consoleManager.ToString());
            };

            programManager.Run(new string[] { });

        }

        [Theory]
        [InlineData("5")]
        public void TestForValidConditionBuzz(string input)
        {
            consoleManager.UserInputs.Enqueue(input);
            consoleManager.UserInputs.Enqueue(new ConsoleKeyInfo());

            List<string> expectedOutput = new List<string>();
            expectedOutput.Add("Please enter a valid int number: ");
            expectedOutput.Add("Please enter a valid int number: 5\r\n");
            expectedOutput.Add("Please enter a valid int number: 5\r\nBuzz\r\n");


            consoleManager.OutputsUpdated += (int outputEntryNumber) => {
                Assert.Equal(expectedOutput[outputEntryNumber - 1], consoleManager.ToString());
            };

            programManager.Run(new string[] { });

        }
        [Theory]
        [InlineData("15")]
        public void TestForValidConditionFizzBuzz(string input)
        {
            consoleManager.UserInputs.Enqueue(input);
            consoleManager.UserInputs.Enqueue(new ConsoleKeyInfo());

            List<string> expectedOutput = new List<string>();
            expectedOutput.Add("Please enter a valid int number: ");
            expectedOutput.Add("Please enter a valid int number: 15\r\n");
            expectedOutput.Add("Please enter a valid int number: 15\r\nFizzBuzz\r\n");


            consoleManager.OutputsUpdated += (int outputEntryNumber) => {
                Assert.Equal(expectedOutput[outputEntryNumber - 1], consoleManager.ToString());
            };

            programManager.Run(new string[] { });

        }

        [Theory]
        [InlineData(" ")]
        public void TestForInvalidValidEmptyCondition(string input)
        {
            consoleManager.UserInputs.Enqueue(input);
            consoleManager.UserInputs.Enqueue(new ConsoleKeyInfo());

            List<string> expectedOutput = new List<string>();
            expectedOutput.Add("Please enter a valid int number: ");
            expectedOutput.Add("Please enter a valid int number:  \r\n");
            expectedOutput.Add("Please enter a valid int number:  \r\nInvalid input");


            consoleManager.OutputsUpdated += (int outputEntryNumber) => {
                Assert.Equal(expectedOutput[outputEntryNumber - 1], consoleManager.ToString());
            };

            programManager.Run(new string[] { });

        }
        [Theory]
        [InlineData("abc")]
        public void TestForInvalidValidInput(string input)
        {
            consoleManager.UserInputs.Enqueue(input);
            consoleManager.UserInputs.Enqueue(new ConsoleKeyInfo());

            List<string> expectedOutput = new List<string>();
            expectedOutput.Add("Please enter a valid int number: ");
            expectedOutput.Add("Please enter a valid int number: abc\r\n");
            expectedOutput.Add("Please enter a valid int number: abc\r\nInvalid input");


            consoleManager.OutputsUpdated += (int outputEntryNumber) => {
                Assert.Equal(expectedOutput[outputEntryNumber - 1], consoleManager.ToString());
            };

            programManager.Run(new string[] { });

        }
        [Theory]
        [InlineData("13")]
        public void TestForValidConditionButNotdivideby3or5(string input)
        {
            consoleManager.UserInputs.Enqueue(input);
            consoleManager.UserInputs.Enqueue(new ConsoleKeyInfo());

            List<string> expectedOutput = new List<string>();
            expectedOutput.Add("Please enter a valid int number: ");
            expectedOutput.Add("Please enter a valid int number: 13\r\n");
            expectedOutput.Add("Please enter a valid int number: 13\r\n13\r\n");


            consoleManager.OutputsUpdated += (int outputEntryNumber) => {
                Assert.Equal(expectedOutput[outputEntryNumber - 1], consoleManager.ToString());
            };

            programManager.Run(new string[] { });

        }
    }
}