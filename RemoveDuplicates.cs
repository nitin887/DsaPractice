using System.IO.Pipelines;

int[] number = { 1, 2, 2, 3, 1, 4 };
HashSet<int> number1 = new HashSet<int>();
for (int i = 0; i < number.Length; i++)
{
    if (!number1.Contains(number[i]))
    {
        number1.Add(number[i]);
    }
    else
    {
        number1.Remove(number[i]);
    }
}
foreach (var data in number1)
{
    Console.WriteLine(data);
}