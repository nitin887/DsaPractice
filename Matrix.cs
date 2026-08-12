class Matrix
{
    static void Main()
    {
        int[,] matrix = { { 2, 3, 1 }, { 7, 5, 6 }, { 11, 10, 9 } };
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Sort each column independently (bubble sort per column)
        for (int j = 0; j < cols; j++)
        {
            for (int i = 0; i < rows - 1; i++)
            {
                for (int m = 0; m < rows - i - 1; m++)
                {
                    if (matrix[m, j] > matrix[m + 1, j])
                    {
                        (matrix[m, j], matrix[m + 1, j]) = (matrix[m + 1, j], matrix[m, j]);
                    }
                }
            }
        }

        // Print the sorted matrix
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}