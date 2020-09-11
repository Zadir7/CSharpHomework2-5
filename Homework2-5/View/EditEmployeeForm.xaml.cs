using Homework2_5.Logic;
using Homework2_5.Models;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Homework2_5
{
    /// <summary>
    /// Логика взаимодействия для EditForm.xaml
    /// </summary>
    public partial class EditEmployeeForm : Window
    {
        public EditEmployeeForm()
        {
            InitializeComponent();
            DepChoose.ItemsSource = Program.departments.Select(d => d.DepartmentName);
        }

        private void CloseForm_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            Status.Text = Program.EmployeeAdd(TBFirstName.Text, TBLastName.Text, DepChoose.SelectedIndex) ? "Successfully Added" : "Fill all the fields and try again";
        }
    }
}
