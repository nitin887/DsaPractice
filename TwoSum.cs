using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

int[] number = { 2, 1, 8, 7, 15 };
int target = 9;
string key = "";
int next = 0;
int sum = 0;
Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
for (int i = 0; i < number.Length; i++)
{
    int current = number[i];
    for (int j = 0; j < number.Length; j++)
    {
        if (i != j)
        {
            key = $"{i}+{j}";
            next = number[j];
            sum = current + next;
        }
        if (!keyValuePairs.ContainsKey(key))
        {
            keyValuePairs.Add(key, sum);
        }
    }


}
foreach (var data in keyValuePairs)
{
    if (data.Value == target)
    {
        Console.WriteLine(data.Key);
    }
}



