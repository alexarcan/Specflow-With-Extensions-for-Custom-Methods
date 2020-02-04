Feature: LoginFeature
	
Scenario: Enter user details in userform
	Given I login into the application
		| UserName | Password |
		| admin    | admin    |
	And I enter the following details
	| Title | Initial | FirstName |
	| Mr.   | A       | Alex      |