using Learning.Domain;
using Learning.xUnitSpecs.Steps.Contexts;
using System;
using TechTalk.SpecFlow;
using FluentAssertions;

namespace Learning.xUnitSpecs.Steps
{
    [Binding]
    public class Calculator_AdditionSteps
    {
		private readonly CalculatorScenarioContext _ctx;
		public Calculator_AdditionSteps(CalculatorScenarioContext context)
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

		[Then(@"the result should be (.*)")]
		public void ThenTheResultShouldBe(decimal number)
		{
			_ctx.Result.Should().Be(number);
		}
	}
}
