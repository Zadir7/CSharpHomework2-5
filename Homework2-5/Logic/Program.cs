using Homework2_5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_5.Logic
{
    static class Program
    {
        static Random r = new Random();
        static public List<Department> departments = new List<Department>();
        static public List<Employee> employees = new List<Employee>();
        static public List<EmployeeDepartment> employeesDisplay = new List<EmployeeDepartment>();
        public static void Init()
        {
            for (int i = 0; i < 5; i++)
            {
                departments.Add(new Department(i, $"Department{i}"));
            }

            for (int i = 0; i < 10; i++)
            {
                employees.Add(new Employee(i, Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), r.Next(0, 5)));
            }
        }
        /// <summary>
        /// Выборка для более удобного отображения
        /// </summary>
        public static void Execute()
        {
            var employeequery = from e in employees
                                join d in departments
                                on e.DepartmentId equals d.Id
                                select new EmployeeDepartment
                                {
                                    EmployeeId = e.Id,
                                    FirstName = e.FirstName,
                                    LastName = e.LastName,
                                    Department = d.DepartmentName
                                };
            employeesDisplay = employeequery.ToList();
        }
        public static bool EmployeeAdd(string fname, string lname, int departmentid)
        {
            if (departmentid != -1 &&
                fname != string.Empty &&
                lname != string.Empty)
            {
                employees.Add(new Employee(employees.Count, fname, lname, departmentid));
                return true;
            }
            return false;
        }
        public static bool DepartmentAdd(string departmentname)
        {
            if (departmentname != string.Empty)
            {
                departments.Add(new Department(departments.Count, departmentname));
                return true;
            }
            return false;
        }
    }
}
