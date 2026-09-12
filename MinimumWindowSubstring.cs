/*
### 14. Minimum Window Substring

**Concepts:** Sliding Window

*/
string name = "natiksasks";   // source string (s)  -> the big string we SEARCH IN
string names = "naks";        // target string (t)  -> characters we must include

// ---------- Build frequency map of the SOURCE string (info only) ----------
Dictionary<char, int> number = new Dictionary<char, int>();
for (int i = 0; i < name.Length; i++)
{
    if (!number.ContainsKey(name[i]))
        number.Add(name[i], 1);
    else
        number[name[i]] += 1;
}

Console.WriteLine("Source String (s):");
foreach (var data in number)
{
    Console.WriteLine($"{data.Key}-{data.Value}");
}

// ---------- Build frequency map of the TARGET string (= what we "need") ----------
Dictionary<char, int> number1 = new Dictionary<char, int>();
for (int i = 0; i < names.Length; i++)
{
    if (!number1.ContainsKey(names[i]))
        number1.Add(names[i], 1);
    else
        number1[names[i]] += 1;
}

Console.WriteLine("\nTarget String (t):");
foreach (var data1 in number1)
{
    Console.WriteLine($"{data1.Key}-{data1.Value}");
}

// ---------- Sliding Window (the actual algorithm) ----------
Dictionary<char, int> windowCount = new Dictionary<char, int>(); // frequencies inside current window

int formed = 0;                    // how many DISTINCT chars of t are satisfied so far
int required = number1.Count;      // how many distinct chars t has

int left = 0;
int minLen = int.MaxValue;
int minStart = 0;

for (int right = 0; right < name.Length; right++)
{
    char ch = name[right];

    // 1) Expand the window to the right
    if (!windowCount.ContainsKey(ch))
        windowCount.Add(ch, 1);
    else
        windowCount[ch] += 1;

    // 2) If this char is in t and the window now has EXACTLY enough of it -> formed++
    if (number1.ContainsKey(ch) && windowCount[ch] == number1[ch])
        formed++;

    // 3) Shrink from the left WHILE the window still contains all of t
    while (formed == required)
    {
        int len = right - left + 1;
        if (len < minLen)
        {
            minLen = len;
            minStart = left;
        }

        char leftChar = name[left];
        windowCount[leftChar] -= 1;
        if (number1.ContainsKey(leftChar) && windowCount[leftChar] < number1[leftChar])
            formed--;

        left++;
    }
}

Console.WriteLine();
if (minLen == int.MaxValue)
    Console.WriteLine("No window in the source string contains all characters of the target.");
else
    Console.WriteLine($"Minimum window substring: \"{name.Substring(minStart, minLen)}\"  (length: {minLen})");




