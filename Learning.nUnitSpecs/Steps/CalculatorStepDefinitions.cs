using Learning.Domain;
using TechTalk.SpecFlow;
using FluentAssertions;

namespace Learning.nUnitSpecs.Steps
{

	[Binding]
	public sealed class CalculatorStepDefinitions
	{
		private readonly CalculatorScenarioContext _ctx;

		public CalculatorStepDefinitions(CalculatorScenarioContext scenarioContext)
		{
			_ctx = scenarioContext;
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
	}
}
