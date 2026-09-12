/*
### 11. Longest Substring Without Repeating Characters

**Concepts:** Sliding Window
*/
class LongestSubstringWithoutRepeatingCharacter
{
    static void Main()
    {
        string name = "abcabcbb"; // input string

        Dictionary<char, int> lastIndex = new Dictionary<char, int>(); // char -> its last seen index
        int left = 0;   // start of the current window
        int maxLen = 0; // length of the longest substring found so far
        int start = 0;  // start index of that longest substring (to print it)

        for (int right = 0; right < name.Length; right++)
        {
            char ch = name[right];

            // If this character is already inside the current window,
            // move the window's left edge just past its previous occurrence.
            if (lastIndex.ContainsKey(ch) && lastIndex[ch] >= left)
            {
                left = lastIndex[ch] + 1;
            }

            // Remember where this character was last seen.
            lastIndex[ch] = right;

            // Current window [left .. right] is all unique -> check its length.
            int windowLen = right - left + 1;
            if (windowLen > maxLen)
            {
                maxLen = windowLen;
                start = left;
            }
        }

        Console.WriteLine($"Longest substring without repeating characters: \"{name.Substring(start, maxLen)}\"");
        Console.WriteLine($"Length: {maxLen}");
    }
}