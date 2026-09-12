
class Hashing
{
    static void Main()
    {
        int[] arr = [4, 5, 7, 8];
        int[] arr1 = new int[arr.Length];
        int[] arr2 = new int[arr.Length];

        int m = 6;


        //division method
        for (int i = 0; i <= arr.Length - 1; i++)
        {
            int hashFunction = i % m;
            arr1[i] = hashFunction;
        }
        foreach (int x in arr1)
        {
            Console.WriteLine(arr[x]);
        }
        //Mid square method
        for (int i = 0; i <= arr.Length - 1; i++)
        {
            int hashFunction = i * i;
            while (hashFunction > 0)
            {
                int remainder = hashFunction % 10;
                arr2[i] = remainder;
                hashFunction = hashFunction / 10;

            }




        }
        for (int i = 0; i <= arr2.Length - 1; i++)
        {
            Console.Write(arr[i]);
        }

    }
}