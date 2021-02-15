Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](Learning.vsTestSpecs/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@msTest
Scenario: Add two numbers
	Given the first number is <Num1>
	And the second number is <Num2>
	When the two numbers are added
	Then the result should be <Result>

	Examples:
	| Num1 | Num2 | Result |
	| 10   | 20   | 30     |
	| 50   | -20  | 30     |
	| 5    | 5    | 10     |
	| 2    | 3    | 5      |
	| .5   | 2.5  | 3      |

@msTest
Scenario: Adding negative numbers
Given the first number is 100
And the second number is -75
When the two numbers are added
Then the result should be 25