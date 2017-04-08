Feature: SpringerLinkSearch
	In order to search Springer Link
	As a guest user
	I want to verify different search criteria

@Browser:Chrome
Scenario: Happy path Search all content in Springer Link
	Given I am on Springer Link page
	When I enter searchText into Search
	| searchText |
	| test       |
	| atom       |
	Then the result shows all content

@Browser:Chrome
Scenario: Unhappy path Search all content in Springer Link
	Given I am on Springer Link page
	When I enter searchText into Search
	| searchText |
	| atomtest12345       |
	| atomtest54321       |
	Then the result shows no content

