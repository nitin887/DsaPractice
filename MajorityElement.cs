/*
### 9. Majority Element

**Concepts:** Moore's Voting Algorithm
*/
class MajorityElement
{
    static void Main()
    {
        int[] number = [1, 2, 3, 1, 1, 1];
        int count = 0;
        int candidate = -1;
        foreach (int nums in number)
        {
            if (count == 0)
            {
                candidate = nums;
                count++;

            }
            else
            {
                count--;
            }

        }
        count = 0;
        foreach (int nums1 in number)
        {
            if (nums1 == candidate)
            {
                count++;
            }
        }
        int minority = number.Length - count;
        int Majority = count;
        if (Majority > minority)
        {
            Console.WriteLine("candidate is:" + candidate);
        }
        else
        {
            Console.WriteLine("no majority present");
        }



    }
}