// Console.WriteLine("Before parsing");
// Console.Write("What is your age? ");
//
// var input = Console.ReadLine();
//
// try
// {
//     var age = int.Parse(input);
//     Console.WriteLine($"You are {age} years old.");
// }
// catch (FormatException)
// {
//    Console.WriteLine("The age you entered is not a valid number.");
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"{ex.GetType()} says {ex.Message}");
// }
//
// // exception was caught so the program will continue
// // without the catch, this line would have never been reached if an exception was thrown
// Console.WriteLine("After parsing");

// Console.WriteLine("Enter a price without the currency symbol.");
// string amount = Console.ReadLine();
//
// if (string.IsNullOrEmpty(amount))
// {
//     return;
// }
//
// // catching with filters
//
// try
// {
//     decimal amountValue = decimal.Parse(amount);
//     Console.WriteLine($"Amount is {amountValue:C}");
// }
// catch (FormatException) when (amount.Contains('$'))
// {
//     Console.WriteLine("Do not include the currency symbol in the amount.");
// }
// catch (FormatException)
// {
//     Console.WriteLine("The amount entered is not a valid number.");
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"{ex.GetType()} says {ex.Message}");
// }

var x = int.MaxValue - 1;
Console.WriteLine(x);

x++;
Console.WriteLine(x);

x++;
Console.WriteLine(x); // overflow, will wrap around to int.MinValue

// check statement
// these are for checking for overflow and throwing an exception if it happens
// because normally it would wrap around to the minimum value
checked
{
    int y = int.MaxValue - 1;
    Console.WriteLine(y);
    
    y++;
    Console.WriteLine(y);
    
    y++;
    Console.WriteLine(y); // throws System.OverflowException
}
