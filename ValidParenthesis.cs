/*
### 10. Valid Parentheses

**Concepts:** Stack

---
*/
using System.Diagnostics;

string parenthesis = "(())))(())))";
Stack<char> occurences = new Stack<char>();

for (int i = 0; i < parenthesis.Length - 1; i++)
{
    if (parenthesis[i] == '(' & parenthesis[i + 1] == ')')
    {
        occurences.Pop();
    }
    else
    {
        occurences.Push(parenthesis[i]);
    }
}
foreach (char x in occurences)
{
    Console.Write(x);
}


