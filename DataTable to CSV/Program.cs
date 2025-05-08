using System;
using System.Data;

class Program
{
    static void Main()
    {
        string First_Name;
        string Middle_Name;
        string Last_Name;
        string Age;
        string Address;
        string Section;

        DataTable students = new DataTable("Students");

        students.Columns.Add("FirstName", typeof(string));
        students.Columns.Add("MiddleName", typeof(string));
        students.Columns.Add("LastName", typeof(string));
        students.Columns.Add("Age", typeof(string));
        students.Columns.Add("Address", typeof(string));
        students.Columns.Add("Section", typeof(string));

        for (int i = 1; i < 4; i++)
        {
            Console.WriteLine($"\nStudent {i} Information:");
            Console.Write("Enter First Name: ");
            First_Name = Console.ReadLine();
       Console.Write("\nEnter Middle Name: ");
            Middle_Name = Console.ReadLine();
            Console.Write("\nEnter Last Name: ");
            Last_Name = Console.ReadLine();
            Console.Write("\nEnter Age: ");
            Age = Console.ReadLine();
            Console.Write("\nEnter Address: ");
            Address = Console.ReadLine();
            Console.Write("\nEnter Section: ");
            Section = Console.ReadLine();

            students.Rows.Add(First_Name, Middle_Name, Last_Name, Age, Address, Section);
        }

                using (StreamWriter sw = new StreamWriter("Students.csv"))
        {
            foreach (DataColumn column in students.Columns)
            {
                if(students.Columns.IndexOf(column) == students.Columns.Count - 1)
                {
                    sw.Write($"{column.ColumnName}");
                }
                else
                {
                    sw.Write($"{column.ColumnName}, ");
                }
            }

            sw.WriteLine();

            foreach (DataRow row in students.Rows)
            {
                sw.WriteLine($"{String.Join(", ", row.ItemArray)}");
            }
        } 
    }
}