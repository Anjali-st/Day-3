using System;

class Program
{
    static void Main()
    {
        // Example using TryParse method to convert string to int
        string intString = "121";
        int intValue;
        if (int.TryParse(intString, out intValue))
        {
            Console.WriteLine("TryParse successful. Converted integer value: " + intValue);
        }
        else
        {
            Console.WriteLine("TryParse failed. Invalid input string.");
        }

        // Example using Convert method to convert string to double
        string doubleString = "7.5";
        try
        {
            double doubleValue = Convert.ToDouble(doubleString);
            Console.WriteLine("Convert successful. Converted double value: " + doubleValue);
        }
        catch (FormatException)
        {
            Console.WriteLine("Convert failed. Invalid input format.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Convert failed. Input value is too large or too small.");
        }

        // Example using Parse method to convert string to decimal
        string decimalString = "3.14";
        try
        {
            decimal decimalValue = decimal.Parse(decimalString);
            Console.WriteLine("Parse successful. Converted decimal value: " + decimalValue);
        }
        catch (FormatException)
        {
            Console.WriteLine("Parse failed. Invalid input format.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Parse failed. Input value is too large or too small.");
        }
        Console.ReadLine();
    }
}