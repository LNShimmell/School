using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
	abstract class Employee : Person
	{
		public decimal Salary { get;  set; }
		public int EmployeeNum { get; set; }
		public string Jobtitle { get; set; }

		public void SetSalary(decimal NewSalary)
		{
			if (NewSalary <= 0)
			{
				throw new ApplicationException("Salary must be positive.");
			}
			Salary = NewSalary;
		}

		public Employee()
		{

		}
		public Employee(string name, string email, string phone, string jobTitle, decimal salary) 
			: base (name, email, phone, true)
		{
			SetSalary(salary);
			Jobtitle = jobTitle;

		}

	}
}
