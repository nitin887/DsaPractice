int a = 6;
bool number = (a & (a - 1)) == 0;
if (number)
{
    Console.WriteLine("number is a power of 2");

}
else
{
    Console.WriteLine("not a power of 2");
}