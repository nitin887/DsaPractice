/*
### 2. Print Matrix Column Wise

**Concepts:** Traversal
*/
int[,] number = { { 1, 2, 3 }, { 2, 3, 5 }, { 4, 7, 8 } };
for (int j = 0; j < number.GetLength(0); j++)
{
    for (int i = 0; i < number.GetLength(1); i++)
    {
        Console.WriteLine(number[i, j]);

    }

}
