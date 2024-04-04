if (args.Length < 3)
{
    Console.WriteLine("You must specify two colors and cursor size, e.g.");
    Console.WriteLine("dotnet run red yellow 50");
}

Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), args[0], true);

Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), args[1], true);

try
{
    Console.CursorSize = int.Parse(args[2]);
}
catch (PlatformNotSupportedException)
{
    Console.WriteLine("Cursor size is not supported on this platform.");
}

Console.WriteLine("Testing colors");

