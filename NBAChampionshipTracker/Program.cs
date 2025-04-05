using System;

public class Program
{
    public static void Main()
    {
        Dictionary<string, string> yearAndChamps = new Dictionary<string, string>() 
        {
            {"2000", "Los Angeles Lakers"},
            {"2001", "Los Angeles Lakers"},
            {"2002", "San Antonio Spurs"},
            {"2003", "Detroit Pistons"},
            {"2004", "San Antonio Spurs"},
            {"2005", "Miami Heat"},
            {"2006", "San Antonio Spurs"},
            {"2007", "Boston Celtics"},
            {"2008", "Los Angeles Lakers"},
            {"2009", "Los Angeles Lakers"},
            {"2010", "Dallas Mavericks"},
            {"2011", "Miami Heat"},
            {"2012", "Miami Heat"},
            {"2013", "San Antonio Spurs"},
            {"2014", "Golden State Warriors"},
            {"2015", "Cleveland Cavaliers"},
            {"2016", "Golden State Warriors"},
            {"2017", "Golden State Warriors"},
            {"2018", "Toronto Raptors"},
            {"2019", "Los Angeles Lakers"},
            {"2020", "Milwaukee Bucks"},
            {"2021", "Golden State Warriors"},
            {"2022", "Denver Nuggets"},
            {"2023", "Boston Celtics"}

        };

        Dictionary<string, int> teamAndWins = new Dictionary<string, int>()
        {
            {"Los Angeles Lakers", 5},
            {"San Antonio Spurs", 4},
            {"Detroit Pistons", 1},
            {"Miami Heat", 3},
            {"Boston Celtics", 2},
            {"Dallas Mavericks", 1},
            {"Golden State Warriors", 4},
            {"Cleveland Cavaliers", 1},
            {"Toronto Raptors", 1},
            {"Milwaukee Bucks", 1},
            {"Denver Nuggets", 1}
        };

        while (true)
        {
            int isValid = 0;
            Console.WriteLine("NBA Champions Dictionary 2020 - 2023");
            Console.WriteLine("[1] Year");
            Console.WriteLine("[2] Team");
            Console.WriteLine("[3] All Teams and Wins");
            Console.WriteLine("[4] Exit");
            Console.Write("Enter Choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                while (isValid == 0)
                {
                    Console.Write("Enter Year: ");
                    string year = Console.ReadLine();
                    if (yearAndChamps.ContainsKey(year))
                    {
                        Console.WriteLine($"\n{yearAndChamps[year]}\n");
                        isValid = 1;
                    }
                    else
                    {
                        Console.WriteLine("Year not found or Invalid Input, Please try again.");
                    }
                }
            }
            else if (choice == "2")
            {
                while (isValid == 0)
                {
                    Console.Write("Enter Team: ");
                    string team = Console.ReadLine();
                    if (teamAndWins.ContainsKey(team))
                    {
                        Console.WriteLine($"\n{teamAndWins[team]} Wins\n");
                        isValid = 1;
                    }
                    else
                    {
                        Console.WriteLine("Team not found or Invalid Input, Please try again.");
                    }
                }
            }
            else if (choice == "3")
            {
                Console.WriteLine("\n");
                foreach (KeyValuePair<string, int> teams in teamAndWins)
                {
                    Console.WriteLine($"{teams.Key} - {teams.Value} Wins");
                }
                Console.WriteLine("\n");
            }
            else if (choice == "4")
            {
                Console.WriteLine("\nProgram Close\n");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Invalid Input\n");
            }
        }
    }
}