int number = 998;
string number1 = "";

while (number > 0)
{
    int remainder = number % 16;
    number = number / 16;
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

