// TimesTable(7, 2);

// you can also specify params
// TimesTable(number: 8, size: 10);

ConfigureConsole(culture: "de-CH");

var amount = 12.25m;
var tax = CalculateTax(amount, twoLetterRegionCode: "CH");
var totalAmount = amount + tax;

Console.WriteLine($"The total amount is {totalAmount:C}");

Console.WriteLine(CardinalToOrdinal(1234));