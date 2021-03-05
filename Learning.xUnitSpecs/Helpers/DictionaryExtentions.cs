using System;
using System.Collections.Generic;
using System.Linq;

namespace Learning.xUnitSpecs.Helpers
{
	public static class DictionaryExtentions
	{
		public static void ForEach(this Dictionary<string, string> dict, Action<KeyValuePair<string, string>> act)
		{
			foreach (var itm in dict)
			{
				act(itm);
			}
		}
	}
}
