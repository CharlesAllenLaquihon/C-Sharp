using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;

class Program
{

    static DataTable employees = CSVToDataTable("Employees.csv");

    static DataTable CSVToDataTable(string csvFile)
    {
        DataTable dt = new DataTable();
        
        using (StreamReader sr = new StreamReader(csvFile))
        {
            bool isFirstRow = true;

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] values = line.Split(',');

                if (isFirstRow)
                {
                    foreach (string header in values)
                    {
                        dt.Columns.Add(header, typeof(string));
                    }

                    isFirstRow = false;
                }
                else
                {
                    dt.Rows.Add(values);
                }
            }
        }

        return dt;
    }


    static void Main()
    {
        int loop = 1;

        while (loop == 1)
        {
        
        Console.WriteLine("EMPLOYEES\n");
        Console.WriteLine("[1] Get Employees by department");
        Console.WriteLine("[2] Get Average salary by department");
        Console.WriteLine("[3] Get Employees with the most skill");
        Console.WriteLine("[4] Get Employee with the specific skill");
        Console.WriteLine("[5] Get Department with highest salary allocation");
        Console.WriteLine("[6] Exit\n");
        Console.Write("Select an option: ");

        string option = Console.ReadLine();

        Employee employee = new Employee();

        if (option == "1")
        {
            employee.GetEmployeesByDepartment();
        }
        else if (option == "2")
        {
            employee.GetAverageSalaryByDepartment();
        }
        else if (option == "3")
        {
            employee.GetEmployeesWithMostSkill();
        }
        else if (option == "4")
        {
            employee.GetEmployeeWithSpecificSkill();
        }
        else if (option == "5")
        {
            employee.GetDepartmentWithHighestSalaryAllocation();
        }
        else if (option == "6")
        {
            loop = 0;
            Console.WriteLine("Goodbye!");
        }
        else
        {
            Console.WriteLine("Invalid option. Please try again.");
        }
        }
    }























































public class Employee
{
    public void GetEmployeesByDepartment()
    {
        string choice = "";
        int valid1 = 0;
        do
        {
            while (valid1 != 0)
            {
                Console.WriteLine("Invalid Input. Please try again.");
            }
            Console.WriteLine("'\nDEPARTMENTS");
            Console.WriteLine("[A] Engineering");
            Console.WriteLine("[B] Marketing");
            Console.WriteLine("[C] HR");
            Console.WriteLine("[D] Finance");
            Console.WriteLine("[E] IT");
            Console.Write("Enter department: ");
            choice = Console.ReadLine().ToUpper();
            valid1++;
        }while (choice != "A" && choice != "B" && choice != "C" && choice != "D" && choice != "E");
        
        string department = "";
        switch (choice)
        {
            case "A":
                department = "Engineering";
                break; 
            case "B":
                department = "Marketing";
                break;
            case "C":
                department = "HR";
                break;
            case "D":
                department = "Finance";
                break;
            case "E":
                department = "IT";
                break;
        }

        int valid2 = 0;
        string sort = "";
        do
        {
            while (valid2 != 0)
            {
                Console.WriteLine("Invalid Input. Please try again.");
                break;
            }

            Console.WriteLine("[A] Sort By Salary");
            Console.WriteLine("[B] Sort By Experience");
            Console.Write("Enter Choice: ");
            sort = Console.ReadLine().ToUpper();
            valid2++;
        }while (sort != "A" && sort != "B");

        int valid3 = 0;
        string order = "";
        do
        {
            while (valid3 != 0)
            {
                Console.WriteLine("Invalid Input. Please try again.");
                break;
            }

            Console.WriteLine("[Y] Ascending");
            Console.WriteLine("[N] Descending");
            Console.Write("Enter Choice: ");
            order = Console.ReadLine().ToUpper();
            valid3++;
        }while (order != "Y" && order != "N");



        if (sort == "A")
        {
            while(order == "Y")
            {
                foreach(DataRow row in employees.AsEnumerable()
                                                                        .Where(Row => Row["Department"].ToString() == department)
                                                                        .OrderBy(row => Convert.ToInt32(row["Salary"])))
                {
                    Console.WriteLine(String.Join(", ", row.ItemArray));
                }
                break;
            }

            while (order == "N")
            {
                foreach(DataRow row in employees.AsEnumerable()
                                                                        .Where(Row => Row["Department"].ToString() == department)
                                                                        .OrderByDescending(row => Convert.ToInt32(row["Salary"])))
                {
                    Console.WriteLine(String.Join(", ", row.ItemArray));
                }
                break;
            }
        }
        else if (sort == "B")
        {
            while(order == "Y")
            {
                foreach(DataRow row in employees.AsEnumerable()
                                                                        .Where(Row => Row["Department"].ToString() == department)
                                                                        .OrderBy(row => Convert.ToInt32(row["ExperienceYears"])))
                {
                    Console.WriteLine(String.Join(", ", row.ItemArray));
                }
                break;
            }

            while (order == "N")
            {
                foreach(DataRow row in employees.AsEnumerable()
                                                                        .Where(Row => Row["Department"].ToString() == department)
                                                                        .OrderByDescending(row => Convert.ToInt32(row["ExperienceYears"])))
                {
                    Console.WriteLine(String.Join(", ", row.ItemArray));
                }
                break;
            }
        }
        
    }





















    public void GetAverageSalaryByDepartment()
    {
         string choice = "";
        int valid1 = 0;
        do
        {
            while (valid1 != 0)
            {
                Console.WriteLine("Invalid Input. Please try again.");
            }
            Console.WriteLine("\nDEPARTMENTS");
            Console.WriteLine("[A] Engineering");
            Console.WriteLine("[B] Marketing");
            Console.WriteLine("[C] HR");
            Console.WriteLine("[D] Finance");
            Console.WriteLine("[E] IT");
            Console.Write("Enter department: ");
            choice = Console.ReadLine().ToUpper();
            valid1++;
        }while (choice != "A" && choice != "B" && choice != "C" && choice != "D" && choice != "E");
        
        string department = "";
        switch (choice)
        {
            case "A":
                department = "Engineering";
                break; 
            case "B":
                department = "Marketing";
                break;
            case "C":
                department = "HR";
                break;
            case "D":
                department = "Finance";
                break;
            case "E":
                department = "IT";
                break;
        }

        double average = employees.AsEnumerable()
                                                        .Where(row => row["Department"].ToString() == department)
                                                        .Average(row => Convert.ToInt32(row["Salary"]));

        Console.WriteLine($"{department} : {average}.");
    }












    public void GetEmployeesWithMostSkill()
    {
        //kukunin dito yung number ng pinakamataas na skill count tapos pang comapre sa baba
        int number_of_skills = employees.AsEnumerable()
                                                                .Max(row => row["Skills"]
                                                                .ToString()
                                                                .Split(';').Length);


        var employees_with_most_skills = employees.AsEnumerable()
                                                                                .Where(row => row["Skills"]
                                                                                .ToString()
                                                                                .Split(';').Length == number_of_skills);

        foreach (DataRow row in employees_with_most_skills)
        {
            Console.WriteLine(String.Join(", ", row.ItemArray));
        }

        
    }















    public void GetEmployeeWithSpecificSkill()
    {
            Console.Write("Enter skill: ");
            string skill = Console.ReadLine().ToLower();

            var employees_with_skill = employees.AsEnumerable()
                                                                        .Where(row => row["Skills"]
                                                                        .ToString()
                                                                        .ToLower()
                                                                        .Contains(skill));

            foreach (DataRow row in employees_with_skill)
            {
                Console.WriteLine(String.Join(", ", row.ItemArray));
            }
    }

















    public void GetDepartmentWithHighestSalaryAllocation()
    {
        var highest = employees.AsEnumerable()
                                                .GroupBy(row => row["Department"].ToString()) 
                                                .OrderByDescending(department => department.Sum(row => Convert.ToInt32(row["Salary"]))) 
                                                .First(); 

        Console.WriteLine($" {highest.Key}: {highest.Sum(row => Convert.ToInt32(row["Salary"]))}");
    }

}
}