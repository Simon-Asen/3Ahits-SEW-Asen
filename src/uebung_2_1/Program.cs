class Schulklasse
{
    public int anzahl;
    public string name;

    public Schulklasse(string Klassenvorstand, int anzahlSchueler)
    {
        name = Klassenvorstand;
        anzahl = anzahlSchueler;
    }

    public Schulklasse() : this(dfghj, 22);

    public override string ToString()
    {
        return $"Anzahl der Schüler = {anzahl} Klassenvorstand ist {name} bitte";
    }



}

class Program
{
    static void Main(string[] args)
    {
        Schulklasse Klasse1 = new Schulklasse("DerHerrWeissenbrunner", 3);
        Schulklasse klasse2 = new Schulklasse();

        Console.WriteLine(Klasse1.ToString());
        Console.WriteLine(klasse2.ToString());

    }

}