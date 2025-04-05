using System;

class Program
{
    static void Main()
    {
       
        Console.Write("Enter a String: ");
        string str = Console.ReadLine();
        str = str.ToLower().Replace(" ", "");
        palindrome(str);
       
    }

    static void palindrome(string str)
    {
        int i = 0;
        int j = str.Length - 1;

        while (i < j)
        {
            if (str[i] != str[j])
            {
                Console.WriteLine("Not a Palindrome");
                return;
            }
            i++;
            j--;
        }
        Console.WriteLine("Palindrome");
    }

}