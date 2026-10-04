int[] number = { 2, 2, 2, 5, 3, 3, 3 };
int ones = 0;
int twos = 0;
for (int i = 0; i < number.Length; i++)
{
    twos = twos | (ones & number[i]);
    ones = ones ^ number[i];
    int commonBitMask = ~(ones & twos);
    ones &= commonBitMask;
    twos &= commonBitMask;



}
Console.WriteLine(ones);
