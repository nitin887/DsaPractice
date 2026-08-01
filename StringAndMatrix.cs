/*
## String Data Structure Questions (Basic → Advanced)



### Level 2: Intermediate String Problems

| Question                                   | Concept Used        |
| ------------------------------------------ | ------------------- |
| Find first non-repeating character         | HashMap             |
| Find first repeating character             | Hashing             |
| Check if two strings are anagrams          | Sorting / Hashing   |
| Remove duplicate characters                | HashSet             |
| Count occurrences of a substring           | Pattern Matching    |
| Find longest word in a sentence            | Parsing             |
| Replace spaces with `%20`                  | String Manipulation |
| Check if one string is rotation of another | Concatenation       |
| Find all permutations of a string          | Recursion           |
| Sort characters by frequency               | HashMap + Sorting   |

---

### Level 3: Sliding Window on Strings

| Question                                       | Concept Used             |
| ---------------------------------------------- | ------------------------ |
| Longest substring without repeating characters | Sliding Window           |
| Longest substring with K distinct characters   | Sliding Window           |
| Minimum window substring                       | Sliding Window + HashMap |
| Find all anagrams in a string                  | Sliding Window           |
| Maximum consecutive ones after K replacements  | Sliding Window           |
| Longest repeating character replacement        | Sliding Window           |
| Smallest window containing all characters      | Sliding Window           |

---

### Level 4: Advanced String Algorithms

| Question                      | Concept Used           |
| ----------------------------- | ---------------------- |
| Implement strstr()            | Naive Pattern Matching |
| KMP Pattern Matching          | Prefix Function        |
| Rabin-Karp Algorithm          | Rolling Hash           |
| Z Algorithm                   | Pattern Matching       |
| Longest Common Prefix         | String Matching        |
| Longest Palindromic Substring | Expand Around Center   |
| Count Palindromic Substrings  | Dynamic Programming    |
| Edit Distance                 | Dynamic Programming    |
| Longest Common Subsequence    | DP                     |
| Longest Common Substring      | DP                     |

---

### Level 5: Expert-Level String Problems

| Question                      | Concept Used     |
| ----------------------------- | ---------------- |
| Word Break Problem            | DP               |
| Regular Expression Matching   | DP               |
| Wildcard Matching             | DP               |
| Trie-based Dictionary Search  | Trie             |
| Shortest Common Supersequence | DP               |
| Suffix Array Construction     | Advanced Strings |
| Longest Repeated Substring    | Suffix Array     |
| String Compression            | Greedy           |
| Text Justification            | Simulation       |
| Distinct Subsequences         | DP               |

---

# Matrix Questions (Basic → Advanced)

### Level 1: Matrix Basics

| Question                           | Concept Used      |
| ---------------------------------- | ----------------- |
| Print matrix row-wise              | Traversal         |
| Print matrix column-wise           | Traversal         |
| Find sum of all elements           | Traversal         |
| Find largest element in matrix     | Traversal         |
| Find smallest element in matrix    | Traversal         |
| Count even and odd elements        | Traversal         |
| Add two matrices                   | Matrix Operations |
| Subtract two matrices              | Matrix Operations |
| Scalar multiplication of matrix    | Matrix Operations |
| Find row-wise and column-wise sums | Traversal         |

---

### Level 2: Matrix Manipulation

| Question                         | Concept Used        |
| -------------------------------- | ------------------- |
| Transpose of a matrix            | Index Mapping       |
| Check symmetric matrix           | Transpose           |
| Rotate matrix 90° clockwise      | Transpose + Reverse |
| Rotate matrix 90° anti-clockwise | Transpose + Reverse |
| Reverse rows of matrix           | Traversal           |
| Reverse columns of matrix        | Traversal           |
| Diagonal sum                     | Diagonal Traversal  |
| Secondary diagonal sum           | Diagonal Traversal  |
| Check identity matrix            | Matrix Properties   |
| Check sparse matrix              | Counting Zeros      |

---

### Level 3: Matrix Traversal Patterns

| Question                  | Concept Used       |
| ------------------------- | ------------------ |
| Spiral traversal          | Boundary Traversal |
| Wave traversal            | Zigzag Pattern     |
| Zigzag diagonal traversal | Diagonal Traversal |
| Boundary traversal        | Matrix Boundaries  |
| Print anti-diagonals      | Diagonal Traversal |
| Snake pattern traversal   | Pattern Traversal  |
| Find row with maximum 1s  | Binary Search      |

---

### Level 4: Matrix Search Problems

| Question                               | Concept Used            |
| -------------------------------------- | ----------------------- |
| Search in row-wise sorted matrix       | Binary Search           |
| Search in row and column sorted matrix | Staircase Search        |
| Find median in sorted matrix           | Binary Search           |
| Find Kth smallest element in matrix    | Heap / Binary Search    |
| Search target in 2D matrix             | Flattened Binary Search |

---

### Level 5: Advanced Matrix Problems

| Question                       | Concept Used              |
| ------------------------------ | ------------------------- |
| Matrix multiplication          | Row-Column Multiplication |
| Set matrix zeros               | Extra Space / Optimized   |
| Game of Life                   | Simulation                |
| Maximum rectangle of 1s        | Histogram + Stack         |
| Largest square submatrix of 1s | DP                        |
| Count islands in matrix        | DFS/BFS                   |
| Flood Fill Algorithm           | DFS/BFS                   |
| Number of distinct islands     | Graph Traversal           |
| Shortest path in binary matrix | BFS                       |
| Rotten Oranges                 | Multi-source BFS          |

---

### Level 6: Expert-Level Matrix Problems

| Question                    | Concept Used          |
| --------------------------- | --------------------- |
| N-Queens Problem            | Backtracking          |
| Sudoku Solver               | Backtracking          |
| Word Search in Matrix       | DFS + Backtracking    |
| Rat in a Maze               | Backtracking          |
| Knight's Tour               | Backtracking          |
| Matrix Chain Multiplication | DP                    |
| Unique Paths                | DP                    |
| Minimum Path Sum            | DP                    |
| Cherry Pickup               | DP                    |
| Maximum Sum Rectangle       | Kadane's 2D Extension |

---

## Interview Preparation Order

### Strings

1. Reverse String
2. Palindrome Check
3. Anagram Check
4. Character Frequency
5. Longest Substring Without Repeating Characters
6. Minimum Window Substring
7. KMP
8. Longest Palindromic Substring
9. Edit Distance
10. Trie & Suffix Array Problems

### Matrices

1. Matrix Traversal
2. Transpose
3. Rotate Matrix
4. Spiral Traversal
5. Search in Sorted Matrix
6. Set Matrix Zeroes
7. Flood Fill
8. Number of Islands
9. Largest Rectangle in Matrix
10. Sudoku Solver / N-Queens

These questions cover almost all major concepts asked in DSA interviews on **Strings** and **Matrices**, from beginner-friendly problems to FAANG-level interview questions.

*/
class StringAndMatrix
{
    /*
       ### Level 1: String Basics

| Question                                           | Concept Used               |
| -------------------------------------------------- | -------------------------- |
| Count vowels and consonants                        | Character Processing       |
| Count digits, alphabets, and special characters    | Character Classification   |
| Convert lowercase to uppercase                     | ASCII Manipulation         |
| Reverse a string                                   | Two Pointers               |
| Check whether a string is palindrome               | Two Pointers               |
| Find frequency of each character                   | Counting                   |
| Remove spaces from a string                        | Traversal                  |
| Concatenate two strings                            | String Manipulation        |
| Compare two strings                                | Lexicographical Comparison |

---
       */
    static void Main()
    {
        string name = "nitin";
        int vowels = 0;
        int consonants = 0;
        for (int i = 0; i < name.Length; i++)
        {
            if (name[i] == 'a' || name[i] == 'e' || name[i] == 'i' || name[i] == 'o' || name[i] == 'u')
            {
                vowels++;

            }
            else
            {
                consonants++;
            }

        }
        Console.WriteLine($"vowels:{vowels} and consonants:{consonants}");


    }
}