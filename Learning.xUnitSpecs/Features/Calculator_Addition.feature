Feature: Calculator Addition
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](Learning.xUnitSpecs/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@xUnit @secondTag
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120

@xUnit
Scenario: Add a negative number
	Given the first number is 20
	And the second number is -5
	When the two numbers are added
	Then the result should be 15

@xUnit @TableDriven
Scenario: Simple Math
	Given the first number is <Num1>
	And the second number is <Num2>
	When the two numbers are added
	Then the result should be <Total>

	Examples:
		| Num1 | Num2 | Total |
		| 2    | 5    | 7     |
		| 20   | 10   | 30    |
		| 30   | -10  | 20    |
