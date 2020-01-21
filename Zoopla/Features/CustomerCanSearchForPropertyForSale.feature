Feature: CustomerCanSearchForPropertyForSale
	As a customer
  I want the ability to search for any property of my choice in any location
  so that i can buy the property

  Scenario Outline: Customer can search for any property
  Given I navigate to zoopla homepage
  When I enter a "<Location>" in the search text box
  And I select "<MinPrice>" from minimum price dropdown
  And I select "<MaxPrice>" from maximum price dropdown
  And I select "<Property>" from property type dropdown
  And I select "<Bed>" from Bedrooms dropdown
  And I click on Search button
  Then a list of "<PropertyType>" in "<Location>" are displayed
  And I click on one of the result links

  Examples:
    |Location|MinPrice|MaxPrice|Property|Bed|PropertyType|
    |Manchester|£250,000|£230,000|Houses|3+|Houses       |
     #|London|£120,000|£400,000|Farms/land|No min|Property |
     #|Coventry|£120,000|£230,000|Flats|3+|Flat|
     #|Birmingham|      |        |     |  |      |