/*using system;

class Program
{
    static void Main()
    {
        // Prompt user for the number of marks
        Console.Write("Enter the number of .NET technology marks: ");
        int numberOfMarks = int.Parse(Console.ReadLine());

        // Declare an array to store the marks
        double[] marks = new double[numberOfMarks];

        // Input marks from the user
        for (int i = 0; i < numberOfMarks; i++)
        {
            Console.Write($"Enter mark {i + 1}: ");
            marks[i] = double.Parse(Console.ReadLine());
        }

        // Initialize variables to find min, max, and average
        double minMark = marks[0];
        double maxMark = marks[0];
        double sum = 0;

        // Calculate min, max, and sum
        for (int i = 0; i < marks.Length; i++)
        {
            if (marks[i] < minMark)
                minMark = marks[i];
            if (marks[i] > maxMark)
                maxMark = marks[i];
            sum += marks[i];
        }

        // Calculate average
        double averageMark = sum / marks.Length;

        // Display results
        Console.WriteLine($"Minimum Mark: {minMark}");
        Console.WriteLine($"Maximum Mark: {maxMark}");
        Console.WriteLine($"Average Mark: {averageMark}");
    }
}
*/