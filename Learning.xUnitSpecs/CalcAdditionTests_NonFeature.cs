using FluentAssertions;
using Learning.Domain;
using Learning.xUnitSpecs.Helpers;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using Xunit;

namespace Learning.xUnitSpecs
{
	public class CalcAdditionTests_NonFeature
	{
		[Fact]
		[Trait("Runner", "xUnit")]
		[ExcludeFromCodeCoverage]
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
