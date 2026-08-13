class Revision
{
    /*
    Arrays:multiplying with adjacent
    */
    static void Main()
    {
        int[] numbers = [6, 2, 3];
        for (int i = 1; i < numbers.Length; i++)
        {
            numbers[i] = numbers[i] * numbers[i - 1];

        }
        foreach (var data in numbers)
        {
            Console.WriteLine(data);
        }


    }
}