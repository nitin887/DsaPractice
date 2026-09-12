/*
### 6. Add Two Matrices

**Concepts:** Matrix Operations

*/
using System.Collections;

int[,] matrix1 = { { 1, 2, 3 }, { 3, 4, 5 }, { 6, 7, 8 } };
int[,] matrix2 = { { 1, 2, 3 }, { 3, 4, 5 }, { 6, 7, 8 } };
int[,] matrix3 = new int[3, 3];
for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix1.GetLength(1); j++)
    {
        matrix3[i, j] = matrix1[i, j] + matrix2[i, j];
        Console.Write(matrix3[i, j]);


    }
    Console.WriteLine();

}
