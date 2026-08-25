class RotateAnArrayByKPosition
{
    static void Swap(int[] number, int start, int end)
    {
        while (start <= end)
        {
            (number[start], number[end]) = (number[end], number[start]);
            start++;
            end--;
        }

    }
    static void Rotation(int[] number, int k)
    {
        int start = 0;
        int end = number.Length - 1;
        Swap(number, start, k - 1);
        Swap(number, k, end);
        Swap(number, start, end);




    }
    static void Main()
    {
        int[] number = [1, 2, 3, 4, 5];
        int k = 3;
        Rotation(number, k);
        foreach (int x in number)
        {
            Console.WriteLine(x);
        }
    }
}