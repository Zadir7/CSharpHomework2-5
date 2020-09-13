using Homework2_5.Logic;
using Homework2_5.Models;
using Homework2_5.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Homework2_5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Program.Init();
            EmployeeList.ItemsSource = Program.employees;
            DepartmentList.ItemsSource = Program.departments;
        }

        private void EmployeeList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
            EditEmployeeForm f = new EditEmployeeForm(EmployeeList.SelectedItem as Employee);
            f.ShowDialog();
        }

        private void DepartmentList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            EditDepartmentForm f = new EditDepartmentForm(DepartmentList.SelectedItem as Department);
            f.ShowDialog();
        }
    }
}
