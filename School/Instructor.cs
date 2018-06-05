using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
	class Instructor: Employee{

		public List<string> Subjects { get; set; } = new List<string>();
		public List<Student> Students { get; set; } = new List<Student>();
		
	
		public Instructor()
		{

		}
		public Instructor(string name, string email, string phone, string jobTitle, decimal salary, string Subjects, string subject) 
			: base (name, email, phone, jobTitle, salary){
			this.Subjects.Add(Subjects);
			this.Subjects.Add(subject);
		}
		public Instructor(string name, string email, string phone, string jobTitle, decimal salary, string Subjects)
			: base(name, email, phone, jobTitle, salary)
		{
			this.Subjects.Add(Subjects);
			
		}
		


	}
}
