using System.Globalization;

partial class Program
{
    /// <summary>
    /// Prints the times table of the given number up to the specified size.
    /// </summary>
    /// <param name="number">Number to be multiplied</param>
    /// <param name="size">Size to go up to. Default is 12</param>
    /// <example>
    /// <code>
    /// TimesTable(7); // prints 7 * 1 up to 7 * 12
    ///
    /// TimesTable(7, 20); // prints 7 * 1 up to 7 * 20
    /// </code>
    /// </example>
    private static void TimesTable(byte number, byte size = 12)
    {
        for (var i = 1; i <= size; i++)
        {
            Console.WriteLine($"{number} * {i} = {number * i}");
        }
    }

    /// <summary>
    /// Calculates the tax amount based on the amount and the two-letter region code.
    ///
    /// Currently only supports the following regions:
    /// <list type="bullet">
    /// <item><description>CH - Switzerland</description></item>
    /// <item><description>DK - Denmark</description></item>
    /// <item><description>NO - Norway</description></item>
    /// <item><description>GB - United Kingdom</description></item>
    /// <item><description>FR - France</description></item>
    /// <item><description>HU - Hungary</description></item>
    /// <item><description>OR - Oregon</description></item>
    /// <item><description>AK - Alaska</description></item>
    /// <item><description>MT - Montana</description></item>
    /// <item><description>CA - California</description></item>
    /// </list>
    ///
    /// If the region is not found, a default tax rate of 6% is applied.
    /// </summary>
    /// <param name="amount">Amount to calculate tax from.</param>
    /// <param name="twoLetterRegionCode">Two letter region code</param>
    /// <returns>
    ///  Calculated tax amount.   
    /// </returns>
    /// <example>
    /// <code>
    ///  CalculateTax(amount: 12.25, twoLetterRegionCode: "CH") // returns 0.9800M
    /// </code>
    /// </example>
    private static decimal CalculateTax(decimal amount, string twoLetterRegionCode)
    {
        var taxRate = twoLetterRegionCode switch
        {
            "CH" => 0.08M,
            "DK" or "NO" => 0.25M,
            "GB" or "FR" => 0.2M,
            "HU" => 0.27M,
            "OR" or "AK" or "MT" => 0.0M,
            "CA" => 0.0825M,
            _ => 0.06M,
        };
        
        return amount * taxRate;
    }

    private static void ConfigureConsole(string culture = "en-US",
        bool useComputerCulture = false)
    {
        // To enable Unicode characters like Euro symbol in the console.
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        if (!useComputerCulture)
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(culture);
        }
        Console.WriteLine($"CurrentCulture: {CultureInfo.CurrentCulture.DisplayName}");
    }

    /// <summary>
    ///  Converts a cardinal number to an ordinal number.
    /// </summary>
    /// <param name="number">Number to convert</param>
    /// <example>
    /// <code>
    /// CardinalToOrdinal(1); // returns "1st"
    /// CardinalToOrdinal(2); // returns "2nd"
    /// CardinalToOrdinal(100); // returns "100th"
    /// </code>
    /// </example>
    private static string CardinalToOrdinal(uint number)
    {
        uint lastTwoDigits = number % 100;
        switch (lastTwoDigits)
        {
            case 11: // Special cases for 11th to 13th.
            case 12:
            case 13:
                return $"{number:N0}th";
            default:
                var lastDigit = number % 10;
                var suffix = lastDigit switch
                {
                    1 => "st",
                    2 => "nd",
                    3 => "rd",
                    _ => "th"
                };
                return $"{number:N0}{suffix}";
        }
    
    }
}