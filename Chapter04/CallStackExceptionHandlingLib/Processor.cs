namespace CallStackExceptionHandlingLib;

public class Processor
{
    public static void Gamma()
    {
        Console.WriteLine("Gamma() invoked");
        Delta();
    }

    private static void Delta()
    {
        Console.WriteLine("Delta() invoked");
        File.OpenText("bad file name"); // will throw an exception
    }
}