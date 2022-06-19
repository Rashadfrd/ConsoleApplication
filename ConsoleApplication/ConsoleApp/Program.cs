using ClassLibrary.MyClasses;
using ClassLibrary.Exceptions;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("alsdak");
            emp.Salary = 230;
            Console.WriteLine(emp.Salary);
            
        
        }
    }
}
