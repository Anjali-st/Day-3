using System;

class Program
{
    static void Main()
    {
        // Convert string to integer using TryParse
        string numberString = "10";
        int number;
        if (int.TryParse(numberString, out number))
        {
            int multipliedNumber = number * 5;
            Console.WriteLine("Converted and multiplied value: " + multipliedNumber);
        }
        else
        {
            Console.WriteLine("Error: Unable to convert string to integer.");
        }

        // Convert string to DateTime using Convert
        string dateString = "2022-01-01";
        try
        {
            DateTime date = Convert.ToDateTime(dateString);
            DateTime subtractedDate = date.AddMonths(-1);
            Console.WriteLine("Subtracted date: " + subtractedDate.ToString("yyyy-MM-dd"));
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid date format.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        // Convert string to TimeSpan using Parse
        string timeString = "02:30:00";
        try
        {
            TimeSpan time = TimeSpan.Parse(timeString);
            TimeSpan addedTime = time.Add(new TimeSpan(2, 0, 0));
            Console.WriteLine("Added time: " + addedTime);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid time format.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        Console.ReadLine();
    }
}
