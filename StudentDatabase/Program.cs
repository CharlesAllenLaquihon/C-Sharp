using System;

public class HelloWorld
{
    public static List<string> students = new List<string>();

    public static void Main()
    {
        Switch();
    }

    public static int addStudents()
    {
        string newStudent = studentName();
        if (students.Contains(newStudent))
        {
            Console.WriteLine("\nStudent Already Exists\n");
            return 0;
        }
        else
        {
            students.Add(newStudent);
            Console.WriteLine("\nStudent Successfully Added\n");
            return 1;
        }
    }

    public static int removeStudents()
    {
        string name2 = studentName();

        if (students.Contains(name2))
        {
            students.Remove(name2);
            Console.WriteLine("\nStudent Successfully Removed\n");
            return 1;
        }
        else
        {
            Console.WriteLine("\nStudent is not in the list\n");
            return 0;
        }
    }

    public static int countStudents()
    {
        Console.WriteLine("\nNumber of Students: " + students.Count + "\n");
        return students.Count;
    }

    public static string findStudents()
    {
        if (students.Contains(studentName()))
        {
            return "\nStudent is in the List\n";
        }
        else
        {
            return "\nStudent is not in the List\n";
        }
    }

    public static int indexStudents()
    {
        string name = studentName();
        if (students.Contains(name))
        {
            int index = students.IndexOf(name);
            return index;
        }
        else
        {
            return -1;
        }
    }

    public static string studentName()
    {
        Console.Write("\nStudent Name: ");
        string student = Console.ReadLine();
        return student;
    }

    public static void printStudents()
    {
        Console.WriteLine("\nStudents List:\n");
        foreach (string student in students)
        {
            Console.WriteLine(student);
        }
        Console.WriteLine();
    }

    public static int showChoices()
    {
        Console.WriteLine("\n[1] Add Student");
        Console.WriteLine("[2] Remove Student");
        Console.WriteLine("[3] Find Student");
        Console.WriteLine("[4] Student Count");
        Console.WriteLine("[5] Get Student Index");
        Console.WriteLine("[6] Print List");
        Console.WriteLine("[7] End Program\n");
        Console.Write("Enter Input: ");
        int choice = Int32.Parse(Console.ReadLine());
        return choice;
    }

    public static void Switch()
    {
        int loop = 0;
        int studentNum = 0;

        while (loop == 0)
        {
            students.Sort();

            switch (showChoices())
            {
                case 1:
                    Console.WriteLine();
                    int stu = addStudents();
                    Console.WriteLine();
                    studentNum += stu;
                    break;

                case 2:
                    if (studentNum == 0)
                    {
                        Console.WriteLine("\nAdd a Student First\n");
                        break;
                    }
                    Console.WriteLine();
                    removeStudents();
                    Console.WriteLine();
                    studentNum--;
                    break;

                case 3:
                    if (studentNum == 0)
                    {
                        Console.WriteLine("\nAdd a Student First\n");
                        break;
                    }
                    Console.WriteLine();
                    Console.WriteLine(findStudents());
                    Console.WriteLine();
                    break;

                case 4:
                    if (studentNum == 0)
                    {
                        Console.WriteLine("\nAdd a Student First\n");
                        break;
                    }
                    Console.WriteLine();
                    Console.WriteLine(countStudents());
                    Console.WriteLine();
                    break;

                case 5:
                    if (studentNum == 0)
                    {
                        Console.WriteLine("\nAdd a Student First\n");
                        break;
                    }
                    int indexstudent = indexStudents();
                    if (indexstudent == -1)
                    {
                        Console.WriteLine("\nStudent is not in the list\n");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine(indexstudent);
                        Console.WriteLine();
                    }
                    break;

                case 6:
                    if (studentNum == 0)
                    {
                        Console.WriteLine("\nAdd a Student First\n");
                        break;
                    }
                    Console.WriteLine();
                    printStudents();
                    Console.WriteLine();
                    break;

                case 7:
                    Console.WriteLine("\nThank you\n");
                    loop = 1;
                    break;
            }
        }
    }
}