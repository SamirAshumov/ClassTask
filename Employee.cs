using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask
{
    internal class Employee : Department
    {
        public Employee() { }

        public Employee(string name, string surname, byte age, string departmentName, int salary)

        {
            Name = name;
            Surname = surname;
            Age = age;
            DepartmentName = departmentName;
            Salary = salary;

        }

        public void ShowEmployeeInfo()
        {
            Console.WriteLine($"{Name}  {Surname} age :  {Age} Department :  {DepartmentName} salary :  {Salary}");

        }

        public string Name;
        public string Surname;
        public byte Age;
        public string DepartmentName;
        public int Salary;
    }
}
