int[][] number = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];
for (int i = 0; i < number.Length; i++)
{
    int[] number1 = number[i];

    for (int j = 0; j < number.GetLength(0); j++)

    {
        if (i == 0 || i == 1 && j == i + 1)
        {
            (number[i][j], number[j][i]) = (number[j][i], number[i][j]);
        }
    }
    Array.Reverse(number1);
}
foreach (int[] name in number)
{
    foreach (int numbers in name)
    {
        Console.WriteLine(numbers);
    }
}