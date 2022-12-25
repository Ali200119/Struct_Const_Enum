using System;
using Domain.Models;

namespace Service.Interfaces
{
	public interface IGetCustomers
	{
		int FilterByAge(Customer[] customers);
		double AverageAge(Customer[] customers);
	}
}