using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
	class Student : Person
	{
		private static int nextID = 1;
		public bool IsVet { get; set; } = false;
		static int StudentID { get; set; }
		public double GPA { get; set; }

		public Student(string FullName, string Email, string Phone, bool IsEmployee, bool IsVet, double GPA) 
			: base(FullName, Email, Phone, IsEmployee){
			this.IsVet = IsVet; this.GPA = GPA;

		}
	}
}
