using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> employeeID = new Dictionary<int, string>();

            employeeID[001] = "Bob Smith";
            employeeID[002] = "Mark Jones";
            employeeID[003] = "Allen Roberts";
            employeeID[004] = "Allen Roberts";
            employeeID[005] = "Allen Roberts";
            employeeID[006] = "Allen Roberts";
            employeeID[007] = "James Bond";


            Console.WriteLine("Please enter your employee ID:");
            string empID = Console.ReadLine();
            int.TryParse(empID, out int employID); 
            Console.WriteLine($"You are { employeeID[employID] }");


            Console.ReadLine();
        }

    }
}
