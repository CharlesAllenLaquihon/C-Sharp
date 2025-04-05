using System;
using System.Globalization;
class Program
{

    static string INPUT()
    {
        Console.WriteLine("FORMAT: Month-Day-Year\nEXAMPLE: 05-04-2006");
        Console.Write("Enter your Birthday: ");
        string USER_INPUT = Console.ReadLine();
        return USER_INPUT;
    }

    static TimeSpan DATETIME()
    {
         string INPUT_BIRTHDATE = INPUT();

        DateTime CURRENT_DATE = DateTime.Now;
        DateTime BIRTH_DATE = DateTime.ParseExact(INPUT_BIRTHDATE, "MM-dd-yyyy", CultureInfo.InvariantCulture );

        int CURRENT_YEAR = CURRENT_DATE.Year;
        int BIRTH_YEAR = BIRTH_DATE.Year;

        DateTime NEW_BIRTH_DATE = BIRTH_DATE.AddYears(CURRENT_YEAR - BIRTH_YEAR);

        TimeSpan DAYS_DIFFERENCE = NEW_BIRTH_DATE - CURRENT_DATE;

        return DAYS_DIFFERENCE;
    }

    static void BIRTHDAY()
    {
        TimeSpan BIRTHDAY = DATETIME();

        if(BIRTHDAY.Days == 0)
        {
            Console.Write("HAPPY BIRTHDAY!!");
        }
        else if(BIRTHDAY.Days > 0 )
        {
            Console.WriteLine("You're Birthday has not yet passed");
            Console.Write($"{BIRTHDAY.Days} days until your birthday");
        }
        else if(BIRTHDAY.Days < 0)
        {
            Console.WriteLine("You're Birthday has already passed");
            Console.Write($"{BIRTHDAY.Days - BIRTHDAY.Days - BIRTHDAY.Days} days since your birthday");
        }
    }

    static void Main()
    {
        BIRTHDAY();
    }

}            