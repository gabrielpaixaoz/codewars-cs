using System;
using System.Linq;


class Program { 
    static void Main()
    {
        string input = "testando";
        string result = Kata.Disemvowel(input);
        Console.WriteLine(result);
    }

}
public static class Kata
{
    public static string Disemvowel(string str)
    {
        string vowels = "aeiouAEIOU";

        string output = new string(str.Where(c => !vowels.Contains(c)).ToArray());

        return output;
    }

    

}
