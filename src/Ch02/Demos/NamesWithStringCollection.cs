using Ch02.Interfaces;
using System.Collections.Specialized;

namespace Ch02.Demos;

internal class NamesWithStringCollectionDemo : IDemoProgram
{
    public string Title => "Names with StringCollection (Avoid using StringCollection)";

    private static StringCollection GenerateNames() => ["Gamma", "Vlissides", "Johnson", "Helm"];

    private static void PrintNames(StringCollection names)
    {
        ArgumentNullException.ThrowIfNull(names);

        foreach (string name in names!)
        {
            WriteLine(name);
        }
    }

    public void Run()
    {
        WriteLine($"\nRunning {Title}...");

        PrintNames(GenerateNames());
    }
}