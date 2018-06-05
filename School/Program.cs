using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
	 class Program
	{
		static void Main(string[] args)
		{
			Student student1 = new Student("Larry Shimmell", "LS@email.com", "555-555-1234", false, true, 3.00);
			Student student2 = new Student("Will IAM", "Will@email.com", "111-555-1111", false, true, 3.50);
			Instructor instructor1 = new Instructor("Greg Doud", "GD@email.com", "222-555-1231", "BootCamp Instructor", 90000, "CSHARP", "JAVA");
			//Students is a list of students.
			instructor1.Students.Add(student1);
			instructor1.Students.Add(student2);

			Sales sales1 = new Sales("Mike Sellsalot", "MS@email.com", "555-555-3333", "Sales", 30000, "NorthWest", 250000);
			
			
			sales1.Sold(300000);
			sales1.Sold(350000);
			sales1.Sold(400000);
			sales1.Sold(1000000);
			sales1.CalculateCommision();
			sales1.GetCommision();
			Sales sales2 = new Sales("Jeff SucksatSales", "js.email.com", "222-555-1212", "Sales", 30000, "MidWest", 250000);
			sales2.TotalSalesToDate = 15000m;
			sales2.Sold(2500m);
			sales2.Sold(50000m);
			sales2.Sold(12500m);

			List<Person> people = new List<Person>();
			people.Add(student1);
			people.Add(student2);
			people.Add(instructor1);
			people.Add(sales1);
			people.Add(sales2);

			decimal totalSales = 0;
			void GettotalSales(){
				foreach (Person person in people)
				{
					Sales sales = person as Sales;
					if (sales != null)
					{
						totalSales += sales.TotalSalesToDate;

					}
					
				}
				Console.WriteLine($"Total Sales of all Sales employees: {totalSales}");
			}
			GettotalSales();

		}
	}
}
