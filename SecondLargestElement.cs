
class SecondLargestElement
{
    /*
    ### 2. Find Second Largest Element

**Concepts:** Single Pass, Comparison
    */
    static void Main()
    {
        int[] number = [9, 6, 9, 3];
        int max = number[0];
        int secondmax = 0;
        for (int i = 1; i < number.Length; i++)
        {
            if (number[i] > secondmax && number[i] != max)
            {
                secondmax = number[i];
            }






        }
        Console.WriteLine("secondmax:" + secondmax);

    }
}