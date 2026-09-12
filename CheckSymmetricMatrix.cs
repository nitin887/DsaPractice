/*
### 9. Check Symmetric Matrix

**Concepts:** Transpose Property
*/
int[,] matrix = { { 1, 4 }, { 4, 3 } };
int[,] matrix1 = new int[2, 2];
bool IsSame = false;
for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix1.GetLength(1); j++)
    {
        matrix1[j, i] = matrix[i, j];

    }
}
for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix1.GetLength(1); j++)
    {
        if (matrix[i, j] == matrix1[i, j])
        {
            IsSame = true;
        }
        else
        {
            IsSame = false;
            break;
        }


    }
}

if (IsSame)
{
    Console.WriteLine("symmetric matrix");

}
else
{
    Console.WriteLine("non symmteric matrix");
}

