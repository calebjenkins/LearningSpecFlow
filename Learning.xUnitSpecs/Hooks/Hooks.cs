using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Learning.xUnitSpecs.Hooks
{
	[Binding]
	public sealed class Hooks
	{
		// For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

		private readonly ScenarioInfo _info;
		private readonly ScenarioContext _ctx;
		public Hooks(ScenarioInfo info, ScenarioContext context)
		{
			_info = info ?? throw new ArgumentNullException("No Scenario Info!");
			_ctx = context;
		}

		[BeforeScenario]
		public void BeforeScenario()
		{
			Console.WriteLine($"Before Scenario Info: {_info.Title} ");
			Console.WriteLine($"Before Context: { _ctx.ScenarioExecutionStatus.ToString()}");
			bool zephFound = false;

			foreach (var t in _info?.Tags)
			{
				const string zKey = "ZEPH_";

				if (t.ToUpper().StartsWith(zKey))
				{
					zephFound = true;
					var zId = t.Substring(zKey.Length, t.Length - zKey.Length);
					Console.WriteLine($"Start Zephyr: {zId}");
				}
			}

			if (!zephFound)
			{
				Console.WriteLine($"Report: Scenario {_info.Title} is missing a Zephr Test");
			}
		}

		[AfterScenario]
		public void AfterScenario()
		{
			Console.WriteLine($"After Scenario Info: {_info.Title} ");
			Console.WriteLine($"After Context: { _ctx.ScenarioExecutionStatus.ToString()}");

			foreach (var t in _info?.Tags)
			{
				const string zKey = "ZEPH_";

				if (t.ToUpper().StartsWith(zKey))
				{
					var zId = t.Substring(zKey.Length, t.Length - zKey.Length);
					Console.WriteLine($"Update Zephyr: {zId} with Result: {_ctx.ScenarioExecutionStatus.ToString()} ");
				}
			}
		}
	}
}
