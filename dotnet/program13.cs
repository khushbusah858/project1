using System;

class Program13
{
    static void Main()
    {
        // Define a string array with some example values
        string[] stringArray = { "Apple", "Banana", "Cherry", "Date", "Elderberry" };

        // Convert the string array to a single string with a specified separator
        string result = string.Join(", ", stringArray);

        // Display the result
        Console.WriteLine("The concatenated string is:");
        Console.WriteLine(result);
    }
}
