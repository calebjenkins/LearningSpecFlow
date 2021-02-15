using Learning.Domain;
using TechTalk.SpecFlow;
using FluentAssertions;

namespace Learning.vsTestSpecs.Steps
{
	[Binding]
	public sealed class CalculatorStepDefinitions
	{
		public class CalculatorScenarioContext
		{
			public decimal First { get; set; }
			public decimal Second { get; set; }
			public decimal Result { get; set; }
		}
		// For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

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
			Calculator calc = new ();
			_ctx.Result = calc.Add(_ctx.First, _ctx.Second);
		}

		[Then("the result should be (.*)")]
		public void ThenTheResultShouldBe(decimal result)
		{
			_ctx.Result.Should().Be(result);
		}
	}
}
