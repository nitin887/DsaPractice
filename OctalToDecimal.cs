int number = 114;
int pow = 1;
int decinum = 0;
while (number > 0)
{
    int remainder = number % 10;
    number = number / 10;
    decinum += remainder * pow;
    pow *= 8;
}
Console.WriteLine(decinum);