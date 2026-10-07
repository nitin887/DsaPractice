int[] number = { 100, 4, 200, 1, 3, 2 };
int sizeHashTable = 6;
HashSet<int> occurences = new HashSet<int>();
for (int i = 0; i < number.Length; i++)
{
    int key = number[i];
    int hashIndex = key % sizeHashTable;
    int indextoStore = hashIndex % sizeHashTable;
    if (!occurences.Contains(indextoStore))
    {
        occurences.Add(indextoStore);
    }

}

foreach (var data in occurences)
{
    Console.WriteLine(data);
}
