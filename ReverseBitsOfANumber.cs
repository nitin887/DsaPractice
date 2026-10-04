int a = 4;
int bits = 0;
for (int i = 0; i < sizeof(int) * 8; i++)
{
    bits = (bits << 1) | (a & 1);
    a >>= 1;
}
Console.WriteLine(bits);
