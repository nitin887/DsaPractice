class Linearsearch
{
    public void Searching(int[] arr, int target, int n)
    {
        for (int i = 0; i < n; i++)
        {
            if (arr[i] == target)
            {
                Console.WriteLine("Element at index:" + i);
            }

        }



    }
    static void Main()
    {
        int[] number = { 4, 5, 2, 1 };
        int n = number.Length;
        int target = 1;
        Linearsearch linearsearch = new Linearsearch();
        linearsearch.Searching(number, target, n);
    }
}