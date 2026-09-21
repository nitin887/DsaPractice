/*
### 12. Longest Palindromic Substring

**Concepts:** Two Pointers, Expand Around Center

Find the longest substring that reads the same forwards and backwards.

Example:
    input : "aknitinks"
    output: "knitink"   (k n i t i n k -> length 7, reads the same reversed)

Key idea:
    Every palindrome has a center. Odd-length palindromes are centered on a
    single character ("nitin" -> center 't'), even-length ones are centered
    between two characters ("abba" -> center between "bb").
    For each possible center, expand left and right while the characters
    match, and keep the longest expansion found.

Time : O(n^2)
Space: O(1)
*/
class LongestPalindromicSubstring
{
    static void Main()
    {
        string name = "aknitinks";

        string longest = "";

        for (int center = 0; center < name.Length; center++)
        {
            // odd length palindrome  -> center is the character itself
            string odd = ExpandAroundCenter(name, center, center);

            // even length palindrome -> center is the gap to the next char
            string even = (center + 1 < name.Length)
                        ? ExpandAroundCenter(name, center, center + 1)
                        : "";

            if (odd.Length > longest.Length)
            {
                longest = odd;
            }
            if (even.Length > longest.Length)
            {
                longest = even;
            }
        }

        Console.WriteLine("Longest palindromic substring of \"" + name
            + "\" is \"" + longest + "\"");
        Console.WriteLine("Length: " + longest.Length);
    }

    // Expand left/right from the given center while the characters match.
    // Returns the biggest palindrome found around that center.
    static string ExpandAroundCenter(string word, int left, int right)
    {
        while (left >= 0 && right < word.Length && word[left] == word[right])
        {
            left--;
            right++;
        }

        // The loop stopped one step past the palindrome,
        // so trim one character back in on each side.
        return word.Substring(left + 1, right - left - 1);
    }
}
