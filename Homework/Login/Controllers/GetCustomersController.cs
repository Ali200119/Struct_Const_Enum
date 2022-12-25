using System;
using Domain.Models;
using Service;
using Service.Interfaces;

namespace Login.Controllers
{
	public class GetCustomersController
	{
		public void Show()
		{
			IGetCustomers getCustomers = new GetCustomers();

            Customer customer1 = new Customer()
            {
                Name = "Ali",
                Surname = "Talibov",
                Age = 21,
                Position = "Software Deveoloper"
            };

            Customer customer2 = new Customer()
            {
                Name = "Patrick",
                Surname = "Kelly",
                Age = 30,
                Position = "System Administrator"
            };

            Customer customer3 = new Customer()
            {
                Name = "Lucy",
                Surname = "Spencer",
                Age = 24,
                Position = "Web Design"
            };

            Customer customer4 = new Customer()
            {
                Name = "Molly",
                Surname = "Albert",
                Age = 27,
                Position = "Marketing"
            };

            Customer[] customers = { customer1, customer2, customer3, customer4 };

            Console.WriteLine($"First method's answer: {getCustomers.FilterByAge(customers)}");

			Console.WriteLine($"Second method's answer: {getCustomers.AverageAge(customers)}");
		}
	}
}

