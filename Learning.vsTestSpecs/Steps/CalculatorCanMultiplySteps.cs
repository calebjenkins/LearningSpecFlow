using Learning.Domain;
using TechTalk.SpecFlow;
using FluentAssertions;
using static Learning.vsTestSpecs.Steps.CalculatorStepDefinitions;

namespace Learning.vsTestSpecs.Steps
{
	[Binding]
	public class CalculatorCanMultiplySteps
	{
		private readonly CalculatorScenarioContext _ctx;
		public CalculatorCanMultiplySteps(CalculatorScenarioContext TestContext)
		{
			_ctx = TestContext;
		}

		[When(@"the numbers are multiplied")]
		public void WhenTheNumbersAreMultiplied()
		{
			var calc = new Calculator();
			_ctx.Result = calc.Multiply(_ctx.First, _ctx.Second);
		}
	}
}
