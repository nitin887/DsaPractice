using System.Security.AccessControl;

int a = 36;
int count = 0;
for (int i = 0; i < sizeof(int) * 8; i++)
{
    int currentbit = (a >> i) & 1;
    if (currentbit == 1)
    {
        count++;

    }

}
Console.WriteLine(count);

