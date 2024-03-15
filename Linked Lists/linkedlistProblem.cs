/*
Problem Statement: Managing Employee Records
Suppose you're developing software for a human resources department to manage employee records. 
Each employee has information such as their employee ID, name, position, salary, and contact details.

Solution: Using a Linked List
You can use a linked list to efficiently manage employee records. Each node of the linked list can represent an employee, 
containing all the necessary information about them. The linked list allows for dynamic addition and
 removal of employees as well as traversal for tasks such as searching for a specific employee or displaying all employee records.

*/


using System;

class Employee
{
    public int EmployeeId { get; set; }
    public string Name { get; set; }
    public string Position { get; set; }
    public decimal Salary { get; set; }
    public string ContactInfo { get; set; }
    public Employee Next { get; set; }

    public Employee(int employeeId, string name, string position, decimal salary, string contactInfo)
    {
        EmployeeId = employeeId;
        Name = name;
        Position = position;
        Salary = salary;
        ContactInfo = contactInfo;
        Next = null;
    }
}

class EmployeeLinkedList
{
    private Employee head;

    public EmployeeLinkedList()
    {
        head = null;
    }

    public void AddEmployee(Employee employee)
    {
        if (head == null)
        {
            head = employee;
        }
        else
        {
            Employee current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = employee;
        }
    }

    public void DisplayEmployees()
    {
        Employee current = head;
        Console.WriteLine("Employee Records:");
        while (current != null)
        {
            Console.WriteLine($"ID: {current.EmployeeId}, Name: {current.Name}, Position: {current.Position}, Salary: {current.Salary}, Contact: {current.ContactInfo}");
            current = current.Next;
        }
    }
}

class Program
{
    static void Main()
    {
        EmployeeLinkedList employeeList = new EmployeeLinkedList();
        employeeList.AddEmployee(new Employee(1001, "John Doe", "Software Engineer", 60000, "john.doe@example.com"));
        employeeList.AddEmployee(new Employee(1002, "Jane Smith", "HR Manager", 75000, "jane.smith@example.com"));

        employeeList.DisplayEmployees();
    }
}
