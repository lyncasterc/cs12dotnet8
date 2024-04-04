var x = 0;

while (x < 10)
{
    Console.WriteLine(x);
    x++;
}

// const string? savedPassword = "password";
// string? enteredPassword;
// var tries = 0;
//
// do
// {   
//     Console.WriteLine($"Enter your password - tries: {tries + 1}");
//     enteredPassword = Console.ReadLine();
//     tries++;
// }
// while (enteredPassword != savedPassword && tries < 3);
//
// Console.WriteLine(tries < 3 ? "Correct!" : "You have been locked out.");

// this does the same thing as the do while loop above
// while (true)
// {
//     Console.WriteLine("Enter your password");
//     enteredPassword = Console.ReadLine();
//
//     if (enteredPassword == savedPassword)
//     {
//         break;
//     }
// }

var loops = 0;

// reverse loop 
for (var i = 100; i > 0; i--)
{
    loops++;
}

Console.WriteLine(loops); // 

string[] names = ["Adam", "Barry", "Charlie"];

foreach (var name in names)
{
    Console.WriteLine($"{name} has {name.Length} characters.");
}

// reverse loop through an array
for (var i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}
