namespace ClassTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte check, age;
            Employee employee;
            Department department = new Department();
            string name, surname, departmentName, ageStr, checkStr, salaryStr;
            int salary, minSalary, maxSalary;

            do
            {
                Console.WriteLine("\n1. Employee elave et\n2. Butun iscilere bax\n3. Maas araligina gore iscileri axtaris et\n0. Proqrami bitir\n");

                do
                {
                    checkStr = Console.ReadLine();

                    if (byte.TryParse(checkStr, out check) == false)
                    {
                        Console.WriteLine("\nDaxil olunan emeliyyat sehvdir. Zehmet olmasa yeniden daxil edin : ");
                    }


                } while (!byte.TryParse(checkStr, out check));


                if (check == 1)
                {
                    do
                    {
                        Console.WriteLine("\nIscinin adini daxil edin : ");
                        name = Console.ReadLine();

                        if (name == string.Empty)
                        {
                            Console.WriteLine("Iscinin adi bos qoyula bilmez!");
                        }

                    } while (name == string.Empty);

                    do
                    {
                        Console.WriteLine("\nIscinin soyadini daxil edin : ");
                        surname = Console.ReadLine();

                        if (surname == string.Empty)
                        {
                            Console.WriteLine("Iscinin soyadi bos qoyula bilmez!");
                        }
                    } while (surname == string.Empty);

                    do
                    {
                        Console.WriteLine("\nIscinin yasini daxil edin : ");
                        ageStr = Console.ReadLine();

                        if (byte.TryParse(ageStr, out age) == false)
                        {
                            Console.WriteLine("\nDaxil olunan yas duzgun deyil. Zehmet olmasa yeniden daxil edin : ");
                        }

                    } while (!byte.TryParse(ageStr, out age));

                    do
                    {

                        Console.WriteLine("\nHansi departamente aid oldugunu qeyd edin : ");
                        departmentName = Console.ReadLine();

                        if (departmentName == string.Empty)
                        {
                            Console.WriteLine("Department bolumu bos qoyula bilmez!");
                        }

                    } while (departmentName == string.Empty);

                    do
                    {
                        Console.WriteLine("\nIscinin emek haqqi meblegini daxil edin : ");
                        salaryStr = Console.ReadLine();

                        if (int.TryParse(salaryStr, out salary) == false)
                        {
                            Console.WriteLine("\nEmek haqqi yalniz reqemlerle ifade oluna biler. Zehmet olmasa yeniden daxil edin : ");
                        }

                    } while (!int.TryParse(salaryStr, out salary));

                    employee = new Employee(name, surname, age, departmentName, salary);
                    department.AddEmployee(employee);
                }

                else if (check == 2)
                {
                    Console.WriteLine("-----------------------------------------");
                    department.ShowAllEmployees();
                    Console.WriteLine("-----------------------------------------");
                }

                else if (check == 3)
                {
                    Console.WriteLine("\nMinumum maas meblegini qeyd edin : ");
                    minSalary = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nMaksimum maas meblegini qeyd edin : ");
                    maxSalary = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("-----------------------------------------");

                    department.GetAllEmployeesBySalary(minSalary, maxSalary);

                }

                else if (check == 0)
                {
                    break;
                }

                else
                {
                    Console.WriteLine("\nEmeliyyat duzgun secilmeyib. Zehmet olmasa duzgun emeliyyati secin :\n");
                }

            } while (true);
        }
    }
}
