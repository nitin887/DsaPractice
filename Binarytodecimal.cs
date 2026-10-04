int binarynumber = 0b1001;
int pow = 1;
int decimalres = 0;
while (binarynumber > 0)
{
    int remainader = binarynumber % 10;
    binarynumber = binarynumber / 10;
    decimalres += remainader * pow;
    pow *= 2;


}
Console.WriteLine(decimalres);