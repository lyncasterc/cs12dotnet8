using System.Globalization;

CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("es-MX");

// int can be implicitly converted to double
int a = 10;
double b = a;

// double cannot be implicitly converted to int
double c = 9.8;
// int d = c; // compile error

int d = (int)c; // explicit conversion, loses the decimal part

Console.WriteLine(d);

long e = 10;
int f = (int)e;

e = long.MaxValue;
f = (int)e; // f is -1, because the value is too large to fit in an int

Console.WriteLine($"long is {e:N0} and int is {f:N0}");

double g = 9.8;

// casting removes the decimal part
// converting rounds to the nearest whole number
int h = Convert.ToInt32(g);

Console.WriteLine(h);

// manually rounding
Console.WriteLine(Math.Round(12.5)); // 12

Console.WriteLine(Math.Round(12.5, MidpointRounding.AwayFromZero)); // 13

// converting from any type to string
int number = 12;
Console.WriteLine(number.ToString());

bool boolean = true;
Console.WriteLine(boolean.ToString());

DateTime now = DateTime.Now;
Console.WriteLine(now.ToString());  

object me = new object();
Console.WriteLine(me.ToString());

int friends = int.Parse("27");
DateTime birthday = DateTime.Parse("4 June 1980");
Console.WriteLine($"I have {friends} friends to invite to my party.");
Console.WriteLine($"My birthday is {birthday}.");
Console.WriteLine($"My birthday is {birthday:D}.");


/*
 *  Try convention
 *
 * for any method named Something, there is a TrySomething method that returns a boolean for success or failure
 *
 * it also has an out parameter that returns the result
 * 
 */
 
// could throw an exception if the string is not a number
 int boop = int.Parse("123");
 
 bool success = int.TryParse("123", out int result);
 
 Console.WriteLine($"result from TryParse: {result}");