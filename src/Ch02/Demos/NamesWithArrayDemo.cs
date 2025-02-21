﻿using Ch02.Interfaces;

namespace Ch02.Demos;

internal class NamesWithArrayDemo : IDemoProgram
{
    static string[] GenerateNames()
    {
        string[] names = ["Gamma", "Vlissides", "Johnson", "Helm"];

        return names;
    }

    static void PrintNames(string[] names)
    {
        foreach (string name in names)
        {
            WriteLine(name);
        }
    }

    public void Run()
    {
        string[] names = GenerateNames();

        PrintNames(names);
    }
}
