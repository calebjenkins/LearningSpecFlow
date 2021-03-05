Feature: Web API
	Simple API for Doing Math

@API
Scenario: Make a valid request without being authorized
	Given the user is not validated
	But the request is valid
	When the add method is called
	Then the result should be 401 response: not authorized

@API
Scenario: Make an invalid request
	Given the user is validated
	But the request is invalid
	When the add method is called
	Then the result should be 404 response: not found