using System;

class Program
{
    static void Main()
    {
        string wort = "FÜNFER!!!";

        Rueckwaerts(wort);
    }

    static void Rueckwaerts(string text)
    {
        for (int i = text.Length - 1; i >= 0; i--)
        {
            Console.Write(text[i]);
        }
    }
}