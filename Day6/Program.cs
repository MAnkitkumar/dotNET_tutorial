// See https://aka.ms/new-console-template for more information
using System;
using EmployeeData;

Console.WriteLine("Enter the Data For the Employee: ");

Employee emp1 = new Employee();
Console.WriteLine("Enter the Employee Name: ");
emp1.Name = Console.ReadLine();
Console.WriteLine(emp1.Name);
Console.WriteLine("Enter the Employee Id: ");
emp1.Id = int.Parse(Console.ReadLine());
Console.WriteLine(emp1.Id);
Console.WriteLine("Enter the  Department: ");
emp1.Department = Console.ReadLine();
Console.WriteLine(emp1.Department);
Console.WriteLine("Is Employee Parmanent: ");
emp1.Isparmanent = bool.Parse(Console.ReadLine());
Console.WriteLine("Enter the Salary of the Employee: ");
emp1.Salary = int.Parse(Console.ReadLine());
Console.WriteLine(emp1.Salary);


