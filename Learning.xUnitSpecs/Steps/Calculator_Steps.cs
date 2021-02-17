using Learning.Domain;
using Learning.xUnitSpecs.Steps.Contexts;
using System;
using TechTalk.SpecFlow;
using FluentAssertions;
using System.Diagnostics.CodeAnalysis;

namespace Learning.xUnitSpecs.Steps
{
	[ExcludeFromCodeCoverage]
	[Binding]
    public class Calculator_Steps
    {
		private readonly CalculatorScenarioContext _ctx;

		public Calculator_Steps(CalculatorScenarioContext context)
		{
			_ctx = context ?? throw new ArgumentNullException("context cannot be null");
		}

		[Given(@"the first number is (.*)")]
		public void GivenTheFirstNumberIs(decimal number)
		{
			_ctx.First = number;
		}

		[Given(@"the second number is (.*)")]
		public void GivenTheSecondNumberIs(decimal number)
		{
			_ctx.Second = number;
		}

		[When(@"the two numbers are added")]
		public void WhenTheTwoNumbersAreAdded()
		{
			var calc = new Calculator();
			_ctx.Result = calc.Add(_ctx.First, _ctx.Second);
		}

		[When(@"the two numbers are multiplyied")]
		public void WhenTheTwoNumbersAreMultiplyied()
		{
			var calc = new Calculator();
			_ctx.Result = calc.Multiply(_ctx.First, _ctx.Second);
		}

		[When(@"the two numbers are divided")]
		public void WhenTheTwoNumbersAreDivided()
		{
			var calc = new Calculator();
			_ctx.Result = calc.Divided(_ctx.First, _ctx.Second);
		}

		[Then(@"the result should be (.*)")]
		public void ThenTheResultShouldBe(decimal number)
		{
			_ctx.Result.Should().Be(number);
		}
	}
}
