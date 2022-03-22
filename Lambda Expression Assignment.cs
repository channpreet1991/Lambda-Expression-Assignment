
using System;
using System.Collections.Generic;
using System.Linq;
// Define Employee Class to store employee objects
public class Employee {
        public int Id {get; set;}
        public string firstName {get;set;}
        public string lastName {get;set;}

        public Employee(int Id, string firstName, string lastName)
        {
            this.Id = Id;
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
 class Program
    {
        static void Main(string[] args)
        {
            // Define the Employees List
            List<Employee> employees = new List<Employee>()
            {
                new Employee(1,"Joe","Biden"),
                new Employee(2,"Joe","Sanders"),
                new Employee(3,"San","Maden"),
                new Employee(4,"Julius","Caeser"),
                new Employee(5,"San","Mario"),
                new Employee(6,"Berry","Sanders"),
                new Employee(7,"Kate","Perry"),
                new Employee(8,"Christiano","Ronaldo"),
                new Employee(9,"George","Harrison"),
                new Employee(10,"George","Bush"),
                
            };
            // Using a foreach loop, create a new list of all employees with the first name "Joe".
            List<Employee> employeeWtihJoe = new List<Employee>();
            foreach (var employee in employees)
            {
                if (employee.firstName == "Joe")
                {
                    employeeWtihJoe.Append(employee);
                }
            }
            // Perform the same action again, but this time with a lambda expression.
            List<Employee> employeeWtihJoeLambda = employees.Where(x => x.firstName == "Joe").ToList();
            // Using a lambda expression, make a list of all employees with an Id number greater than 5.
            List<Employee> emploeeGreaterthanId5 = employees.Where(x => x.Id > 5).ToList();
            // Display the results (Just for your verfication. You can remove after you verified this solution)
            Console.WriteLine("Employees with First Name as Joe:");
            foreach (var employee in employeeWtihJoeLambda)
            {
                Console.WriteLine($"{employee.firstName} {employee.lastName}");
            }
            Console.WriteLine("\nEmployees with Id >5 :");
            foreach (var employee in emploeeGreaterthanId5)
            {
                Console.WriteLine($"{employee.firstName} {employee.lastName}");
            }
        }
    }