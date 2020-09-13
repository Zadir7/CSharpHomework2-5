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

namespace Homework2_5.View
{
    /// <summary>
    /// Логика взаимодействия для EditDepartmentForm.xaml
    /// </summary>
    public partial class EditDepartmentForm : Window
    {
        public EditDepartmentForm()
        {
            InitializeComponent();
        }
        public EditDepartmentForm(Department dep)
        {
            InitializeComponent();
            DepGrid.DataContext = dep;
        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            Status.Text = Program.DepartmentAdd(TBDepartment.Text) ? "Successfully Added" : "Fill all the fields and try again";
        }

        private void CloseForm_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
