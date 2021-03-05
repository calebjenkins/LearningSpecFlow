using System;
using System.Linq;

namespace Learning.xUnitSpecs.Steps.Contexts
{
	public class TestContext<T> where T : class
	{
		public TestContext(T context)
		{
			ScenarioContext = context;
		}

		internal T ScenarioContext { get; set; }
	}
}
