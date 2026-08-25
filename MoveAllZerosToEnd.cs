class MoveAllZerosTOEnd
{
    static void Main()
    {
        int[] number = [1, 0, 6, 7, 0, 5, 0];
        int i = 0;
        int j = 0;
        int k = number.Length - 1;
        while (j <= k)
        {
            if (number[j] != 0)
            {
                (number[i], number[j]) = (number[j], number[i]);
                i++;
            }
            j++;


        }

        foreach (int x in number)
        {
            Console.WriteLine(x);
        }
    }
}