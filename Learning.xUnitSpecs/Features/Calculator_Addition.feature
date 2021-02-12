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

@xUnit
Scenario: Simple Math
	Given the first number is 2
	And the second number is 2
	When the two numbers are added
	Then the result should be 4