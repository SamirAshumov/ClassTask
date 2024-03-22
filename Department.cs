using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask
{
    internal class Department
    {
        public Department()    {  }

        public Employee[] Employees = new Employee[] { };

        public void AddEmployee(Employee employee)
        {
            Array.Resize(ref Employees, Employees.Length + 1);
            Employees[Employees.Length - 1] = employee;
        }

        public Employee[] GetAllEmployees()
        {
            return Employees;
        }

        public void ShowAllEmployees()
        {
            for (int i = 0; i < Employees.Length; i++)
            {
                Employees[i].ShowEmployeeInfo();
            }
        }

        public void GetAllEmployeesBySalary(int min, int max)
        {
            for (int i = 0; i < Employees.Length; i++)
            {
                if (min < Employees[i].Salary && Employees[i].Salary < max)
                {
                    Console.WriteLine("\nTeyin olunmus maas araliginda olan iscilerin siyahisi : ");
                    Employees[i].ShowEmployeeInfo();
                }
            }
        }
    }
}
