class Matrix
{
    static void Main()
    {
        int[,] matrix = { { 1, 2, 3 }, { 2, 3, 4 }, { 4, 5, 6 } };
        int x = 2;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == x)
                {
                    Console.WriteLine($"element exist at {i} {j} ");

                }
            }

        }




    }
}