@Jquery
Feature: JqueryUIThemePage
	
Scenario: Open-should display the title
	Given I have been take to jquery theme page
	Then the page title should be "ThemeRoller"

Scenario: AutoComplete-input can type text
Given I have been take to jquery theme page
When I input the text "a" into autocomplete input 
Then I should see auto optional items in autocomplete tip panel contains text "a"

