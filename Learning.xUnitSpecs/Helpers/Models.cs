using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.xUnitSpecs.Helpers
{
	public enum HttpVerb
	{
		Get,
		Post,
		Delete,
		Patch,
		FormPost
	}

	public enum HttpResponseCode : int
	{
		OK = 200,
		Moved = 301,
		NotAuthorized = 401,
		NotFound = 404,
		ServerError = 500
	}

	public class HttpRequest
	{
		public Dictionary<string, string> Headers { get; init; } = new Dictionary<string, string>();
		public string Body { get; set; }
		public HttpVerb Verb { get; set; }
		public string URL { get; set; }
	}

	public class HttpResponse
	{
		public Dictionary<string, string> Headers { get; init; } = new Dictionary<string, string>();
		public string Body { get; set; }
		public HttpResponseCode ResponseCode { get; set; }
		public string URL { get; set; }
	}
}
