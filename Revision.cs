/*
# Phase 3: String Fundamentals

## Easy

### 31. Count Vowels

### 32. Count Consonants

### 33. Count Digits

### 34. Count Spaces

### 35. Reverse a String

### 36. Check Palindrome String

Examples:

```
madam
racecar
```

### 37. Convert Lowercase to Uppercase

### 38. Convert Uppercase to Lowercase

### 39. Find Length Without Using Length Property

### 40. Remove White Spaces

---

## Easy-Medium

### 41. Count Frequency of Characters

### 42. Find First Non-Repeated Character

### 43. Find First Repeated Character

### 44. Check Anagram

Example:

```
listen
silent
```

### 45. Remove Duplicate Characters

### 46. Reverse Words in Sentence

Example:

```
I Love CSharp

Output:
CSharp Love I
```

### 47. Check if String Contains Only Digits

### 48. Find Longest Word in Sentence

### 49. Toggle Case

### 50. Sort Characters of String

---

# Phase 4: String Interview Patterns

### 51. Longest Common Prefix

### 52. Valid Parentheses

### 53. Roman Number to Integer

### 54. String Compression

### 55. Implement strstr()

### 56. Longest Substring Without Repeating Characters

### 57. Group Anagrams

### 58. Minimum Window Substring

### 59. Count and Say

### 60. Longest Palindromic Substring

---

# Phase 5: Matrix Fundamentals

## Easy

### 61. Print Matrix

### 62. Sum of Matrix Elements

### 63. Row Wise Sum

### 64. Column Wise Sum

### 65. Largest Element in Matrix

### 66. Smallest Element in Matrix

### 67. Primary Diagonal Sum

### 68. Secondary Diagonal Sum

### 69. Transpose of Matrix

### 70. Check Identity Matrix

---

## Easy-Medium

### 71. Check Symmetric Matrix

### 72. Add Two Matrices

### 73. Subtract Two Matrices

### 74. Matrix Multiplication

### 75. Rotate Matrix 90 Degrees

### 76. Reverse Each Row

### 77. Print Boundary Elements

### 78. Print Upper Triangle

### 79. Print Lower Triangle

### 80. Search Element in Matrix

---

# Phase 6: Matrix Interview Questions

### 81. Spiral Traversal

### 82. Set Matrix Zeroes

### 83. Rotate Image

### 84. Search in Sorted Matrix

### 85. Diagonal Traversal

### 86. Wave Traversal

### 87. Snake Pattern

### 88. Find Saddle Point

### 89. Count Islands (Matrix + DFS)

### 90. Flood Fill Algorithm

---

# Challenge Questions (After Completing Above)

### Arrays

91. Two Sum

92. Three Sum

93. Product of Array Except Self

94. Trapping Rain Water

95. Maximum Product Subarray

---

### Strings

96. KMP Pattern Matching

97. Rabin Karp

98. Z Algorithm

99. Edit Distance

100. Word Break
*/
/*



### 23. Find Majority Element

### 24. Kadane's Algorithm (Maximum Subarray Sum)

### 25. Stock Buy and Sell

### 26. Rearrange Positive and Negative Numbers

### 27. Leaders in an Array

### 28. Longest Consecutive Sequence

### 29. Find Duplicate Number

### 30. Merge Two Sorted Arrays

---
*/



class Revision
{
    /*
### 22. Find Element Appearing Once

  */
    static void Main()
    {

        int[] number = [1, 2, 3, 3, 1, 6, 5];
        Dictionary<int, int> numbers = new Dictionary<int, int>();
        int k = 1;
        for (int i = 0; i < number.Length; i++)
        {
            if (!numbers.ContainsKey(number[i]))
            {
                numbers.Add(number[i], k);
            }
            else
            {
                numbers[number[i]] += k;
            }

        }
        foreach (var number1 in numbers)
        {
            if (number1.Value == 1)
            {
                Console.WriteLine(number1.Key);
            }
        }







    }
}
