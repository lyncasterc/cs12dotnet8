int numberOfApples = 12;
decimal pricePerApple = 0.35M;

// 1:C means format arg 1 as currency
// prints "12 apples costs $4.20"
Console.WriteLine(
    format: "{0} apples costs {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples
);

// you can also store the format string in a variable

var formatted = string.Format(
    format: "{0} apples costs {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples
);

// same output as above
// Console.WriteLine(formatted);

/*
 * WriteLine can have up to 3 numbered args.
 * you also dont have to use named params
*/

Console.WriteLine("{0} apples costs {1:C}", numberOfApples, pricePerApple * numberOfApples);

// (or you can use string interpolation)
Console.WriteLine($"{numberOfApples} apples costs {pricePerApple * numberOfApples:C}");

/*
 * format strings:  
 *  { index [, alignment ] [ : formatString ] }
 *
 * ex: {0,10:C} -> arg 0, right aligned by 10 spaces, formatted as currency
*/


string applesText = "Apples";
int applesCount = 1234;
string bananasText = "Bananas";
int bananasCount = 56789;

Console.WriteLine();

Console.WriteLine("{0, -10} {1,10}", "Name", "Count");
Console.WriteLine("---------------------");
Console.WriteLine("{0, -10} {1,10:N0}", applesText, applesCount);
Console.WriteLine("{0, -10} {1,10:N0}", bananasText, bananasCount);


/* 
 * Getting input
 * 
*/

// Console.Write("Type your first name and press ENTER: ");
// var firstName = Console.ReadLine();
//
// Console.Write("Type your age and press ENTER: ");
// var age = Console.ReadLine();
//
// Console.WriteLine($"Hello, {firstName}, looking pretty good for {age}!");

/*
 * Getting key input
 * key.Key is the name of the key pressed
 * fo example, if D is pressed, key.Key is D
 * 
 * key.keyChar is the actual character (so if D is pressed, keyChar is 'd' lowercase).
 */
 
 Console.Write("Press any key combination: ");
 
 ConsoleKeyInfo key = Console.ReadKey();
 
 Console.WriteLine();
 Console.WriteLine("Key: {0}, Char: {1}, Modifiers: {2}", key.Key, key.KeyChar, key.Modifiers); 