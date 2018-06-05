using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
	class Sales: Employee
	{
		public decimal TotalSalesToDate { get; set; }
		public string Rregion { get; set; }
		public decimal Qouta { get; set; }
		public decimal Commision { get; set; }
		public static decimal Rate { get; set; } = 0.035M;

		public Sales(string name, string email, string phone, string jobTitle, decimal salary, 
			string Region, decimal Quota ) 
			:base(name, email, phone, jobTitle, salary){
			this.Rregion = Region; this.Qouta = Quota; TotalSalesToDate = 0;

		}
		public Sales()
		{

		}
		public decimal Sold( decimal amount){
			TotalSalesToDate += amount;
			return TotalSalesToDate;
		}
		public decimal CalculateCommision()
		{
			Commision = Math.Round((TotalSalesToDate * Rate),2);
			return Commision;
		}
		public void GetCommision()
		{
			Console.WriteLine($"Sales employee: {FullName} Total Commision: {Commision} ");
		}

	}
}
