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
		private readonly ScenarioExecutionStatus _status;
		public Hooks(ScenarioInfo info)
		{
			_info = info ?? throw new ArgumentNullException("No Scenario Info!");
		}

		[BeforeScenario]
		public void BeforeScenario()
		{
			Console.WriteLine($"Before Scenario Info: {_info.Title} ");
			foreach (var t in _info?.Tags)
			{
				const string zKey = "ZEPH_";

				if (t.ToUpper().StartsWith(zKey))
				{
					var zId = t.Substring(zKey.Length, t.Length - zKey.Length);
					Console.WriteLine($"Start Zephyr: {zId}");
				}
			}
		}

		[AfterScenario]
		public void AfterScenario()
		{
			Console.WriteLine($"After Scenario Info: {_info.Title} ");
			Console.WriteLine($" Status: {status.ToString()}");
			foreach (var t in _info?.Tags)
			{
				const string zKey = "ZEPH_";

				if (t.ToUpper().StartsWith(zKey))
				{
					var zId = t.Substring(zKey.Length, t.Length - zKey.Length);
					Console.WriteLine($"Update Zephyr: {zId}");
				}
			}
		}
	}
}
