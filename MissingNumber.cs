class MissingNumber
{

    static void Main()
    {
        int[] number = [1, 2, 3, 4, 6, 9];
        for (int i = 0; i < number.Length - 1; i++)
        {
            if (number[i + 1] - number[i] != 1)
            {
                Console.WriteLine("missing Number is :" + (number[i] + 1));

            }

        }
    }
}