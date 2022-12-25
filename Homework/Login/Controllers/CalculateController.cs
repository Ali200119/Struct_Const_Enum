using System;
using Service;
using Service.Interfaces;

namespace Login.Controllers
{
	public class CalculateController
	{
		public void Calculate()
		{
			ICalculate calculate = new Calculate();

			Console.WriteLine($"First method's answer: {calculate.Multiply(1, 2, 3, 19, 30, 23, 10, 0, 43, 7, 8, 9, 10, 50)}");

			Console.WriteLine($"Second method's answer: {calculate.SumPow(2, 3, 4, 5, 6, 7, 8, 12, 7, 28)}");
		}
	}
}

