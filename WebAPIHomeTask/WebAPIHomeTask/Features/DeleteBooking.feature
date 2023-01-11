Feature: Delete Booking

Scenario: Booking - DeleteBooking
	Given I delete Booking using Delete request
	Then I verify Booking is deleted
