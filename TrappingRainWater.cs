int[] rainwater = { 4, 2, 0, 3, 2, 5 };
int totalrainwater = 0;
int left = 0;
int right = rainwater.Length - 1;
int leftMax = 0;
int rightMax = 0;

// Two pointer approach - O(n) time, O(1) space
while (left < right)
{
    if (rainwater[left] <= rainwater[right])
    {
        // left side is the lower boundary, so water here depends on leftMax
        if (rainwater[left] >= leftMax)
        {
            leftMax = rainwater[left];
        }
        else
        {
            totalrainwater += leftMax - rainwater[left];
        }
        left++;
    }
    else
    {
        // right side is the lower boundary, so water here depends on rightMax
        if (rainwater[right] >= rightMax)
        {
            rightMax = rainwater[right];
        }
        else
        {
            totalrainwater += rightMax - rainwater[right];
        }
        right--;
    }
}
Console.WriteLine("total available rainwater:" + totalrainwater);

// Alternative approach using prefix and suffix max - O(n) time, O(n) space
// int[] leftMax = new int[rainwater.Length];
// int[] rightMax = new int[rainwater.Length];
// int totalrainwater = 0;

// leftMax[0] = rainwater[0];
// for (int i = 1; i < rainwater.Length; i++)
// {
//     leftMax[i] = Math.Max(leftMax[i - 1], rainwater[i]);
// }

// rightMax[rainwater.Length - 1] = rainwater[rainwater.Length - 1];
// for (int i = rainwater.Length - 2; i >= 0; i--)
// {
//     rightMax[i] = Math.Max(rightMax[i + 1], rainwater[i]);
// }

// for (int i = 0; i < rainwater.Length; i++)
// {
//     totalrainwater += Math.Min(leftMax[i], rightMax[i]) - rainwater[i];
// }
// Console.WriteLine("total available rainwater:" + totalrainwater);