static void Main()
    {
        string wort = "Hallo";

        string umgekehrt = Rueckwaerts(wort);

        Console.WriteLine(umgekehrt);
    }

    static string Rueckwaerts(string text)
    {
        string ret = "";

        for (int i = 0; i < text.Length; i++)
        {
            ret = text[i] + ret;
        }

        return ret;
    }