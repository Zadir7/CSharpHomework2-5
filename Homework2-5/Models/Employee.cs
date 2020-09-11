using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_5.Models
{
    class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DepartmentId { get; set; }

        public Employee(int id, string firstname, string lastname, int departmentid)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            DepartmentId = departmentid;
        }
    }
}
