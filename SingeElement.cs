int[] number = { 2, 3, 2, 4, 4 };
int singlelement = 0;
for (int i = 0; i < number.Length; i++)
{
    singlelement = singlelement ^ number[i];
}
Console.WriteLine("singlelement:" + singlelement);
