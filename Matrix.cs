class Matrix
{

    static void Main()
    {
        int[,] number ={{3,6,10},
                        {1,4,5},
                        {2,8,9}};

        Console.WriteLine("Original Matrix:");
        PrintMatrix(number);

        // Column-wise sorting (ascending order)
        for (int col = 0; col < number.GetLength(1); col++)
        {
            // Bubble sort the current column
            for (int pass = 0; pass < number.GetLength(0) - 1; pass++)
            {
                for (int row = 0; row < number.GetLength(0) - 1 - pass; row++)
                {
                    if (number[row, col] > number[row + 1, col])
                    {
                        (number[row, col], number[row + 1, col]) = (number[row + 1, col], number[row, col]);
                    }
                }
            }
        }

        Console.WriteLine("\nMatrix after column-wise sorting:");
        PrintMatrix(number);
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}