using System;
namespace Service.Interfaces
{
	public interface ICalculate
	{
		int Multiply(params int[] array);
		int SumPow(params int[] array);
	}
}

