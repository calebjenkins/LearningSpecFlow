using TechTalk.SpecFlow;
using FluentAssertions;
using Learning.Domain;
using System.Diagnostics.CodeAnalysis;

namespace Learning.xUnitSpecs.Steps
{
	[Binding]
	[ExcludeFromCodeCoverage]
	public sealed class CalculatorStepDefinitions
	{

		// For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

		private readonly ScenarioContext _scenarioContext;
		private class Context
		{
			public decimal First { get; set; }
			public decimal Second { get; set; }
			public decimal Result { get; set; }
		}

		private Context _ctx = new();


	public CalculatorStepDefinitions(ScenarioContext scenarioContext)
		{
			_scenarioContext = scenarioContext;
		}

		[Given("the first number is (.*)")]
		public void GivenTheFirstNumberIs(decimal number)
		{
			_ctx.First = number;
		}

		[Given("the second number is (.*)")]
		public void GivenTheSecondNumberIs(decimal number)
		{
			_ctx.Second = number;
		}

		[When("the two numbers are added")]
		public void WhenTheTwoNumbersAreAdded()
		{
			var calc = new Calculator();
			_ctx.Result = calc.Add(_ctx.First, _ctx.Second);
		}

		[Then("the result should be (.*)")]
		public void ThenTheResultShouldBe(decimal result)
		{
			_ctx.Result.Should().Be(result);
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
	}
}
