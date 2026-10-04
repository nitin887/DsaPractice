using System.Runtime.InteropServices.Marshalling;

int number = 9;
int pow = 1;
int binarynumber = 0;
while (number > 0)
{
    int remainder = number % 2;
    number = number / 2;
    binarynumber += remainder * pow;
    pow *= 10;



}
Console.WriteLine(binarynumber);