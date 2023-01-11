Feature: Auth Token

Scenario: Auth - CreateToken
	Given I create Auth Token using Post request
	Then I verify Auth Token is created
