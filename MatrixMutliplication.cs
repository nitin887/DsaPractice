/*
### 7. Matrix Multiplication

**Concepts:** Nested Loops

*/
int[,] matrix = { { 1, 2, 3 }, { 3, 4, 5 }, { 5, 6, 7 } };
int[,] matrix1 = { { 1, 2, 3 }, { 3, 4, 5 }, { 5, 6, 7 } };
int[,] matrix2 = new int[3, 3];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            matrix2[i, j] += matrix[i, k] * matrix1[k, j];

        }

    }

}
foreach (var data in matrix2)
{
    Console.WriteLine(data);
}
