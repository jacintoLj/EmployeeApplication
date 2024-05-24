using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EmployeeApplication
{
    internal class PartTimeEmployee:IEmployee
    {
        public string first_name, last_name, department, job_title;
        public double basic_salary;

        public PartTimeEmployee()
        {
        }

        public PartTimeEmployee(string Fname, string Lname, string dept, string job)
        {
            this.first_name = Fname;
            this.last_name = Lname;
            this.department = dept;
            this.job_title = job;
        }
        public string FirstName
        {
            get {
                return this.first_name; 
            } 
            set { 
                this.first_name = value;
            }
        }
        public string LastName
        { 
            get { 
                return this.last_name; 
            } 
            set {  
                this.last_name = value; 
            }
        }  
        public string Department
        {
            get { 
                return this.department;
            }
            set {
                this.department = value;
            }
        }
        public string JobTitle
        {
            get {
                return this.job_title;
            } 
            set {
                this.JobTitle = value;
            }
        }
        public double BasicSalary
        {
            get
            {
                return this.basic_salary;
            }
            set
            {
                this.basic_salary = value;
            }
        }
        public void computeSalary(int hoursWorked, double ratePerHour)
        {
        basic_salary = ratePerHour * hoursWorked; 
        }
        public double getSalary()
        {
            return this.basic_salary;
        }
    }
}
