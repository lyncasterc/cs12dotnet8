const string password = "ninja";

if (password.Length < 8)
{
    Console.WriteLine("Password is too short");
}
else
{
    Console.WriteLine("You may proceed.");
}


// pattern matching

object o = "3";
// object o = 3;
var j = 4;

// this is checking if o is an it, and if it is, it assigns it to i

if (o is int i)
{
    Console.WriteLine("o is an integer");
    Console.WriteLine($"o is {i}");
}
else
{
    Console.WriteLine($"{o} is not an integer");
} 


// switch statement
var number = Random.Shared.Next(1, 7);

switch (number)
{
    case 1:
        Console.WriteLine("One");
        break;
    case 2:
        Console.WriteLine("Two");
        goto case 1;
    case 3:
    case 4:
        Console.WriteLine("Three or Four");
        goto case 1;
    case 5:
        goto A_label;
    default:
        Console.WriteLine("Default");
        break;
}

Console.WriteLine("End of switch");

/*
    labels are markers in the code that can be jumped to
    they are not blocks and dont have their own scope
    
    they are essentially a marker for a line of code
    to tell the computer to jump to that line and continue execution
    
    you can use goto to jump to a label from anywhere in the code
    ex: goto A_label;
*/
A_label:
Console.WriteLine("A label");

Console.WriteLine();

var animals = new Animal?[]
{
    new Cat { Name = "Karen", Born = new DateTime(year: 2022, month: 8,
        day: 23), Legs = 4, IsDomestic = true },
    null,
    new Cat { Name = "Mufasa", Born = new DateTime(year: 1994, month: 6,
        day: 12) },
    new Spider { Name = "Sid Vicious", Born = DateTime.Today,
        IsPoisonous = true},
    new Spider { Name = "Captain Furry", Born = DateTime.Today }
};

foreach (Animal? animal in animals)
{
    // string message;
    //
    // switch (animal)
    // {
    //     /*
    //      * this is saying:
    //      *
    //      * when animal is an instance of Cat with a property Legs set to 4,
    //      * assign it to a variable fourLeggedCat and execute the code block
    //      */
    //     case Cat { Legs: 4 } fourLeggedCat:
    //         message = $"{fourLeggedCat.Name} is a cat with 4 legs";
    //         break;
    //     case Cat { IsDomestic: false } wildCat:
    //         message = $"The non-domestic cat is named {wildCat.Name}";
    //         break;
    //     case Cat cat:
    //         message = $"The cat is named {cat.Name}.";
    //         break;
    //     case Spider { IsPoisonous: true } spider:
    //         message = $"{spider.Name} is a poisonous spider";
    //         break;
    //     case null:
    //         message = "No animal";
    //         break;
    //     default:
    //         message = $"{animal.Name} is a {animal.GetType().Name}.";
    //         break;
    // }
    
    
    
    
    /*
     * you can also substitute the switch statement with a switch expression
     *
     * this only works if you trying to assign a value to a variable based on the switch.
    */
    var message = animal switch
    {
        Cat { Legs: 4 } fourLeggedCat => $"{fourLeggedCat.Name} is a cat with 4 legs",
        Cat { IsDomestic: false } wildCat => $"The non-domestic cat is named {wildCat.Name}",
        Cat cat => $"The cat is named {cat.Name}.",
        Spider { IsPoisonous: true } spider => $"{spider.Name} is a poisonous spider",
        null => "No animal",
        _ => $"{animal.Name} is a {animal.GetType().Name}."
    };
    
    Console.WriteLine(message);
}