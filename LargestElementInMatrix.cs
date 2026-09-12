/*
### 4. Find Largest Element in Matrix

**Concepts:** Traversal
*/
int[,] matrix = { { 1, 2 }, { 3, 4 } };
int max = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        max = 0;
        if (matrix[i, j] > max)
        {
            max = matrix[i, j];

        }


    }


}
Console.WriteLine(max);