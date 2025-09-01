using System;

class Program
{
    static void Main()
    {
        // Display welcome message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt user for the weight of the package
        Console.Write("Please enter the package weight: ");
        double weight;
        // Try to parse the input to a double
        bool isWeightValid = double.TryParse(Console.ReadLine(), out weight);

        // Check if input is valid and if weight exceeds limit
        if (!isWeightValid || weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return; // End the program
        }

        // Prompt for width
        Console.Write("Please enter the package width: ");
        double width;
        bool isWidthValid = double.TryParse(Console.ReadLine(), out width);

        // Prompt for height
        Console.Write("Please enter the package height: ");
        double height;
        bool isHeightValid = double.TryParse(Console.ReadLine(), out height);

        // Prompt for length
        Console.Write("Please enter the package length: ");
        double length;
        bool isLengthValid = double.TryParse(Console.ReadLine(), out length);

        // Check for valid dimension inputs
        if (!isWidthValid || !isHeightValid || !isLengthValid)
        {
            Console.WriteLine("Invalid input for dimensions. Please enter numeric values.");
            return; // End the program
        }

        // Check if total dimensions exceed the maximum allowed
        double dimensionTotal = width + height + length;
        if (dimensionTotal > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return; // End the program
        }

        // Calculate the quote:
        // Multiply width, height, and length, then multiply by weight
        // Divide by 100 to get the final quote
        double quote = (width * height * length * weight) / 100;

        // Display the quote formatted as currency
        Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("0.00"));
        Console.WriteLine("Thank you!");
    }
}
