/*using System;

class Program5
{
    static void Main()
    {
        // Prompt the user to enter the first number
        Console.Write("Enter the first number: ");
        // Read and convert the input to a double
        double num1 = Convert.ToDouble(Console.ReadLine());

        // Prompt the user to enter the second number
        Console.Write("Enter the second number: ");
        // Read and convert the input to a double
        double num2 = Convert.ToDouble(Console.ReadLine());

        // Prompt the user to enter the operator
        Console.Write("Enter an operator (+, -, *, /): ");
        // Read the operator as a string
        string operatorInput = Console.ReadLine();

        // Initialize a variable to store the result
        double result = 0;

        // Perform the operation based on the operator
        switch (operatorInput)
        {
            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":
                // Check for division by zero
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                    return;
                }
                break;
            default:
                Console.WriteLine("Error: Invalid operator.");
                return;
        }

        // Display the result
        Console.WriteLine($"The result of {num1} {operatorInput} {num2} is: {result}");
    }
}
*/