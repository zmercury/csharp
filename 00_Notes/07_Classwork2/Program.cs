namespace _07_Classwork2;

nullable disable;

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        bool found = false;

        Dictionary <string, string> = new Dictionary<string, string>()
        {
            { "ram", "ram123" },
            { "sita ", "sita123" },
            { "hari ", "hari123" },
        };

        Console.WriteLine("Enter username: ");
        string usernameInput = Console.ReadLine();
        Console.WriteLine("Enter password: ");
        string passwordInput = Console.ReadLine();

        if(credentials.ContainsKey(usernameInput))
        {
          found = true;
        }

        if(found)
        {
          Console.WriteLine("Hello , " + usernameInput);
        }
        else
        {
          Console.WriteLine("Incorrect credentials ");
        }
    }
}
