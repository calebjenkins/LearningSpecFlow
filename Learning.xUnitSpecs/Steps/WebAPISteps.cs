using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using Learning.xUnitSpecs.Steps.Contexts;
using FluentAssertions;
using Learning.xUnitSpecs.Helpers;
using System.Threading.Tasks;
using Xunit;

namespace Learning.xUnitSpecs.Steps
{

	[Binding]
	public class WebAPISteps : TestContext<WebRequestTestContext>
	{
		public WebAPISteps(WebRequestTestContext context) : base(context) { }

		[Given(@"the user is not validated")]
		public void GivenTheUserIsNotValidated()
		{
			var authToken = Helper.NotAuthorizedToken();
			ScenarioContext.Headers.Add(authToken.Key, authToken.Value);
		}

		[Given(@"the user is validated")]
		public void GivenTheUserIsValidated()
		{
			var authToken = Helper.AuthorizedToken();
			ScenarioContext.Headers.Add(authToken.Key, authToken.Value);
		}

		[Given(@"the request is valid")]
		public void GivenTheRequestIsValid()
		{
			ScenarioContext.URL = Helper.getValidURL();
		}

		[Given(@"the request is invalid")]
		public void GivenTheRequestIsInvalid()
		{
			ScenarioContext.URL = Helper.getInvalidURL();
		}

		[When(@"the add method is called")]
		public async Task WhenTheAddMethodIsCalled()
		{
			var req = ScenarioContext.GetRequest();
			var resp = await Helper.FakeSendRequest(req);
			ScenarioContext.Response = resp;
		}

		[Then(@"the result should be (.*) response: (.*)")]
		public void ThenTheResultShouldANotAuthorizedError(int errorCode, string errMsg)
		{
			var respCode = ScenarioContext.Response.ResponseCode;
			var code = (int)respCode;
			var msg = errMsg;

			code.Should().Be(errorCode);
		}
	}
}
