using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Learning.xUnitSpecs
{
	public static class ContextExtensions
	{
		public static void Update<T>(this ScenarioContext context, T store) where T: class
		{
			string key = typeof(T).ToString();
			context[key] = store;
		}

		public static T Get<T>(this ScenarioContext context) where T : class
		{
			string key = typeof(T).ToString();
			if (context[key] is not null)
			{
				return (T)context[key];
			}

			return default(T);
		}
	}
}
