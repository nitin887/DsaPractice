int[] number = { 2, 4, 5 };
int prev = 1;
for (int i = 0; i < number.Length; i++)
{


    int current = number[i];
    int next = (i == number.Length - 1) ? 1 : number[i + 1];
    number[i] = prev * current * next;
    prev = current;






}
foreach (var data in number)
{
    Console.WriteLine(data);
}