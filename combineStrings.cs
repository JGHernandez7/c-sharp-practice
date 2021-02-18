using System;

class CombineStrings
{
    private static string combine(string a, string b)
    {
        string result = "";

        for (int i = 0; i < (a.Length > b.Length ? a.Length : b.Length); i++)
        {
            if (i < a.Length)
            {
                result += a[i];
            }
            if (i < b.Length)
            {
                result += b[i];
            }
        }

        return result;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(combine("Guadalupe", "Hernandez"));
        Console.WriteLine(combine("Hernandez", "0000000"));
    }
}
