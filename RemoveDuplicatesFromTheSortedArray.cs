class RemoveDuplicatesFromTheSortedArray
{
    static void Main()
    {
        List<int> number = [1, 2, 2, 3, 4, 5, 5, 6, 6];
        for (int i = 0; i < number.Count - 1; i++)
        {
            if (number[i] == number[i + 1])
            {
                number.Remove(number[i]);
            }

        }
        foreach (int x in number)
        {
            Console.WriteLine(x);
        }

    }

}