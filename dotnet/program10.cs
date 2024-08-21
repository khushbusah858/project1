/*using system;

class Program10
{
    static void Main()
    {
        // Prompt the user to enter an alphabet
        Console.Write("Enter an alphabet: ");
        char input = Console.ReadKey().KeyChar;

        // Convert input to lowercase to simplify comparison
        char lowerInput = char.ToLower(input);

        // Check if the input is a letter
        if (!char.IsLetter(lowerInput))
        {
            Console.WriteLine("\nPlease enter a valid alphabet character.");
            return;
        }

        // Use switch statement to determine if the alphabet is a vowel or consonant
        switch (lowerInput)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                Console.WriteLine("\nThe alphabet is a vowel.");
                break;
            default:
                Console.WriteLine("\nThe alphabet is a consonant.");
                break;
        }
    }
}
*/
