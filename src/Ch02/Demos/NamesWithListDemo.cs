using Ch02.Interfaces;

namespace Ch02.Demos;

public class NamesWithListDemo : IDemoProgram
{
    public string Title => "Names with List<string>";

    private static List<string> GenerateNames() => ["Gamma", "Vlissides", "Johnson", "Helm"]; // Use List<string> and expression body

    private static void PrintNames(List<string> names)
    {
        if (names is null)
        {
            throw new ArgumentNullException(nameof(names));
        }

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }

    public void Run()
    {
        WriteLine($"\nRunning {Title}...");

        List<string> names = GenerateNames();

        PrintNames(names);
    }
}