/*
### 2. Check Palindrome

**Concepts:** String Traversal

*/
class CheckPalindrome
{
    static void Main()
    {
        string name = "nitin";
        char[] names = name.ToCharArray();

        int i = 0;
        int j = names.Length - 1;
        while (i <= j)
        {
            (names[i], names[j]) = (names[j], names[i]);
            i++;
            j--;

        }

        if (name == new string(names))
        {
            Console.WriteLine("is a palindrome");
        }
        else
        {
            Console.WriteLine("not a palindrome");
        }





    }
}