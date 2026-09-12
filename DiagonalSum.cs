/*
### 8. Diagonal Sum

**Concepts:** Matrix Traversal

*/
using System.Collections;

int[,] matrix = { { 1, 2, 3 }, { 3, 4, 5 }, { 5, 6, 7 } };
int sum = 0;
int n = matrix.GetLength(0);

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         if (i == j)
//         {
//             sum += matrix[i, j];

//         }
//         else if (i + j == n - 1)
//         {
//             sum += matrix[i, j];

//         }



//     }

// }
//optimised version
for (int i = 0; i < n; i++)
{
    sum += matrix[i, i];


    sum += matrix[i, n - 1 - i];

}
if (n % 2 == 1)
{
    sum -= matrix[n / 2, n / 2];
}
Console.WriteLine(sum);

