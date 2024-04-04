/*
 * 1. statement to discover compiler and language version
 * when you run the statement below, you see:
 * "Compiler version: '4.9.2-3.24129.6 (9934fb9e)'. Language version: 12.0."
 */

// #error version

/*
* 3. diff between verbatim and interpolated strings
*
* verbatim strings:
* - are prefixed with @
* - contain all the characters within the string exactly as they are, including the escape characters like "\"
*
*
* interpolated strings:
* - are prefixed with $
* - allow you to put values of variables or expressions within the string using curly braces {}
*/

// var verbatimString = @"\n\n\n";
// Console.WriteLine(verbatimString); // prints \n\n\n, not new lines
//
// var interpolatedString = $"I am {20 + 7} years old";
// Console.WriteLine(interpolatedString); // prints I am 27 years old


/*
* 4. why should you be careful with double and float
*
* double and float are not very precise and not good to use with the == operator
* for example if you want to check if 0.1 + 0.2 is equal to 0.3, you will get false with float
*
* don't use double or float for precise calculations like financial calculations
*/

// var x = 0.1d; // double
// var y = 0.2d;
//
// Console.WriteLine(x + y == 0.3d); // prints false
// Console.WriteLine(x + y); // prints 0.30000000000000004

/*
* 5. getting size of types in bytes
* 
*/

// Console.WriteLine(sizeof(int)); // prints 4

/*
* 6. when to use var
*
* when the type is obvious from the initial value
*/

/*
* 7. target-typed new expressions
*/

// this is the old way
// List<string> names1 = new List<string>();

// this is the new way with target-typed new expressions
// List<int> ages1 = new();

/*
 * 9. right-aligning text
 *  { index [, alignment ] [ : formatString ] }
 * alignment being positive right-aligns, negative left-aligns
 */
 
 // Console.WriteLine("{0,10}", "Hello"); // prints "     Hello"
 // Console.WriteLine("{0,-10}", "Hello"); // prints "Hello     "
 