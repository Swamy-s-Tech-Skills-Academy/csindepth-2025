using Ch02.Interfaces;

namespace Ch02.Demos;

internal class NamesWithArrayDemo : IDemoProgram
{
    public string Title => "Names with string[]";

    private static string[] GenerateNames() => ["Gamma", "Vlissides", "Johnson", "Helm"];

    private static void PrintNames(string[] names)
    {
        foreach (string name in names)
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