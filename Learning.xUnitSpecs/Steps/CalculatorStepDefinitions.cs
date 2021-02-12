using TechTalk.SpecFlow;
using FluentAssertions;
using Xunit;
using Learning.Domain;

namespace Learning.xUnitSpecs.Steps
{
	[Binding]
	public sealed class CalculatorStepDefinitions
	{

		// For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

		private readonly ScenarioContext _scenarioContext;
		internal class Context
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
	}
}
