Feature: Education

As a Mars Portal User,
I want to add, delete and Edit Education feature.
So that the people seeking for the Educations can look at what details I hold.

@deleteEducation
Scenario: 1. Delete existing Educations
	Given Education Tab is selected in Profile Page/
	When I click on Cross icon buttons
	Then Existing Educations deleted successfully


@addEducation
Scenario Outline: 2. Add new Educations with valid input
	Given Education Tab is selected in Profile Page/
	When I click on Add New buttons
	When I give valid input <'University'>,<'country'>,<'title'>,<'Degree'>,<'year'> of Education
	Then  Education should be added

	Scenario Outline: 3.Add new Education with invalid input with space
	Given Education Tab is selected in Profile Page/
	When I click on Add New buttons for invalid input
	When I give invalid input <'University'>,<'country'>,<'title'>,<'Degree'>,<'year'> of Education
	Then  Education should not be added


	Scenario Outline: 3.Add new Education with very long  input 
	Given Education Tab is selected in Profile Page/
	When I click on Add New buttons for long input
	When I give long input <'University'>,<'country'>,<'title'>,<'Degree'>,<'year'> of Education
	Then  Education shouldn't add

@updateEducation
Scenario Outline: 4.Update Education 
	Given Education Tab is selected in Profile Page/
	And one education is added
	When I click on update buttons 
	When I give new input <'University'>,<'Degree'> of Education to update
	Then  Education should be updated
