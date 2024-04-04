using System.Xml;

/*
 *  Some different variable types
 */
 
 // int population = 9_000_000;
 // double weight = 140;
 // decimal price = 71_000;
 // string name = "Steven"; // double quotes for string
 // char letter = 'A'; // single quotes for char
 // bool isHappy = true;
 
/*
 * var keyword
 *
 * compiler can infer type based on initial value
 * similar to TypeScript, can not change type after it is set
 *
 * numbers without decimal points are inferred as int.
 * numbers with decimal points are inferred as double.
 * or you can use suffixes to specify the type
 *
 *
 * var is good to use when the type is obvious like the examples below
 */
 

var population = 9_000_000;
var price = 71_000M; 
var name = "Steven"; 
var letter = 'A'; 
var isHappy = true;

// isHappy = "hello" // error, needs to be a bool

XmlDocument xml1 = new XmlDocument();
var xml2 = new XmlDocument(); // this is easier to read, type is still obvious.

// type here is not clear, so it is better to use the explicit type
// var file1 = File.Create("someFile.txt"); 
//
// // probably better to use explicit type here
// FileStream file2 = File.Create("someFile.txt");

/*
 * targeted-typed new expressions
*/
 
// ReSharper disable once UseCollectionExpression
List<string> names1 = new List<string>();
 
// using  target-typed new expressions
// same as above, but less typ`ing
List<string> name2 = new();

/*
 * default values
 * most primitive types have a default value except for string
 * 
 */

Console.WriteLine($"default(int) = {default(int)}");
Console.WriteLine($"default(bool) = {default(bool)}");
Console.WriteLine($"default(string) = {default(string)}");
Console.WriteLine($"default(DateTime) = {default(DateTime)}");

int x = default; // same as int x = 0;
