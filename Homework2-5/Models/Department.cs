using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_5
{
    class Department
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }

        public Department(int id, string department)
        {
            Id = id;
            DepartmentName = department;
        }
    }
}
