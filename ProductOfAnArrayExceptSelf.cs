int[] number = { 1, 2, 3, 4 };
int[] prefix = new int[4];
int[] sufix = new int[4];
int[] result = new int[4];
prefix[0] = 1;
for (int i = 1; i < number.Length; i++)
{
    prefix[i] = number[i - 1] * prefix[i - 1];

}
sufix[number.Length - 1] = 1;
for (int i = number.Length - 2; i >= 0; i--)
{
    sufix[i] = number[i + 1] * sufix[i + 1];

}
for (int i = 0; i < result.Length; i++)
{
    result[i] = prefix[i] * sufix[i];

}
foreach (var x in result)
{
    Console.WriteLine(x);
}

// int product = 1;
// for (int i = 0; i < number.Length; i++)
// {
//     result[i] = product;
//     for (int j = 0; j < number.Length; j++)
//     {
//         if (number[i] != number[j])
//         {
//             result[i] *= number[j];

//         }

//     }
// }


