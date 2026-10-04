int binarynumber = 0b11010011;
int pow = 1;
int number1 = 0;

while (binarynumber > 0)
{
    int remainder = binarynumber % 8;
    binarynumber = binarynumber / 8;
    number1 += remainder * pow;
    pow *= 10;

}

Console.Write(number1);








