
using Microsoft.EntityFrameworkCore.Sqlite;


namespace EmployeeAppVSCode.EmployeeComponent
{
    public class Employee
    {
        public int Id{get;set;}
        public string FirstName{get;set;}
        public string LastName{get;set;}
        public char Gender{get;set;}

    }

}