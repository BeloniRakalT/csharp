using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge_1
{
    // Employee class
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }
    }

    internal class EmployeeManagement
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            int choice;

            do
            {
                Console.WriteLine("\n===== Employee Management Menu =====");
                Console.WriteLine("1. Add New Employee");
                Console.WriteLine("2. View All Employees");
                Console.WriteLine("3. Search Employee by ID");
                Console.WriteLine("4. Update Employee Details");
                Console.WriteLine("5. Delete Employee");
                Console.WriteLine("6. Exit");
                Console.WriteLine("====================================");
                Console.Write("Enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        // Add Employee
                        Employee emp = new Employee();

                        Console.Write("Enter ID: ");
                        emp.Id = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Name: ");
                        emp.Name = Console.ReadLine();

                        Console.Write("Enter Department: ");
                        emp.Department = Console.ReadLine();

                        Console.Write("Enter Salary: ");
                        emp.Salary = Convert.ToDouble(Console.ReadLine());

                        employees.Add(emp);
                        Console.WriteLine("Employee added successfully!");
                        break;

                    case 2:
                        // View All Employees
                        if (employees.Count == 0)
                        {
                            Console.WriteLine("No employees found.");
                        }
                        else
                        {
                            Console.WriteLine("\nEmployee List:");
                            foreach (var e in employees)
                            {
                                Console.WriteLine($"ID: {e.Id}, Name: {e.Name}, Dept: {e.Department}, Salary: {e.Salary}");
                            }
                        }
                        break;

                    case 3:
                        // Search by ID
                        Console.Write("Enter Employee ID to search: ");
                        int searchId = Convert.ToInt32(Console.ReadLine());

                        var foundEmp = employees.FirstOrDefault(e => e.Id == searchId);

                        if (foundEmp != null)
                        {
                            Console.WriteLine($"ID: {foundEmp.Id}, Name: {foundEmp.Name}, Dept: {foundEmp.Department}, Salary: {foundEmp.Salary}");
                        }
                        else
                        {
                            Console.WriteLine("Employee not found.");
                        }
                        break;

                    case 4:
                        // Update Employee
                        Console.Write("Enter Employee ID to update: ");
                        int updateId = Convert.ToInt32(Console.ReadLine());

                        var updateEmp = employees.FirstOrDefault(e => e.Id == updateId);

                        if (updateEmp != null)
                        {
                            Console.Write("Enter new Name: ");
                            updateEmp.Name = Console.ReadLine();

                            Console.Write("Enter new Department: ");
                            updateEmp.Department = Console.ReadLine();

                            Console.Write("Enter new Salary: ");
                            updateEmp.Salary = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Employee updated successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Employee not found.");
                        }
                        break;

                    case 5:
                        // Delete Employee
                        Console.Write("Enter Employee ID to delete: ");
                        int deleteId = Convert.ToInt32(Console.ReadLine());

                        var deleteEmp = employees.FirstOrDefault(e => e.Id == deleteId);

                        if (deleteEmp != null)
                        {
                            employees.Remove(deleteEmp);
                            Console.WriteLine("Employee deleted successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Employee not found.");
                        }
                        break;

                    case 6:
                        Console.WriteLine("Exiting program...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }

            } while (choice != 6);
        }
    }
}