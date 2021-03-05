using System.Collections.Generic;
using System.Threading.Tasks;

namespace Learning.xUnitSpecs.Helpers
{
	public static class Helper
	{
		public static string getValidURL()
		{
			return "valid-url";
		}

		public static string getInvalidURL()
		{
			return "invalid-url";
		}

		public static KeyValuePair<string, string> AuthorizedToken()
		{
			return new KeyValuePair<string, string>("token", "valid");
		}

		public static KeyValuePair<string, string> NotAuthorizedToken()
		{
			return new KeyValuePair<string, string>("token", "invalid");
		}

		// Some of this code is pretty fugly.. but it's for pure demo purposes. 
		public static async Task<HttpResponse> FakeSendRequest(HttpRequest request)
		{
			var resp = new HttpResponse() { Body = request.Body, URL = request.URL, ResponseCode = HttpResponseCode.OK};
			request.Headers.ForEach(h => resp.Headers.Add(h.Key, h.Value));

			if (request.URL.Contains("invalid"))
				resp.ResponseCode = HttpResponseCode.NotFound;

			bool authFound = false;
			request.Headers.ForEach(h =>
			{
				if (h.Value.Contains("invalid"))
				{
					resp.ResponseCode = HttpResponseCode.NotAuthorized;
				}
				if (h.Value.Contains("valid"))
					authFound = true;
			});

			if(!authFound)
				resp.ResponseCode = HttpResponseCode.NotAuthorized;

			return resp;
		}
	}
}
