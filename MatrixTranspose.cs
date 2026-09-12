/*
### 5. Matrix Transpose

**Concepts:** Row-Column Transformation

---
*/
int[,] matrix = { { 1, 2, 3 },
                  { 3, 4, 5 },
                 { 5, 6, 7 } };
int[,] matrix1 = new int[3, 3];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix1[i, j] = matrix[j, i];


    }
}
foreach (var data in matrix)
{
    Console.WriteLine(data);
}