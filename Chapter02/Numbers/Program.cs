// Number Types

// unsigned integer - positive whole numbers or 0
 uint naturalNumber = 23;

// integer - positive or negative whole numbers
int integerNumber = -23;

// float - single-precision floating point
// f suffix is required to specify a float literal
float realNumber = 2.3f;

// double - double-precision floating point
// default for numerical value with a decimal point
 // d suffix is optional for double literals
double anotherRealNumber = 2.3;

// decimal - high-precision floating point
// used for financial and monetary calculations
// m suffix is required for decimal literals
decimal decimalNumber = 2.3m;

/*
 * float vs double vs decimal
 *
 * float is the least precise, but takes up the least amount of memory
 * double is the default for numerical values with a decimal point, middle of the road in terms of precision and memory
 * decimal is the most precise, but takes up the most amount of memory
 *
 * use decimal for financial and monetary calculations
 *
 * never compare doubles using == 
 *
 */
 
 
/*
 * Digital separators
 *
 * you can write _ in between digits to make it easier to read
 * 1 million can be written as 1_000_000 in decimal
 * 
 */
 
 int oneMillion = 1_000_000;
 
 // Console.WriteLine(oneMillion); // 1000000
 
/*
 * binary, octal, and hexadecimal literals
 *
 * binary - base 2, uses 0b prefix
 * octal - base 8, uses 0 prefix
 * hexadecimal - base 16, uses 0x prefix
 * 
 */
 int decimalTen = 10;
 int binaryTen= 0b_1010;
 
 Console.WriteLine(decimalTen == binaryTen); // True
 
// sizeof operator - returns the size of a type in bytes

Console.WriteLine("int variables are {0} bytes ", sizeof(int));
Console.WriteLine("float variables are {0} bytes ", sizeof(float));
Console.WriteLine("double variables are {0} bytes ", sizeof(double));
Console.WriteLine("decimal variables are {0} bytes ", sizeof(decimal));

// max values of number types
Console.WriteLine("Max value of int: {0}", int.MaxValue);
Console.WriteLine("Max value of float: {0}", float.MaxValue);
Console.WriteLine("Max value of double: {0}", double.MaxValue);
Console.WriteLine("Max value of decimal: {0}", decimal.MaxValue);