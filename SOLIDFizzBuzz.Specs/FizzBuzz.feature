﻿Feature: FizzBuzz
	In order to pass an interview
	As a software developer
	I want to show Fizz for factors of 3

	In order to pass an interview
	As a software developer
	I want to show Buzz for factors of 5

	In order to pass an interview
	As a software developer
	I want to show FizzBuzz for factors of 15

Scenario: Factors of 3
	Given I have entered 6 into the numeric up down control
	Then the result should be Fizz on the screen

Scenario: Factors of 5
	Given I have entered 10 into the numeric up down control
	Then the result should be Buzz on the screen

Scenario: Factors of 15
	Given I have entered 30 into the numeric up down control
	Then the result should be FizzBuzz on the screen