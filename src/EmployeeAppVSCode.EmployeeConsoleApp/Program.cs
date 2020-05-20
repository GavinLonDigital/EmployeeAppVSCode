using System;
using EmployeeAppVSCode.EmployeeComponent;
using System.Collections.Generic;

namespace EmployeeAppVSCode.EmployeeConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
             List<Employee> employees = new List<Employee>();

             var employee = new Employee{
                 Id = 1,
                 FirstName = "Bob",
                 LastName = "Jones",
                 Gender= 'm'
             };
           
            employees.Add(employee);
           
            employee = new Employee{
                 Id = 2,
                 FirstName = "Theresa",
                 LastName = "Dale",
                 Gender= 'f'
             };
            employees.Add(employee);
            
            employee = new Employee{
                 Id = 3,
                 FirstName = "Greg",
                 LastName = "Akins",
                 Gender= 'm'
             };
            
            employees.Add(employee);

            foreach(var emp in employees)
            {
                Console.WriteLine($"{emp.Id.ToString().PadRight(6)}{emp.FirstName.PadRight(15)}{emp.LastName.PadRight(15)}{emp.Gender.ToString().PadRight(2)}");
            }

        }
    }
}
