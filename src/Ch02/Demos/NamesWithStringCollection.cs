using Ch02.Interfaces;
using System.Collections.Specialized;

namespace Ch02.Demos;

public class NamesWithStringCollection : IDemoProgram
{
    static StringCollection GenerateNames()
    {
        StringCollection names = ["Gamma", "Vlissides", "Johnson", "Helm"];

        return names;
    }

    static void PrintNames(StringCollection names)
    {
        foreach (string name in names!)
        {
            Console.WriteLine(name);
        }
    }

    public void Run()
    {
        StringCollection names = GenerateNames();

        PrintNames(names);
    }
}
