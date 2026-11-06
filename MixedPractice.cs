// int a = 8;
// int pos = 2;
// int isset = a & (pos << 1);
// if (isset == 0)
// {
//        Console.WriteLine("no is not set ");
// }
// else
// {
//        Console.WriteLine("no is set");
// }
// class MixedPractice
// {
//        static int SetANumber(int number, int bit)
//        {
//               int result = number | (1 << bit);
//               return result;




//        }
//        static void Main()
//        {
//               int number = 4;
//               int bit = 1;
//               int setANumber = SetANumber(number, bit);
//               Console.WriteLine("bit is set:" + setANumber);

//        }
// }
// class MixedPractice
// {
//        static int Unset(int number, int pos)
//        {
//               int result = number & (~(1 << pos));
//               return result;

//        }
//        static void Main()
//        {
//               int number = 8;
//               int pos = 3;
//               int unset = Unset(number, pos);
//               Console.WriteLine("result after bit clearing:" + unset);

//        }
// }
// class MixedPractice
// {
//        static int Check(int number, int pos)
//        {
//               int result = number & (1 << pos);
//               return result;

//        }
//        static void Main()
//        {
//               int number = 8;
//               int pos = 3;
//               int check = Check(number, pos);
//               if (check == 0)
//               {
//                      Console.WriteLine("bit is not set");
//               }
//               else
//               {
//                      Console.WriteLine("bit is set");
//               }


//        }

// }
// class MixedPractice
// {
//        static void Main()
//        {
//               int num = 5;
//               int result = num & 1;
//               if (result == 0)
//               {
//                      Console.WriteLine("number is even");
//               }
//               else
//               {
//                      Console.WriteLine("no is odd");
//               }
//        }
// }
// using System.Security.AccessControl;

// int number = 8;
// int pos = 2;
// int result = number ^ (1 << pos);
// Console.WriteLine(result);

// int n = 8;
// int k = 2;
// int result = n ^ k;
// int result = n << k;
// Console.WriteLine(result);

// class MixedPractice
// {
//        static int Count(int n)
//        {
//               int ans = 0;
//               while (n > 0)
//               {
//                      ans += (n & 1);
//                      n >>= 1;
//               }
//               return ans;

//        }
//        static void Main()
//        {
//               int n = 6;
//               int count = Count(n);
//               Console.WriteLine("no of set bits:" + count);

//        }
// }

// class MixedPractice
// {
//        static int Toggling(int number, int pos)
//        {
//               int result = number ^ (1 << pos);
//               return result;

//        }
//        static void Main()
//        {
//               int number = 8;
//               int pos = 2;
//               int toggledNumber = Toggling(number, pos);
//               Console.WriteLine("Toggled Number:" + toggledNumber);

//        }
// }
// int n = 5;
// int result = n & (n - 1);
// Console.WriteLine(result);
// if (result == 0)
// {
//        Console.WriteLine("no is power of two ");

// }
// else
// {
//        Console.WriteLine("no is not a power of two");
// }
// int[] number = { 4, 1, 2, 1, 2 };
// int result = number[0];
// for (int i = 1; i < number.Length; i++)
// {
//        result = number[i] ^ result;


// }
// Console.WriteLine(result);
// int[] number = { 2, 4, 7, 9, 2, 4 };
// int result = 0;
// for (int i = 0; i < number.Length; i++)
// {
//        result ^= number[i];

// }
// int rightmostsetbit = result & (-result);
// int unique1 = 0;
// int unique2 = 0;

// for (int i = 0; i < number.Length; i++)
// {
//        if ((rightmostsetbit & number[i]) != 0)
//        {
//               unique1 ^= number[i];
//        }
//        else
//        {
//               unique2 ^= number[i];
//        }

// }
// Console.WriteLine("unique1:" + unique1 + "\nunique2:" + unique2);
// int[] number = { 3, 0, 1 };
// int missingNumber = 0;
// for (int i = 0; i < number.Length; i++)
// {
//        missingNumber ^= number[i];

// }
// Console.WriteLine(missingNumber);
// int numbers = 3;
// int numbers1 = -5;
// int result = numbers >> 31;
// int result1 = numbers1 >> 31;
// if (result < 0 && result1 > 0)
// {
//        Console.WriteLine($"number1:{numbers1} is positive and number :{numbers} is negative");


// }
// else
// {
//        Console.WriteLine($"number:{numbers} is positive and number1 :{numbers1} is negative");
// }
// int a = 5;
// int b = 2;
// a = a ^ b;
// b = a ^ b;
// a = a ^ b;
// Console.WriteLine("a:" + a + "b:" + b);
// int a = 12;
// int pos = 1;
// int result = a & (-a);
// Console.WriteLine(result);
// int a = 6;
// int count = 0;
// while (a > 0)
// {
//        count += a & 1;
//        a >>= 1;
// }
// Console.WriteLine(count);
// uint i = 1;
// Console.WriteLine(i << 31);
/*
Reverse the Bits of a 32-Bit Unsigned Integer

Reverse all 32 bits of a given 32-bit unsigned integer and return the resulting unsigned value.

Example: Input: 1 → Output: 2147483648
*/
using System.Drawing;
using System.Globalization;

// uint n = 1;
// n <<= 31;


// Console.WriteLine(n);

/*
19

Find the Maximum XOR of Two Array Elements

Given an array of non-negative integers, find the maximum XOR value obtainable from any pair of distinct elements.

Example: Input: [3, 10, 5, 25, 2, 8] → Output: 28
*/
// int[] number = { 3, 10, 5, 25, 2, 8 };
// int maxXor = 0;
// int prevnumber = number[0];
// for (int i = 1; i < number.Length - 1; i++)
// {
//        int currentnumber = number[i];


//        int currentXor = Math.Max(prevnumber ^ currentnumber, currentnumber ^ number[i + 1]);




//        if (currentXor > maxXor)
//        {
//               maxXor = currentXor;
//        }


// }
// Console.WriteLine(maxXor);
/*
# 3. Recursion

## Easy

### Q1

Print numbers from 1 to N using recursion.
*/
// class MixedPractice
// {
//     static void Print(int n, int m)
//     {

//         Console.WriteLine(n);
//         if (n < m)
//         {
//             Print(n + 1, m);
//         }




//     }


//     static void Main()
//     {
//         int n = 1;
//         int m = 5;
//         Print(n, m);


//     }
// }
/*
---

### Q2

Find factorial of a number using recursion.
*/
// class MixedPractice
// {
//     static int Factorial(int n)
//     {
//         if (n == 0)
//         {
//             return 1;
//         }
//         return n * Factorial(n - 1);

//     }
//     static void Main()
//     {
//         int n = 5;
//         Console.WriteLine(Factorial(n));

//     }
// }
/*
---

### Q3

Find the sum of first N natural numbers using recursion.

---*/
// class MixedPractice
// {
//     static int Sum(int n, int m)
//     {
//         if (n > m)
//         {
//             return 0;
//         }
//         return n + Sum(n + 1, m);

//     }
//     static void Main()
//     {
//         int n = 1;
//         int m = 5;
//         Console.WriteLine(Sum(n, m));


//     }
// }
/*

## Intermediate

### Q4

Find the nth Fibonacci number using recursion.
*/


// class MixedPractice
// {
//        static int Fibonacci(int n, int a, int b)
//        {
//               int sum = a + b;
//               if (n == 5)
//               {
//                      return sum;
//               }


//               return Fibonacci(n + 2, b, sum);

//        }
//        static void Main()
//        {
//               int n = 1;
//               int a = 0;
//               int b = 1;
//               Console.WriteLine(Fibonacci(n, a, b));


//        }
// }

/*

---

### Q5

Check whether a string is a palindrome using recursion.

---
*/
// class MixedPractice
// {
//        static bool IsPalindrome(string name, int left, int right)
//        {
//               if (left >= right)
//               {
//                      return true;
//               }
//               if (name[left] != name[right])
//               {
//                      return false;
//               }
//               return IsPalindrome(name, left + 1, right - 1);





//        }
//        static void Main()
//        {
//               string name = "nitink";
//               int left = 0;
//               int right = name.Length - 1;

//               Console.WriteLine(IsPalindrome(name, left, right));
//        }
// }
/*

## Hard

### Q6

Generate all subsequences of a string.

Example:

```text
ABC
```

Output:

```text
A
B
C
AB
AC
BC
ABC
(empty)
*/
// class MixedPractice
// {
//        static void Subsequences(string Input, string Output)
//        {

//               if (Input.Length == 0)
//               {
//                      Console.WriteLine(Output);
//                      return;
//               }



//               Subsequences(Input[1..], Output + Input[0]);
//               Subsequences(Input[1..], Output);


//        }
//        static void Main()
//        {
//               string Input = "ABC";
//               string Output = " ";
//               Subsequences(Input, Output);

//        }
// }
/*

# 4. Arrays

## Easy

### Q1

Find the largest element in an array.

---
*/
// int[] number = { 1, 2, 4, 4, 5, 9 };
// int max = 0;
// for (int i = 0; i < number.Length; i++)
// {
//        if (number[i] > max)
//        {
//               max = number[i];
//        }

// }
// Console.WriteLine(max);
/*

### Q2

Find the second largest element.

---
*/
// int[] number = { 1, 2, 3, 5, 7 };
// int max = number[0];
// int min = number[1];
// for (int i = 2; i < number.Length; i++)
// {
//        if (max < number[i])
//        {
//               min = max;

//               max = number[i];
//        }



// }
// Console.WriteLine(min);

/*

### Q3

Move all zeros to the end.

Input:


```text
[1, 0, 2, 0, 3, 4]
```

Output:

```text
[1, 2, 3, 4, 0, 0]
```

---

*/
// int[] number = [1, 0, 2, 0, 3, 4];
// int start = 0;
// int end = number.Length - 1;
// while (start < end)
// {
//        if (number[start] == 0)
//        {
//               (number[start], number[end]) = (number[end], number[start]);
//               start++;
//               end--;
//        }
//        start++;


// }
// foreach (var data in number)
// {
//        Console.WriteLine(data);
// }
/*## Intermediate

### Q4

Rotate an array to the right by K positions.

Input:

```text
[1, 2, 3, 4, 5]
K = 2
```

Output:

```text
[4, 5, 1, 2, 3]
```

---
*/
// class MixedPractice
// {
//        static void Swap(int[] number, int low, int high)
//        {
//               while (low <= high)
//               {
//                      (number[low], number[high]) = (number[high], number[low]);
//                      low++;
//                      high--;



//               }

//        }
//        static void Reverse(int[] number, int k)
//        {
//               int low = 0;
//               int high = number.Length - 1;
//               Swap(number, low, k - 1);
//               Swap(number, k, high);
//               Swap(number, low, high);


//        }
//        static void Main()
//        {
//               int[] number = { 1, 2, 3, 4, 5 };
//               int k = 2;
//               Reverse(number, k);
//               foreach (var data in number)
//               {
//                      Console.WriteLine(data);
//               }
//        }
// }
/*

### Q5

Find all leaders in an array.

Input:

```text
[16, 17, 4, 3, 5, 2]
```

Output:

```text
17 5 2
```

---
*/
// int[] number = { 16, 17, 4, 3, 5, 2 };
// int k = number.Length;
// for (int i = k - 1; i > 0; i--)
// {
//        int current = number[i];
//        int next = (i == k - 1) ? 0 : number[i - 1];
//        if (current > next)
//        {
//               int leaders = current;
//               Console.WriteLine(leaders);


//        }


// }

/*
## Hard

### Q6

Find the maximum sum of a contiguous subarray.

---
*/
// class MixedPractice
// {
//        static void Main()
//        {
//               int[] number = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
//               int maxsum = number[0];
//               int current = number[0];


//               for (int i = 1; i < number.Length; i++)
//               {
//                      current = Math.Max(number[i], current + number[i]);
//                      if (maxsum < current)
//                      {
//                             maxsum = current;
//                      }
//               }
//               Console.WriteLine(maxsum);




//        }
// }
// /*



// # 5. Strings

// ## Easy

/*
### Q1

Reverse a string.

---
*/
// string name = "nitink";
// for (int i = name.Length - 1; i >= 0; i--)
// {
//        Console.WriteLine(name[i]);

// }

/*
### Q2

Count vowels and consonants.

---
*/
// int vowels = 0;
// int consonants = 0;
// string name = "nitink";
// for (int i = 0; i < name.Length; i++)
// {
//        if (name[i] == 'a' | name[i] == 'e' | name[i] == 'o' | name[i] == 'u' | name[i] == 'i')
//        {
//               vowels++;

//        }
//        else
//        {
//               consonants++;
//        }

// }
// Console.WriteLine($"{vowels} and {consonants}");
/*

### Q3

Find the frequency of each character.

---
*/
// string name = "nitin";
// Dictionary<char, int> keyValuePairs = [];
// foreach (char x in name)
// {
//        if (!keyValuePairs.ContainsKey(x))
//        {
//               keyValuePairs.Add(x, 1);
//        }
//        else
//        {
//               keyValuePairs[x] += 1;
//        }

// }
// foreach (var data in keyValuePairs)
// {
//        Console.WriteLine($"{data.Key}-{data.Value}");
// }
/*

## Intermediate

### Q4

Check whether two strings are anagrams.

---
*/
// string name = "nitin";
// string name1 = "niitn";
// char[] names = name.ToCharArray();
// char[] names1 = name1.ToCharArray();
// for (int i = 0; i < names.Length; i++)
// {
//        Array.Sort(names);
//        Array.Sort(names1);

// }
// if (new string(names) == new string(names1))
// {
//        Console.WriteLine("BOTH ARE aNAgrams");
// }
// else
// {
//        Console.WriteLine("Both are not a anagrams");

// }

/*


/*
 ### Q2

```text
1
12
123
1234
12345
```*/
// int n = 5;
// for (int i = 0; i < n; i++)
// {
//     for (int j = 0; j <= i; j++)
//     {
//         Console.Write(j + 1);

//     }
//     Console.WriteLine();

// }
/*

---

### Q3

```text
*****
****
***
**
*
```
*/
// int n = 5;
// for (int i = 0; i < n; i++)
// {
//     for (int j = n; j > i; j--)
//     {
//         Console.Write("*");

//     }
//     Console.WriteLine();

// }
/*
---

## Intermediate

### Q4

```text
    *
   ***
  *****
 *******
*********
```
*/
// int n = 5;

// for (int i = 0; i < n; i++)
// {

//     //spaces
//     for (int j = 0; j < n - i - 1; j++)
//     {
//         Console.Write(" ");


//     }
//     //stars
//     for (int j = 0; j < 2 * i + 1; j++)
//     {
//         Console.Write("*");

//     }
//     Console.WriteLine();
// }
/*

---

### Q5

```text
1
22
333
4444
55555
```

---
*/
// int x = 1;
// int n = 5;
// for (int i = 0; i < n; i++)
// {
//     for (int j = 0; j <= i; j++)
//     {
//         Console.Write(x);


//     }
//     x++;
//     Console.WriteLine();

// }

/*

## Hard

### Q6

```text
E
DE
CDE
BCDE
ABCDE

    */
// int x = 5;
// for (int i = x; i >= 1; i--)
// {
//     for (int j = i; j <= x; j++)
//     {
//         Console.Write((char)('A' + j - 1));

//     }
//     Console.WriteLine();

// }


/*
# 2. Patterns
## Easy
### Q1
```text
*
**
***
****
*****
```
---*/
// static void Main()
// {
//     int n = 5;
//     for (int i = 0; i < n; i++)
//     {
//         for (int j = 0; j <= i; j++)
//         {
//             Console.Write("*");

//         }
//         Console.WriteLine();

//     }
// }
/*



}
// static int GCD(int number, int number1)
// {
//     return number == 0 ? number1 : number1 % number;

// }
// static int LCM(int number, int number1)
// {
//     int gcd = GCD(number, number1);
//     int lcm = (number * number1) / gcd;
//     return lcm;

// }
// static void Main()
// {

/*
## Hard

### Q6

Given two numbers, find their GCD and LCM without using built-in methods.
*/
//         int number = 64;
//         int number1 = 16;
//         Console.WriteLine("greatest common divisor is" + GCD(number, number1));
//         Console.WriteLine("Lcm of Number is:" + LCM(number, number1));


//     }
// }
/*
        ### Q5

Check whether a number is prime.

---



---*/
// int number = 15;


// if (number % 2 == 0 || number % 3 == 0)
// {
//     Console.WriteLine("number is not prime");

// }
// else
// {
//     Console.WriteLine("number is prime");
// }

/*
## Intermediate

### Q4

Find all divisors of a number in sorted order.

Input:

```text
36
```

Output:

```text
1 2 3 4 6 9 12 18 36
```

---

*/
// int numberdivisibleby = 1;
// int number = 36;

// while (numberdivisibleby <= number)
// {

//     if (number % numberdivisibleby == 0)
//     {
//         Console.WriteLine(numberdivisibleby);

//     }

//     numberdivisibleby++;






// }

/*

/*
       ### Q3

Find the sum of digits of a number.

---
       */
// int number = 321;
// int sumofdigits = 0;
// while (number > 0)
// {
//     int remainder = number % 10;
//     number = number / 10;
//     sumofdigits += remainder;
// }
// Console.WriteLine(sumofdigits);

/*
### Q2

Check whether a number is a palindrome.

Example:

```text
121 → True
123 → False
```

---
*/
// int number = 121;
// int newNumber = number;
// int reversed = 0;
// int multiple = 100;

// while (newNumber > 0)
// {
//     int remainder = newNumber % 10;
//     newNumber = newNumber / 10;
//     reversed += remainder * multiple;
//     multiple = multiple / 10;





// }
// if (number == reversed)
// {
//     Console.WriteLine("number is a palindrome");
// }
// else
// {
//     Console.WriteLine("number is not a palindrome");
// }

/*




*/

//         ### Q1

// Given an integer `n`, count the number of digits in it.

// ---
//         int n = 56;
//         int noofdigits = 0;
//         while (n > 0)
//         {
//             n = n / 10;
//             noofdigits += 1;

//         }
//         Console.WriteLine(noofdigits);

//     }
// }