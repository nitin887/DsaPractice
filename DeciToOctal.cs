int number = 76;
int pow = 1;
int octalnum = 0;
while (number > 0)
{
    int remainder = number % 8;
    number = number / 8;
    octalnum += remainder * pow;
    pow *= 10;



}
Console.WriteLine(octalnum);