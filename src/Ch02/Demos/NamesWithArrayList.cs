using Ch02.Interfaces;
using System.Collections;

namespace Ch02.Demos;

internal class NamesWithArrayListDemo : IDemoProgram
{
    public string Title => "Names with ArrayList (Avoid using ArrayList)";

    private static ArrayList GenerateNames() => ["Gamma", "Vlissides", "Johnson", "Helm"];

    private static void PrintNames(ArrayList names)
    {
        if (names is null)
        {
            throw new ArgumentNullException(nameof(names));
        }

        foreach (string name in names)
        {
            WriteLine(name);
        }
    }

    public void Run()
    {
        WriteLine($"\nRunning {Title}...");
        PrintNames(GenerateNames()); // Directly call GenerateNames in PrintNames
    }
}