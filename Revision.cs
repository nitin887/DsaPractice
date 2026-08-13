class Revision
{
    /*
    Arrays
    */
    static void Main()
    {
        int[] numbers = [1, 2, 3];
        bool issorted = false;
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] < numbers[i + 1])
            {
                issorted = true;
            }
            else
            {
                issorted = false;
                break;
            }

        }
        if (issorted)
        {
            Console.WriteLine("is sorted");
        }
        else
        {
            Console.WriteLine("is not sorted");
        }
    }
}