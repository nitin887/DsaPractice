int[] number = { 1, 2, 3, 4, 1 };
bool isduplicate = false;
int duplicate = 0;
HashSet<int> nonduplicates = new HashSet<int>();
for (int i = 0; i < number.Length; i++)
{
    if (!nonduplicates.Contains(number[i]))
    {
        nonduplicates.Add(number[i]);
    }
    else
    {
        isduplicate = true;
        duplicate = number[i];

    }

}
if (isduplicate)
{
    Console.WriteLine("duplicate element is:" + duplicate);
}
else
{
    Console.WriteLine("no duplicate element is present");
}