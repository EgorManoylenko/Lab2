using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2._7
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }

        public string Appointment { get; set; }

        public int Experience { get; set; }

        public Employee(string firstName, string secondName)
        {
            FirstName = firstName;
            SecondName = secondName;
        }

        public void CalculateSalaryAndTax(out double salary, out double tax)
        {
            double baseSalary = 0d;

            switch (Appointment)
            {
                case "Developer":
                    baseSalary = 15000d;
                    break;

                case "Manager":
                    baseSalary = 10000d;
                    break;

                case "Director":
                    baseSalary = 20000d;
                    break;
            }

            salary = baseSalary * Experience / 2d;
            tax = salary * 0.2d;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding =
                Console.OutputEncoding =
                    System.Text.Encoding.Unicode;

            var employee = new Employee("John", "Doe")
            {
                Appointment = "Developer",
                Experience = 4
            };

            employee.CalculateSalaryAndTax(
                out double salary,
                out double tax
            );

            Console.WriteLine($"Name: {employee.FirstName} {employee.SecondName}");
            Console.WriteLine($"Appointment: {employee.Appointment}");
            Console.WriteLine($"Salary: {salary}");
            Console.WriteLine($"Tax: {tax}");

            Console.ReadLine();
        }
    }
}
