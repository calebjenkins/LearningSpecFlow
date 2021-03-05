using Learning.xUnitSpecs.Helpers;
using System.Collections.Generic;
using System.Text;

namespace Learning.xUnitSpecs.Steps.Contexts
{
	public class WebRequestTestContext
	{
		public Dictionary<string, string> Headers { get; init; } = new Dictionary<string, string>();
		public StringBuilder Body { get; init; } = new StringBuilder();

		public HttpVerb Verb { get; set; } = HttpVerb.Get;
		public string URL { get; set; }

		public HttpRequest GetRequest()
		{
			var req = new HttpRequest();
			req.Body = Body.ToString();
			Headers.ForEach(h => req.Headers.Add(h.Key, h.Value));
			req.Verb = Verb;
			req.URL = URL;

			return req;
		}

		public HttpResponse Response { get; set; }
	}
}
