/*
If you want to cover **hashing in DSA comprehensively using C#**, it's best to practice questions from beginner to advanced. Here's a topic-wise list that covers nearly every important hashing concept used in coding interviews and competitive programming.

# 1. HashMap / Dictionary Basics

Use `Dictionary<TKey, TValue>` in C#.

### Easy

1. Count frequency of each element in an array.
2. Count frequency of characters in a string.
3. Find the first non-repeating character.
4. Find the first repeating character.
5. Find the most frequent element.
6. Check if two arrays have the same frequencies.
7. Find all duplicate elements.
8. Remove duplicates from an array.
9. Find frequency of words in a paragraph.
10. Sort elements by frequency.

---

# 2. Lookup-Based Problems

### Easy–Medium

11. Two Sum.
12. Contains Duplicate.
13. Contains Duplicate II.
14. Check if pair with given sum exists.
15. Check if pair with given difference exists.
16. Find all pairs with a given sum.
17. Count pairs with a given sum.
18. Find common elements in two arrays.
19. Find intersection of two arrays.
20. Find union of two arrays.

---

# 3. HashSet Problems

Use `HashSet<T>`.

### Easy–Medium

21. Longest consecutive sequence.
22. Find missing number from 1 to n.
23. Check if array contains consecutive integers.
24. Count distinct elements.
25. Find unique elements.
26. Check if two arrays are disjoint.
27. Detect cycle in sequence generation.
28. Happy Number.
29. Find all unique triplets.
30. Longest streak of numbers.

---

# 4. Prefix Sum + Hashing

Very important for interviews.

### Medium

31. Subarray with given sum.
32. Count subarrays with given sum.
33. Largest subarray with sum 0.
34. Count subarrays with sum 0.
35. Longest subarray with equal 0s and 1s.
36. Count subarrays divisible by K.
37. Longest subarray divisible by K.
38. Binary array with equal 0 and 1.
39. Continuous Subarray Sum.
40. Maximum length subarray with target sum.

---

# 5. String Hashing Fundamentals

### Medium

41. Check if two strings are anagrams.
42. Group Anagrams.
43. Valid Anagram.
44. Find all anagram occurrences.
45. Isomorphic Strings.
46. Word Pattern.
47. Ransom Note.
48. Find duplicate words.
49. Longest substring without repeating characters.
50. Count distinct substrings.

---

# 6. Sliding Window + Hashing

### Medium

51. Longest substring without repeating characters.
52. Minimum Window Substring.
53. Permutation in String.
54. Find all anagrams in a string.
55. Longest substring with K distinct characters.
56. Fruit Into Baskets.
57. Longest repeating character replacement.
58. Smallest window containing all characters.
59. Count distinct elements in every window.
60. Maximum unique substring.

---

# 7. Advanced Frequency Map Problems

### Medium

61. Top K frequent elements.
62. Top K frequent words.
63. Sort characters by frequency.
64. Frequency stack.
65. Majority Element.
66. Majority Element II.
67. Find all elements occurring more than n/k times.
68. Reorganize String.
69. Hand of Straights.
70. Task Scheduler.

---

# 8. Hashing with Arrays

### Medium

71. Count pairs whose XOR equals K.
72. Count triplets with XOR equal.
73. Subarray XOR equals K.
74. Largest subarray with equal frequencies.
75. Distinct elements in every window.
76. Count equal pairs.
77. Find symmetric pairs.
78. Relative sort array.
79. Check if array can be paired.
80. Longest arithmetic subsequence.

---

# 9. Custom Hashing Concepts

### Medium–Hard

81. Design HashMap.
82. Design HashSet.
83. Implement LRU Cache.
84. Implement LFU Cache.
85. Design Twitter.
86. Insert Delete GetRandom O(1).
87. Randomized Set.
88. Randomized Collection.
89. Design URL Shortener.
90. Consistent Hashing simulation.

---

# 10. Rolling Hash (Rabin-Karp)

### Hard

91. Implement Rabin-Karp algorithm.
92. Pattern searching.
93. Multiple pattern matching.
94. Longest duplicate substring.
95. Repeated DNA sequences.
96. Distinct substrings using hashing.
97. String matching with rolling hash.
98. Find repeated patterns.
99. Longest common substring.
100. Palindrome substring detection using hashes.

---

# 11. Double Hashing

### Hard

101. Implement double hashing.
102. Avoid collisions in string matching.
103. Longest duplicate substring using double hash.
104. Distinct substring count.
105. Palindrome checking with hashes.

---

# 12. Polynomial Hashing

### Hard

106. String hashing implementation.
107. Compare substrings in O(1).
108. Longest common prefix queries.
109. String equality queries.
110. Dynamic string matching.

---

# 13. Hashing in Graphs

### Hard

111. Detect duplicate subtrees.
112. Graph isomorphism hashing.
113. Tree serialization hashing.
114. Subtree matching.
115. Tree fingerprinting.

---

# 14. Interview-Favorite Hard Questions

116. Longest Consecutive Sequence.
117. Group Anagrams.
118. Subarray Sum Equals K.
119. Minimum Window Substring.
120. Insert Delete GetRandom O(1).
121. LRU Cache.
122. LFU Cache.
123. Repeated DNA Sequences.
124. Longest Duplicate Substring.
125. Distinct Subsequences using Hashing.

---

# Top 20 Must-Do Questions

If preparing for interviews, prioritize:

1. Two Sum
2. Contains Duplicate
3. Valid Anagram
4. Group Anagrams
5. Longest Consecutive Sequence
6. Subarray Sum Equals K
7. Largest Subarray with Sum 0
8. Count Subarrays with Sum K
9. Longest Substring Without Repeating Characters
10. Minimum Window Substring
11. Find All Anagrams in a String
12. Top K Frequent Elements
13. Majority Element
14. Happy Number
15. Continuous Subarray Sum
16. Distinct Elements in Every Window
17. Insert Delete GetRandom O(1)
18. LRU Cache
19. Rabin-Karp Algorithm
20. Longest Duplicate Substring

These 125 questions cover virtually all hashing topics you'll encounter in DSA interviews using C#, from `Dictionary` and `HashSet` to rolling hashes, Rabin-Karp, and hash-based system design problems.

*/
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