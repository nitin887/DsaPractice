using System.Data;
using System.Data.Common;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO.Pipelines;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices.Marshalling;
using System.Security.AccessControl;
using System.Security.Cryptography;
/*
If you're learning **Arrays in Data Structures**, it's useful to practice questions in a structured progression from beginner to advanced. Below is a categorized list of array problems along with the main concept each problem teaches.

---







# Level 7: Kadane's Algorithm

| Question                        | Concept Used       |
| ------------------------------- | ------------------ |
| Maximum subarray sum            | Kadane's Algorithm |
| Maximum circular subarray sum   | Kadane Variation   |
| Largest sum contiguous subarray | Kadane             |
| Maximum product subarray        | Dynamic Tracking   |
| Minimum subarray sum            | Kadane Variation   |

---

# Level 8: Hashing + Arrays

| Question                      | Concept Used         |
| ----------------------------- | -------------------- |
| Two Sum                       | HashMap              |
| Find duplicate element        | HashSet              |
| Find missing number           | Hashing              |
| Longest consecutive sequence  | HashSet              |
| Find majority element         | HashMap              |
| Check if two arrays are equal | HashMap              |
| Count pairs with given sum    | HashMap              |
| Subarray with zero sum        | Prefix Sum + HashMap |

---

# Level 9: Advanced Array Problems

| Question                                  | Concept Used              |
| ----------------------------------------- | ------------------------- |
| Majority Element (> n/2 times)            | Moore Voting Algorithm    |
| Majority Element II (> n/3 times)         | Extended Moore Voting     |
| Maximum Product Subarray                  | Dynamic Programming       |
| Trapping Rain Water                       | Prefix Max + Two Pointers |
| Next Greater Element                      | Stack                     |
| Stock Buy and Sell                        | Greedy                    |
| Maximum Profit with Multiple Transactions | Greedy                    |
| Find Missing and Repeating Number         | Math / XOR                |
| Rearrange Array Alternately               | Index Manipulation        |

---

# Level 10: Expert-Level Array Problems

| Question                         | Concept Used         |
| -------------------------------- | -------------------- |
| Count Inversions in Array        | Merge Sort           |
| Reverse Pairs                    | Modified Merge Sort  |
| Median of Two Sorted Arrays      | Binary Search        |
| Maximum Rectangle in Histogram   | Monotonic Stack      |
| Sliding Window Maximum           | Deque                |
| Subarray Sum Equals K            | Prefix Sum + HashMap |
| Count Smaller Numbers After Self | Merge Sort / BIT     |
| Range Sum Query Updates          | Segment Tree         |
| Kth Largest in Stream            | Heap                 |
| Sparse Table Range Minimum Query | Sparse Table         |

---

# Interview Preparation Roadmap

1. **Basics & Traversal**

   * Largest/Smallest
   * Reverse Array
   * Linear Search

2. **Manipulation**

   * Insert/Delete
   * Rotation
   * Move Zeros

3. **Searching & Sorting**

   * Binary Search
   * Kth Element
   * Dutch Flag Problem

4. **Patterns**

   * Prefix Sum
   * Two Pointers
   * Sliding Window

5. **Intermediate**

   * Two Sum
   * Kadane's Algorithm
   * Majority Element

6. **Advanced**

   * Trapping Rain Water
   * Maximum Product Subarray
   * Longest Consecutive Sequence

7. **Expert**

   * Count Inversions
   * Median of Two Sorted Arrays
   * Segment Trees
   * Range Query Problems

This sequence covers nearly all major array concepts commonly tested in coding interviews and competitive programming, progressing from fundamentals to advanced algorithmic patterns.

*/
class Revision
{
   /*         |
# Level 6: Sliding Window

| Question                                   | Concept Used           |
| ------------------------------------------ | ----------------------         |
| Longest subarray with sum K                | Sliding Window         |
| Maximum element in every window            | Deque + Sliding Window |
| Longest substring with K distinct elements | Sliding Window         |
| Minimum size subarray sum                  | Variable Window        |
| Count distinct elements in every window    | HashMap + Window       |

---

---


   */
   static void Main()
   {
      int[] arr = [1, 2, 6, 7, 8];
      int k = 9;

      // Sliding Window approach for Longest Subarray with Sum K
      // Works for arrays with non-negative elements
      int left = 0;
      int sum = 0;
      int maxLength = 0;

      for (int right = 0; right < arr.Length; right++)
      {
         // Expand window: add current element to sum
         sum += arr[right];

         // Shrink window from left if sum exceeds k
         while (sum > k && left <= right)
         {
            sum -= arr[left];
            left++;
         }

         // If sum equals k, update max length
         if (sum == k)
         {
            int currentLength = right - left + 1;
            if (currentLength > maxLength)
            {
               maxLength = currentLength;
            }
         }
      }

      Console.WriteLine("Longest subarray length with sum " + k + ": " + maxLength);
   }
}