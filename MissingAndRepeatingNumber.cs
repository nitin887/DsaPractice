using System.Text.Json.Serialization;

int[] number = { 1, 2, 3, 4, 4 };
int n = number.Length;
int sum = n * (n + 1) / 2;
int sumsq = n * (n + 1) * (2 * n + 1) / 6;
int actualsum = 0;
int actualsumsq = 0;

for (int i = 0; i < number.Length; i++)
{
    actualsum += number[i];


}
for (int i = 0; i < number.Length; i++)
{
    actualsumsq += number[i] * number[i];

}
int diffsum = sum - actualsum;
int diffsumsq = sumsq - actualsumsq;
int missing = (diffsum + diffsumsq) / 2;
int duplicatenumber = missing - diffsum;
Console.WriteLine("duplicate:" + duplicatenumber + "missing number:" + missing);

// for (int i = 0; i < number.Length - 1; i++)
// {
//     if (number[i + 1] - number[i] > 1)
//     {
//         if (number[i + 1] - number[i] == 2)
//         {
//             Console.WriteLine("missing number is:" + (number[i] + 1));
//         }
//         else
//         {
//             Console.WriteLine("other missing number is:" + (number[i + 1] - 1));
//         }
//     }
//     else if (number[i + 1] - number[i] == 0)
//     {
//         Console.WriteLine("duplicate number is:" + number[i]);
//     }

// }
