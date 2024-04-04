/*
 * unary operators - work on single operand
 * ++ increment
 * -- decrement
 * nameof
 * typeof
 * sizeof
 * 
*/

var a = 3;

// this assigns b the current value of a THEN increments a
var b = a++;

// a is now 4, b is 3
Console.WriteLine($"a is {a}, b is {b}");

var c = 3;

// this first increments c THEN assigns d the new value of c
var d = ++c;

// c is now 4, d is 4
Console.WriteLine($"c is {c}, d is {d}");

// don't use ++ or -- with assignment in the same statement

/*
 * null-coalescing operator
 *
 * works similar to JS/TS
*/

string? name = "John";

// note the ? for accessing the length property, similar to TS
var nameMaxLength = name?.Length ?? 10;

// this is like doing name = name ?? "default name"
name ??= "default name";

Console.WriteLine(name);