Feature: GeneralDonation
	
@mytag
Scenario: Verify the Transaction code is successfully displayed after General Donation.
	Given Selecting General Donate Section
	And I have entered all the mandatory fileds into the General Donation scenario
	When I successfully saved all the pages and clicked on Proces payment
	Then the Transaction code is displayed successfully