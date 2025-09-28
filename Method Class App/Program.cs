using System; // Brings in the System namespace, which contains fundamental classes like Console

namespace ConsoleApp
{
    // Define a class named MathOperations
    class MathOperations
    {
        // This is a void method that takes two integers as parameters
        public void PerformOperation(int num1, int num2)
        {
            // Perform a math operation on the first integer (e.g., multiply by 10)
            int result = num1 * 10;

            // Display the result of the math operation
            Console.WriteLine("Result of num1 * 10 is: " + result);

            // Display the second integer to the screen
            Console.WriteLine("The second integer (num2) is: " + num2);
        }
    }

    // Main Program class
    class Program
    {
        // The entry point of the console application
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Call the method using positional arguments
            // Pass 5 as num1 and 10 as num2
            mathOps.PerformOperation(5, 10);

            // Call the method using named arguments
            // Explicitly specify the parameter names
            mathOps.PerformOperation(num1: 7, num2: 20);

            // Wait for user input before closing the console (optional)
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
