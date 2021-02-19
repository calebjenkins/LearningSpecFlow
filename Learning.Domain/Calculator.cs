using System;

namespace Learning.Domain
{
	public class Calculator
	{
		public decimal Add(decimal Num1, decimal Num2)
		{
			return Num1 + Num2;
		}

		public decimal Multiply(decimal Num1, decimal Num2)
		{
			return Num1 * Num2;
		}

		public decimal Divided(decimal Num1, decimal Num2)
		{
			return Num1 / Num2;
		}

		public decimal Modulus (decimal Num1, decimal Num2)
		{
			var result = Num1 % Num2;
			return result;
		}
	}
}
