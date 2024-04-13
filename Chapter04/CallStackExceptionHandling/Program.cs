using CallStackExceptionHandlingLib;

Console.WriteLine("In Main");
Alpha();

void Alpha()
{
    Console.WriteLine("In Alpha");
    Beta(); 
}


void Beta() {
    Console.WriteLine("In Beta");

    try
    {
        Processor.Gamma();

    }
    catch (Exception e)
    {
        Console.WriteLine("Caught exception in Beta()");
        throw e;
    }
}
