using System.ComponentModel.DataAnnotations;
using System.Globalization;
static List<List<int>> Overlapping(int[][] number)
{
    Array.Sort(number, (a, b) => a[0].CompareTo(b[0]));
    List<List<int>> result = [new List<int> { number[0][0], number[0][1] }];
    for (int i = 1; i < number.Length; i++)
    {
        List<int> Last = result[result.Count - 1];
        int[] curr = number[i];
        if (Last[1] >= curr[0])
        {
            Last[1] = Math.Max(Last[1], curr[1]);

        }
        else
        {
            result.Add(new List<int> { curr[0], curr[1] });
        }

    }
    return result;




}
int[][] number = [[1, 3], [2, 6], [8, 10], [15, 18]];
List<List<int>> merged = Overlapping(number);
foreach (List<int> numbers in merged)
{
    Console.WriteLine(numbers[0] + " " + numbers[1]);
}