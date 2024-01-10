// See https://aka.ms/new-console-template for more information
using ConsoleApp2;

Console.WriteLine("Hello, World!");
List<Employee> employees = new List<Employee>() {
new Employee() { id = 1, name = "sam", designation = "developer", doj = new DateTime(day: 12, month: 09, year: 2022) },
new Employee() { id = 2, name = "jam", designation = "tester", doj = new DateTime(day: 15, month: 11, year: 2020) },
new Employee() { id = 3, name = "ram", designation = "marketing", doj = new DateTime(day: 19, month: 10, year: 2023) },
new Employee() { id = 4, name = "pam", designation = "developer", doj = new DateTime(day: 10, month: 12, year: 2021) },
};
Console.WriteLine("id\t name\t designation \t date of joining");
foreach(Employee emp in employees)
{
    Console.Write(emp.id+"\t \t");
    Console.Write(emp.name+"\t \t");
    Console.Write(emp.designation + "\t \t");
    Console.Write(emp.doj.ToLongDateString());
    Console.WriteLine("\n");
    Console.WriteLine("\n");
}
Console.ReadKey();