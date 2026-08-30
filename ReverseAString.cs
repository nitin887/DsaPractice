/*
# Strings (15 Questions)




## Intermediate


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

*/
/*
## Beginner

### 1. Reverse a String

**Concepts:** Two Pointers
*/
using System.Data;
using System.Globalization;

class ReverseAString
{
    static void Main()
    {
        string name = "nitink";
        char[] names = name.ToCharArray();
        int i = 0;
        int j = names.Length - 1;
        while (i < j)
        {

            (names[i], names[j]) = (names[j], names[i]);
            i++;
            j--;
        }
        for (int k = 0; k < names.Length; k++)
        {
            Console.WriteLine(names[k]);

        }



    }
}