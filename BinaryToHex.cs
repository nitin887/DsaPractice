int binarynumber = 0b11010011;
string number1 = "";

while (binarynumber > 0)
{
    int remainder = binarynumber % 16;
    binarynumber = binarynumber / 16;
    if (remainder > 10)
    {
        number1 += (char)(remainder - 10 + 'A');
    }

    else
    {
        number1 += (char)(remainder + '0');
    }

}
for (int i = number1.Length - 1; i >= 0; i--)
{
    Console.Write(number1[i]);

}






