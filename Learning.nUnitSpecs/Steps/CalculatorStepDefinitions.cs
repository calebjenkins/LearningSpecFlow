using Learning.Domain;
using TechTalk.SpecFlow;
using FluentAssertions;

namespace Learning.nUnitSpecs.Steps
{

	[Binding]
	public sealed class CalculatorStepDefinitions
	{
		private readonly CalculatorScenarioContext _ctx;
		private readonly ScenarioContext _scenarioContext;

		public CalculatorStepDefinitions(CalculatorScenarioContext calcScenarioContext, ScenarioContext ScenarioContext)
		{
			_ctx = calcScenarioContext;
			_scenarioContext = ScenarioContext;
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

		[Then("the unused result should be (.*)")]
		[Then(@"the total will be (.*)")]
		public void ThenTheUnusedResultShouldBe(decimal result)
		{
			_ctx.Result.Should().Be(result);
		}

		[Then("some unused Step that isn't showing up")]
		public void SomeUnusedStepThatIsntShowingUp()
		{
			_scenarioContext.Pending();
		}
	}
}
