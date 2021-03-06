﻿Feature: FizzBuzz
	In order to pass an interview
	As a software developer
	I want to show Fizz for multiples of 3

	In order to pass an interview
	As a software developer
	I want to show Buzz for multiples of 5

	In order to pass an interview
	As a software developer
	I want to show FizzBuzz for multiples of 15

Scenario: Multiples of 3
	Given I have entered 6 into the DividendNumericUpDown control
	Then the result should be Fizz in the MessageLabel control

Scenario: Multiples of 5
	Given I have entered 10 into the DividendNumericUpDown control
	Then the result should be Buzz in the MessageLabel control

Scenario: Multiples of 15
	Given I have entered 30 into the DividendNumericUpDown control
	Then the result should be FizzBuzz in the MessageLabel control