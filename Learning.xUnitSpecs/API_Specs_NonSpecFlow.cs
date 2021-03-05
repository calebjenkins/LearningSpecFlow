using FluentAssertions;
using Learning.xUnitSpecs.Helpers;
using System.Threading.Tasks;
using Xunit;

namespace Learning.xUnitSpecs
{
	public class API_Specs_NonSpecFlow
	{
		[Fact]
		public async Task Given_An_InvalidUser_Should_Get_a_Auth_Error()
		{
			/*  -- Example of the same validation, in a single test
			 Scenario: Make an valid request - invalid user
				Given the user is not validated
				But the request is a valid url
				When the add method is called
				Then the result should be 401 response: not authorized
			*/

			var req = new HttpRequest()
			{
				URL = Helper.getValidURL(),
				Verb = HttpVerb.Get
			};

			var authToken = Helper.NotAuthorizedToken();
			req.Headers.Add(authToken.Key, authToken.Value);

			var resp = await Helper.FakeSendRequest(req);

			var respCode = resp.ResponseCode;
			var code = (int)respCode;

			code.Should().Be(401);

		}

		[Fact]
		public async Task Given_An_InvalidUrl_Should_Get_a_NotFound_Error()
		{
			/*  -- Example of the same validation, in a single test
			 Scenario: Make an invalid request
				Given the user is valid
				But the request is a invalid url
				When the add method is called
				Then the result should be 404 response: not found
			*/

			var req = new HttpRequest()
			{
				URL = Helper.getInvalidURL(),
				Verb = HttpVerb.Get
			};

			var authToken = Helper.AuthorizedToken();
			req.Headers.Add(authToken.Key, authToken.Value);

			var resp = await Helper.FakeSendRequest(req);

			var respCode = resp.ResponseCode;
			var code = (int)respCode;

			respCode.Should().Be(HttpResponseCode.NotFound);
			code.Should().Be(404);
		}

		[Fact]
		public async Task Given_A_MissingAuthToke_Should_Get_a_NotAuth_Error()
		{
			var req = new HttpRequest()
			{
				URL = Helper.getValidURL(),
				Verb = HttpVerb.Get
			};

			req.Headers.Clear();

			var resp = await Helper.FakeSendRequest(req);

			var respCode = resp.ResponseCode;
			var code = (int)respCode;

			respCode.Should().Be(HttpResponseCode.NotAuthorized);
			code.Should().Be(401);
		}
	}
}
