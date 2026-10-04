int hexnumber = 0X5D;
string decimalnumber = "";
while (hexnumber > 0)
{
    int remainder = hexnumber % 10;

    hexnumber = hexnumber / 10;
    decimalnumber += remainder;

}
for (int i = decimalnumber.Length - 1; i >= 0; i--)
{
    Console.Write(decimalnumber[i]);

}

