using Ch02.Demos;
using Ch02.Interfaces;

// Top-level statements
Random random = new();

List<IDemoProgram> demos = [
    new NamesWithArrayDemo(),
    new NamesWithListDemo(),
    new NamesWithArrayListDemo(),
    new NamesWithStringCollectionDemo()
];

foreach (IDemoProgram demo in demos)
{
    ForegroundColor = (ConsoleColor)Enum.ToObject(typeof(ConsoleColor), random.Next(1, 16));

    demo.Run();

    WriteLine();
}

ResetColor();

WriteLine("\nPress any key to exit...");
ReadKey(true);