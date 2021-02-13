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
	Given the first number is 100
	And the second number is 2
	When the two numbers are divided
	Then the result should be 50
#
#	Examples:
#		| Num1 | Num2 | Equals |
#		| 20   | 2    |10|
#		| 50   | 10   |5|
#	