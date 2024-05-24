using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApplication
{
    public partial class frmComputeSalary : Form
    {
        public frmComputeSalary()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void buttonComputeSalary_Click(object sender, EventArgs e)
        {
            string firstname = textBoxFirstName.Text;
            string lastname = textBoxLastName.Text;
            string department = textBoxDepartment.Text;
            string jobtitle = textBoxJobTitle.Text;
            double ratePerHours = Convert.ToDouble(textBoxRateperHour.Text);
            int basic_salary = Convert.ToInt32(textBoxTotalHoursWorked.Text);
            PartTimeEmployee partTimeEmployee = new PartTimeEmployee(firstname , lastname , jobtitle , department);
            partTimeEmployee.computeSalary(basic_salary, ratePerHours);

            label10.Text = partTimeEmployee.FirstName;
            label11.Text = partTimeEmployee.LastName;
            label12.Text = partTimeEmployee.getSalary().ToString();
        }
    }
}
