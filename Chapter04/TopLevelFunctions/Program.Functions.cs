partial class Program
{
    private static void WhatsMyNameSpace()
    {
        Console.WriteLine($"Namespace of Program class: {typeof(Program).Namespace ?? "null"}");
    }
}