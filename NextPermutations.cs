/*
### 13. Next Permutation

**Concepts:** Permutations
*/
class NextPermutations
{
    static void Main()
    {
        int[] number = [1, 2, 3, 4, 3, 2, 1];
        int pivot = 0;
        int successor = 0;
        for (int i = number.Length - 1; i > 0; i--)
        {
            if (number[i] > number[i - 1])
            {
                pivot = i;
                break;



            }



        }
        for (int i = number.Length - 1; i > 0; i--)
        {
            if (number[i] < number[i - 1])
            {
                successor = i;
                break;

            }

        }

        (number[successor], number[pivot]) = (number[pivot], number[successor]);

        int start = pivot + 1;
        int end = number.Length - 1;
        while (start < end)
        {
            (number[start], number[end]) = (number[end], number[start]);
            start++;
            end--;

        }
        for (int i = 0; i < number.Length; i++)
        {
            Console.WriteLine(number[i]);

        }








    }
}