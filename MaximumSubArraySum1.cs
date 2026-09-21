int[] numbers = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
int currentsum = 0;
int maxsum = numbers[0];
for (int i = 1; i < numbers.Length; i++)
{
    currentsum += numbers[i - 1];
    maxsum += numbers[i];
    if (maxsum < currentsum)
    {
        maxsum = currentsum;
    }

}
Console.WriteLine(maxsum);