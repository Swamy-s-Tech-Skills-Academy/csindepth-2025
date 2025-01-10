using Ch02.Interfaces;
using System.Collections;

namespace Ch02.Demos;

public class NamesWithArrayList : IDemoProgram
{
    public string Title => "Names with ArrayList";

    static ArrayList GenerateNames()
    {
        ArrayList names = ["Gamma", "Vlissides", "Johnson", "Helm"];

        return names;
    }

    static void PrintNames(ArrayList names)
    {
        foreach (string name in names)
        {
            WriteLine(name);
        }
    }

    public void Run()
    {
        WriteLine($"\nRunning {Title}...");

        ArrayList names = GenerateNames();

        PrintNames(names);
    }
}