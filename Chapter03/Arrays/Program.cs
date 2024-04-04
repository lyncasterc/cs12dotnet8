string[] names;

// allocate memory for 4 strings
names = new string[4];

names[0] = "Kate";
names[1] = "Jack";
names[2] = "Rebecca";
names[3] = "Tom";

// using collection expression
string[] names2 = ["Kate", "Jack", "Rebecca", "Tom"];


// multidimensional arrays

string[,] grid1 =
{
    {"A1", "B1", "C1", "D1"},
    {"A2", "B2", "C2", "D2"},
    {"A3", "B3", "C3", "D3"}
};

// getting the first and last index of the outer array
Console.WriteLine($"1st dimension, lower bound: {grid1.GetLowerBound(0)}");
Console.WriteLine($"1st dimension, upper bound: {grid1.GetUpperBound(0)}");

// getting the first and last index of the inner arrays
Console.WriteLine($"2nd dimension, lower bound: {grid1.GetLowerBound(1)}");
Console.WriteLine($"2nd dimension, upper bound: {grid1.GetUpperBound(1)}");

// GetLength gets the length of the array at the specified dimension
var outerLength = grid1.GetLength(0);
var innerLength = grid1.GetLength(1);

for (var i = 0; i < outerLength; i++)
{
    for (var j = 0; j < innerLength; j++)
    {
        Console.WriteLine($"Element at ({i}, {j}): {grid1[i, j]}");
    }
}


// allocating memory for a multidimensional array

var grid2 = new string[3, 4];

/*
 
jagged arrays - multidimensional arrays of different lengths
 
jagged arrays are arrays of arrays because each inner is stored in separate memory locations

collection expression can be used to initialize jagged arrays
*/

string[][] jaggedArray =
[
    ["A1", "B1", "C1", "D1"],
    ["A2", "B2", "C2"],
    ["A3", "B3"]
];

// getting the length of the outer array
var outerLength2 = jaggedArray.GetLength(0);

Console.WriteLine($"jaggedArray has {outerLength2} inner arrays");

Console.WriteLine();

int[] sequentialNumbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
int[] oneTwoNumbers = [1, 2];
int[] oneTwoTenNumbers = [1, 2, 10];
int[] oneTwoThreeTenNumbers = [1, 2, 3, 10];
int[] primeNumbers = [2, 3, 5, 7, 11, 13, 17, 19, 23, 29];
int[] fibonacciNumbers = [0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89]; 
int[] emptyNumbers = []; 
int[] threeNumbers = [9, 7, 5];
int[] sixNumbers = [9, 7, 5, 4, 2, 10];

Console.WriteLine($"{nameof(sequentialNumbers)}:{CheckArray(sequentialNumbers)}");
Console.WriteLine($"{nameof(oneTwoNumbers)}: {CheckArray(oneTwoNumbers)}");
Console.WriteLine($"{nameof(oneTwoTenNumbers)}:{CheckArray(oneTwoTenNumbers)}");
Console.WriteLine($"{nameof(oneTwoThreeTenNumbers)}:{CheckArray(oneTwoThreeTenNumbers)}");
Console.WriteLine($"{nameof(primeNumbers)}: {CheckArray(primeNumbers)}");
Console.WriteLine($"{nameof(fibonacciNumbers)}:{CheckArray(fibonacciNumbers)}");
Console.WriteLine($"{nameof(emptyNumbers)}: {CheckArray(emptyNumbers)}");
Console.WriteLine($"{nameof(threeNumbers)}: {CheckArray(threeNumbers)}");
Console.WriteLine($"{nameof(sixNumbers)}: {CheckArray(sixNumbers)}");


static string CheckArray(int[] numbers) => numbers switch
{
    [] => "Empty array",
    [1, 2, _, 10] => "Contains, 1, 2, a single number, 10",
    [1, 2, .., 10] => "Contains 1, 2, 0+ numbers, 10",
    [1, 2] => "Contains exactly 1, 2",
    [var item1, var item2, var item3] => $"Contains 3 items: {item1}, {item2}, {item3}",
    [0, _] => "Starts with 0, then one other number.",
    [0, ..] => "Starts with 0, then any range of numbers.",
    [2, .. int[] rest] => $"Contains 2 and then {rest.Length} more numbers",
    [..] => "Any items in any order.",
};