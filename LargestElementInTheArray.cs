
class LargestElementInTheArray
{

    static void Main()
    {
        int[] number = [1, 2, 3, 4, 5];
        int max = number[0];
        for (int i = 1; i < number.Length; i++)
        {
            if (number[i] > max)
            {
                max = number[i];

            }

        }
        Console.WriteLine(max);
    }
}
