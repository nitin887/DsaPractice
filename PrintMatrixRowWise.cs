/*
# Matrices (15 Questions)

## Beginner

### 1. Print Matrix Row Wise

**Concepts:** Traversal

*/
int[][] number = [[1, 2, 3], [4, 5, 6], [6, 7, 8]];
for (int i = 0; i < number.GetLength(0); i++)
{
    int[] number1 = number[i];
    for (int j = 0; j < number1.Length; j++)
    {
        Console.WriteLine(number1[j]);

    }



}