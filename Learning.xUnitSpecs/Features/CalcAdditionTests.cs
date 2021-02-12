using FluentAssertions;
using Learning.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Learning.xUnitSpecs.Features
{
	public class CalcAdditionTests
	{
		[Fact]
		public void Two_Numbers_Should_Add()
		{
			decimal one = 50;
			decimal two = 100;
			decimal expected = 150;

			var calc = new Calculator();
			var result = calc.Add(one, two);

			result.Should().Be(expected);
		}
	}
}
