/*
### 3. Count Vowels and Consonants

**Concepts:** Character Processing

*/
class CountVowelsAndConsonants
{
    static void Main()
    {
        string name = "nitin";
        int vowels = 0;
        int Consonants = 0;
        for (int i = 0; i < name.Length; i++)
        {
            if (name[i] == 'a' | name[i] == 'e' | name[i] == 'o' | name[i] == 'u' | name[i] == 'i')
            {
                vowels++;
            }
            else
            {
                Consonants++;
            }

        }
        Console.WriteLine($"{vowels}-{Consonants}");


    }
}