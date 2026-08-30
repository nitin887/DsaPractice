/*
### 12. Rearrange Array by Sign

**Concepts:** Positive-Negative Alternation

*/
using System.Runtime.Serialization.Json;

class ReArrangeArrayBySign
{
    static void Main()
    {
        int[] number = [1, 2, 3, -4, -6, 3, 2];
        List<int> positive = new List<int>();
        List<int> negative = new List<int>();
        for (int i = 0; i < number.Length; i++)
        {
            if (number[i] > 0)
            {
                positive.Add(number[i]);
            }
            else if (number[i] < 0)
            {
                negative.Add(number[i]);
            }
        }
        int pos = 0;
        int neg = 0;
        for (int i = 0; i < number.Length - 1; i++)
        {
            if (i % 2 == 0 && pos < positive.Count)
            {
                number[i] = positive[pos];

                pos++;
            }
            else if (i % 2 == 1 && neg < negative.Count)
            {
                number[i] = negative[neg];

                neg++;

            }


        }
        foreach (int data in number)
        {
            Console.WriteLine(data);
        }

    }
}