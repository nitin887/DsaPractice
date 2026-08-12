class Matrix
{
    // Sorts each column of the matrix in ascending order
    static int[,] SortColumns(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int col = 0; col < cols; col++)
        {
            // Bubble sort the current column
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < rows - i - 1; j++)
                {
                    if (matrix[j, col] > matrix[j + 1, col])
                    {
                        (matrix[j, col], matrix[j + 1, col]) = (matrix[j + 1, col], matrix[j, col]);
                    }
                }
            }
        }
        return matrix;
    }

    // Prints the matrix in a readable format
    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        int[,] matrix = { { 2, 7, 11 }, { 3, 5, 6 }, { 1, 10, 9 } };

        Console.WriteLine("Original Matrix:");
        PrintMatrix(matrix);

        int[,] sorted = SortColumns(matrix);

        Console.WriteLine("\nMatrix after sorting each column:");
        PrintMatrix(sorted);
    }
}