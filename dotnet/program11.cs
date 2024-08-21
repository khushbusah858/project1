/*using system;

class Program
{
    static void Main()
    {
        // Input dimensions for the first matrix
        Console.WriteLine("Enter the number of rows for Matrix A:");
        int rowsA = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of columns for Matrix A (also the number of rows for Matrix B):");
        int colsA = int.Parse(Console.ReadLine());

        // Input dimensions for the second matrix
        Console.WriteLine("Enter the number of columns for Matrix B:");
        int colsB = int.Parse(Console.ReadLine());

        // Declare matrices
        int[,] matrixA = new int[rowsA, colsA];
        int[,] matrixB = new int[colsA, colsB];
        int[,] resultMatrix = new int[rowsA, colsB];

        // Input values for Matrix A
        Console.WriteLine("Enter the elements of Matrix A:");
        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < colsA; j++)
            {
                Console.Write($"MatrixA[{i}, {j}] = ");
                matrixA[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Input values for Matrix B
        Console.WriteLine("Enter the elements of Matrix B:");
        for (int i = 0; i < colsA; i++)
        {
            for (int j = 0; j < colsB; j++)
            {
                Console.Write($"MatrixB[{i}, {j}] = ");
                matrixB[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Perform matrix multiplication
        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < colsB; j++)
            {
                resultMatrix[i, j] = 0;
                for (int k = 0; k < colsA; k++)
                {
                    resultMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }

        // Display the result matrix
        Console.WriteLine("Result of Matrix Multiplication:");
        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < colsB; j++)
            {
                Console.Write(resultMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}*/
