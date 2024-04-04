using System.Reflection;

/*
 * Regions are used to group code together and it makes it collapsible.
 * Not its own scope, so variables declared in a region are still accessible outside of the region.
 * 
 */
#region MyRegion
const int number = 10;
#endregion

// Console.WriteLine(number); // 10

/*Assembly? assembly = Assembly.GetEntryAssembly();

if (assembly is not null)
{
     foreach (AssemblyName name in assembly.GetReferencedAssemblies())
     {
         Assembly a = Assembly.Load(name);
       
         int methodCount = 0;

         foreach (TypeInfo t in a.DefinedTypes)
         {
           methodCount += t.GetMethods().Length;
         }
         
         Console.WriteLine(
            "{0:N0} types with {1:N0} methods in {2} assembly.",
             arg0: a.DefinedTypes.Count(),
             arg1: methodCount,
             arg2: name.Name
        );
     }
     
}*/

// double heightInMeters = 1.88;
// Console.WriteLine($"The variable {nameof(heightInMeters)} has the value {heightInMeters}.");


// verbatim string @
// this makes it so that the string is interpreted as is, so you can use backslashes without escaping them
const string filePath = @"C:\Code\MyCode";
Console.WriteLine(filePath);

// raw string literal (3 or more double quotes)
// if you need to have a string with 3 double quotes, then you can use 4 double quotes, and so on
// useful for writing things like html or json
// you can also use the $$ (double $) for string interpolation

const int age = 27;

var json = $$"""
                 {
                     "name": "Steven",
                     "age": "{{age}}"
                 }
             """;

Console.WriteLine(json);

