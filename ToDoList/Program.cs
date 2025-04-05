using System;
using System.Globalization;

public class TODO
{
    public static void Main()
    {
        List<List<string>> taskInfo = new List<List<string>>();
        string taskName = " ";
        string choice = " ";
        string dueDate = "";
        int numberOfTask = 0;
        while (true)
        {
            guide();
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Enter Task Name: ");
                taskName = Console.ReadLine();   
                Console.Write("\nFormat: MM/dd/yyyy hh:mm tt\nEnter Due Date: ");
                dueDate = Console.ReadLine();

                DateTime DUE_DATE = DateTime.ParseExact(dueDate, "MM/dd/yyyy hh:mm tt", CultureInfo.InvariantCulture );

                DateTime CURRENT_DATE = DateTime.Now;

                TimeSpan days = DUE_DATE - CURRENT_DATE;

                string daysleft = days.ToString(@"d\d\ h\h\ m\m");
                string duedate = DUE_DATE.ToString("MM/dd/yy hh:mm tt");
                numberOfTask = numberOfTask + 1;
                string strNOT = Convert.ToString(numberOfTask);
                taskInfo.Add(new List<string> {strNOT, taskName, dueDate, daysleft});
            }
            else if (choice == "2")
            {
                if (numberOfTask == 0)
                {
                    Console.Write("Add a Task First\n");
                }
                else
                {
                    Console.Write("Task Number   Task Name   Due Date   Time Left\n");
                    for (int j = 0; j < numberOfTask; j++)
                    {
                        Console.Write($"{taskInfo[j][0]}     {taskInfo[j][1]}     {taskInfo[j][2]}     {taskInfo[j][3]} \n");
                    }
                    Console.Write("Number of Task to Remove: ");
                    string rev = Console.ReadLine();
                    int intRev = Convert.ToInt32(rev);
                    taskInfo.RemoveAt(intRev - 1);
                    numberOfTask = numberOfTask - 1;
                }
            
            }
            else if (choice == "3")
            {
                if (numberOfTask == 0)
                {
                    Console.Write("Add a Task First'\n");
                }
                else
                {
                    Console.Write("Task Number   Task Name   Due Date   Time Left\n");
                    for (int j = 0; j < numberOfTask; j++)
                    {
                            Console.Write($"{taskInfo[j][0]}   {taskInfo[j][1]}   {taskInfo[j][2]}   {taskInfo[j][3]} \n");
                    }
                }
                
            }
            else if (choice == "4")
            {
                Console.Write("Goodbye!\n");
                break;
            }
            else
            {
                Console.Write("Invalid Input. Please Try Again.\n");
            }
        }
    }

    public static void guide()
    {
        Console.Write("TODO LIST\n");
        Console.Write("[1] Add Task\n");
        Console.Write("[2] Remove Task\n");
        Console.Write("[3] View Task\n");
        Console.Write("[4] Exit\n");
        Console.Write("Enter: ");
    }
}