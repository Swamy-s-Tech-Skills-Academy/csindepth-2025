using Ch02.Interfaces;
using System.Collections.Specialized;

namespace Ch02.Demos;

public class NamesWithStringCollection : IDemoProgram
{
    public string Title => "Names with StringCollection (Avoid using StringCollection)";

    private static StringCollection GenerateNames() => ["Gamma", "Vlissides", "Johnson", "Helm"];

    private static void PrintNames(StringCollection names)
    {
        if (names is null)
        {
            throw new ArgumentNullException(nameof(names));
        }
        foreach (string name in names!) // Null-forgiving operator is still needed
        {
            Console.WriteLine(name);
        }
    }

    public void Run()
    {
        WriteLine($"\nRunning {Title}...");

        StringCollection names = GenerateNames();

        PrintNames(names);
    }
}