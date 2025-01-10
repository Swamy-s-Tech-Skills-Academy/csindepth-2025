using Ch02.Interfaces;

namespace Ch02.Demos;

internal class NamesWithListDemo : IDemoProgram
{
    public string Title => "Names with List<string>";

    private static List<string> GenerateNames() => ["Gamma", "Vlissides", "Johnson", "Helm"];

    private static void PrintNames(List<string> names)
    {
        ArgumentNullException.ThrowIfNull(names);

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