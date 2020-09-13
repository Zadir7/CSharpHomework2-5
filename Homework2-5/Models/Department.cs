using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_5
{
    public class Department : INotifyPropertyChanged
    {
        public string departmentname;
        public int Id { get; set; }
        public string DepartmentName {
            get { return departmentname; }
            set
            {
                departmentname = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(DepartmentName)));
            }
        }

        public Department(int id, string department)
        {
            Id = id;
            DepartmentName = department;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
