using System;
using System.Diagnostics.Contracts;
using System.Dynamic;

namespace EmployeeData
{
    public class Employee
    {
        public int Id {set; get;}
        public string Name{set;get;}

        public string Department{set;get;}

        public bool Isparmanent{set; get;}

        public int Salary{set;get;}

         
    }
}