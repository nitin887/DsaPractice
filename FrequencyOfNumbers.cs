using System.Security.AccessControl;

int[] number = { 1, 2, 2, 3, 1, 1 };
int sizeOfHashTable = 6;
Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
for (int i = 0; i < number.Length; i++)
{
    int count = 0;
    int hashIndex = number[i] % sizeOfHashTable;

    if (!keyValuePairs.ContainsKey(hashIndex))
    {
        count++;
        keyValuePairs.Add(hashIndex, count);

    }
    else
    {
        keyValuePairs[hashIndex] += 1;
    }


}
foreach (var data in keyValuePairs)
{
    Console.WriteLine($"{data.Key}-{data.Value}");
}