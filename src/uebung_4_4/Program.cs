using System;

class Program
{
    static void Main()
    {
        string wort = "Eine Horde bedrohe nie";

        if (IstPalindrom(wort))
        {
            Console.WriteLine("Es ist ein Palindrom!");
        }
        else
        {
            Console.WriteLine("Es ist kein Palindrom!");
        }
    }

    static string Reverse(string text)
    {
        string ret = "";

        for (int i = 0; i < text.Length; i++)
        {
            ret = text[i] + ret;
        }

        return ret;
    }

    static bool IstPalindrom(string text)
    {
        text = text.Replace(" ", "");
        text = text.ToLower();

        string umgekehrt = Reverse(text);

        return text == umgekehrt;
    }
}