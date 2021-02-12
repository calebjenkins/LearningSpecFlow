using Learning.Domain;
using TechTalk.SpecFlow;
using FluentAssertions;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Learning.Specs.Steps
{
	[ExcludeFromCodeCoverage]
	[Binding]
	public sealed class CalculatorStepDefinitions
	{
		internal class TestCtx
		{
			public decimal First { get; set; }
			public decimal Second { get; set; }
			public decimal Result { get; set; }
		}

		// internal Tuple<decimal? first, decimal? second, decimal?> _ctx = new Tuple<decimal?, decimal?, decimal?>(null, null, null);
		// internal Tuple<decimal? first, decimal? second, decimal?> ctx = (decimal? first, decimal? second, decimal? result); 

		// For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

		private readonly ScenarioContext _scenarioContext;
		private TestCtx _ctx = new TestCtx();

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
		public void ThenTheResultShouldBe(int result)
		{
			_ctx.Result.Should().Be(result);
		}
	}
}
