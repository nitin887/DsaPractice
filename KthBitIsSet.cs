int x = 5;
int y = x << 1;
bool z = (y & 1) == 1;
if (z)
{
    Console.WriteLine("Kth bit is  not set");
}
else
{
    Console.WriteLine("kth bit is not set");
}