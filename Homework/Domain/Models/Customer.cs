using System;
namespace Domain.Models
{
	public class Customer
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public int Age { get; set; }
		public string Position { get; set; }
	}
}