using Ch02.Demos;

ForegroundColor = ConsoleColor.DarkCyan;

new NamesWithArrayDemo().Run();
new NamesWithArrayList().Run();
new NamesWithListDemo().Run();
new NamesWithStringCollection().Run();

ResetColor();

WriteLine("\n\nPress any key to exit...");
ReadKey(true);
