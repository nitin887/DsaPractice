using System.Diagnostics.CodeAnalysis;

int[] number = { 1, 3, 5 };
int[] number2 = { 2, 4, 6, 7 };
int[] number3 = new int[number.Length + number2.Length];
int start = 0;
int end = number3.Length;
int first = 0;
int second = 0;

while (start < end && first < number.Length && second < number2.Length)
{
    if (number[first] < number2[second])
    {
        number3[start] = number[first];
        first++;
        start++;


    }
    else if (number[first] > number2[second])
    {
        number3[start] = number2[second];
        second++;
        start++;



    }

}
while (first <= number.Length - 1 && start < end)
{
    number3[start] = number[first];
    first++;
    start++;

}
while (second <= number2.Length - 1 && start < end)
{
    number3[start] = number2[second];
    second++;
    start++;
}
foreach (var data in number3)
{
    Console.WriteLine(data);
}