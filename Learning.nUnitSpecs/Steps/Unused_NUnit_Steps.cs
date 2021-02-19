using TechTalk.SpecFlow;

namespace Learning.nUnitSpecs.Steps
{
	[Binding]
	public class Unused_NUnit_Steps
	{
		private readonly ScenarioContext _context;
		public Unused_NUnit_Steps(ScenarioContext context)
		{
			_context = context;
		}

		[When("When Steps Aren't Used")]
		public void whenStepsArentUsed()
		{

		}
	}
}
