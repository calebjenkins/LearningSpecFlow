Feature: Calculator_Multiply
	Simple calculator for multiplying two numbers

@multiplication
Scenario: Multiply two numbers
	Given the first number is 10
	And the second number is 70
	When the two numbers are multiplyied
	Then the result should be 700

@division
Scenario: Divide with decimals
	Given the first number is 50
	And the second number is 0.5
	When the two numbers are multiplyied
	Then the result should be 25