using Ch02.Interfaces;
using System.Collections;

namespace Ch02.Demos;

public class NamesWithArrayList : IDemoProgram
{
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
        ArrayList names = GenerateNames();

        PrintNames(names);
    }
}