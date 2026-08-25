
class ReverseAnArray
{
    static void Main()
    {
        int[] number = [6, 5, 3, 4];
        int i = 0;
        int j = number.Length - 1;
        while (j >= i)
        {
            Console.WriteLine(number[j]);
            j--;
        }



    }
}