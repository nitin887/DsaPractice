/*


## Intermediate





### 9. Majority Element

**Concepts:** Moore's Voting Algorithm

### 10. Kadane's Algorithm

**Concepts:** Maximum Subarray Sum

---

## Advanced

### 11. Best Time to Buy and Sell Stock

**Concepts:** Prefix Minimum

### 12. Rearrange Array by Sign

**Concepts:** Positive-Negative Alternation

### 13. Next Permutation

**Concepts:** Permutations

### 14. Merge Overlapping Intervals

**Concepts:** Sorting + Intervals

### 15. Count Inversions in Array

**Concepts:** Divide and Conquer, Merge Sort

---

# Strings (15 Questions)

## Beginner

### 1. Reverse a String

**Concepts:** Two Pointers

### 2. Check Palindrome

**Concepts:** String Traversal

### 3. Count Vowels and Consonants

**Concepts:** Character Processing

### 4. Find Frequency of Characters

**Concepts:** Hashing

### 5. Remove Spaces from String

**Concepts:** String Manipulation

---

## Intermediate

### 6. Check Anagram

**Concepts:** Hashing, Sorting

### 7. First Non-Repeating Character

**Concepts:** HashMap

### 8. Longest Common Prefix

**Concepts:** String Matching

### 9. String Compression

**Concepts:** Run-Length Encoding

### 10. Valid Parentheses

**Concepts:** Stack

---

## Advanced

### 11. Longest Substring Without Repeating Characters

**Concepts:** Sliding Window

### 12. Longest Palindromic Substring

**Concepts:** Expand Around Center

### 13. Group Anagrams

**Concepts:** Hashing

### 14. Minimum Window Substring

**Concepts:** Sliding Window

### 15. KMP Pattern Matching

**Concepts:** LPS Array, String Algorithms

---

# Matrices (15 Questions)

## Beginner

### 1. Print Matrix Row Wise

**Concepts:** Traversal

### 2. Print Matrix Column Wise

**Concepts:** Traversal

### 3. Find Sum of All Elements

**Concepts:** Nested Loops

### 4. Find Largest Element in Matrix

**Concepts:** Traversal

### 5. Matrix Transpose

**Concepts:** Row-Column Transformation

---

## Intermediate

### 6. Add Two Matrices

**Concepts:** Matrix Operations

### 7. Matrix Multiplication

**Concepts:** Nested Loops

### 8. Diagonal Sum

**Concepts:** Matrix Traversal

### 9. Check Symmetric Matrix

**Concepts:** Transpose Property

### 10. Rotate Matrix by 90 Degrees

**Concepts:** Transpose + Reverse

---

## Advanced

### 11. Spiral Matrix Traversal

**Concepts:** Boundary Traversal

### 12. Search in Sorted Matrix

**Concepts:** Binary Search / Staircase Search

### 13. Set Matrix Zeroes

**Concepts:** Space Optimization

### 14. Sort Matrix Diagonally

**Concepts:** Hashing + Sorting

### 15. Maximum Rectangle of 1s in Binary Matrix

**Concepts:** Stack + Histogram



### Arrays

1. Largest Element
2. Second Largest
3. Move Zeroes
4. Rotate Array
5. Missing Number
6. Majority Element
7. Kadane's Algorithm
8. Best Time to Buy and Sell Stock
9. Next Permutation
10. Merge Intervals

### Strings

1. Reverse String
2. Palindrome
3. Anagram
4. Character Frequency
5. First Non-Repeating Character
6. Longest Common Prefix
7. Valid Parentheses
8. Longest Substring Without Repeating Characters
9. Group Anagrams
10. KMP

### Matrices

1. Transpose Matrix
2. Matrix Multiplication
3. Diagonal Sum
4. Rotate Matrix
5. Spiral Traversal
6. Search in Sorted Matrix
7. Set Matrix Zeroes
8. Maximum Rectangle of 1s

*/
class SecondLargestElement
{
    /*
    ### 2. Find Second Largest Element

**Concepts:** Single Pass, Comparison
    */
    static void Main()
    {
        int[] number = [9, 6, 9, 3];
        int max = number[0];
        int secondmax = 0;
        for (int i = 1; i < number.Length; i++)
        {
            if (number[i] > secondmax && number[i] != max)
            {
                secondmax = number[i];
            }






        }
        Console.WriteLine("secondmax:" + secondmax);

    }
}