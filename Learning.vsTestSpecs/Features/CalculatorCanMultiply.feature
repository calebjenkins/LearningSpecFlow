Feature: Calculator can multiply
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for multiplying **two** numbers

@msTest
Scenario: Can multiply two numbers
Given the first number is 10
And the second number is 5
When the numbers are multiplied
Then the result should be 50

