using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
	abstract class Person
	{
		public string FullName { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public bool IsEmployee { get; set; }

		public Person()
		{

		}
		public Person(string FullName, string Email, string Phone, bool IsEmployee)
		{
			this.FullName = FullName; this.Email = Email; this.Phone = Phone; this.IsEmployee = IsEmployee;

		}


	}
}
