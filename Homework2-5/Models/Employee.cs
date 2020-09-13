using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_5.Models
{
    public class Employee : INotifyPropertyChanged
    {
        string firstname;
        string lastname;
        int departmentid;
        public int Id { get; set; }
        public string FirstName { 
            get { return firstname; }
            set {
                firstname = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(FirstName)));
            }
        }
        public string LastName {
            get { return lastname; }
            set
            {
                lastname = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(LastName)));
            }
        }
        public int DepartmentId {
            get { return departmentid; }
            set
            {
                departmentid = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(DepartmentId)));
            }
        }

        public Employee(int id, string firstname, string lastname, int departmentid)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            DepartmentId = departmentid;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
