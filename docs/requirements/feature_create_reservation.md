# Feature: Create Reservation

## User Story
As a hotel administrator, I want to create a reservation for a guest and a room, so that the hotel can manage bookings in a structured and reliable way.

## Acceptance Criteria

### AC1 - Successful reservation creation
Given a guest exists in the system  
And a room exists in the system  
And the room is available for the selected dates  
When the administrator creates a reservation with valid guest, room, check-in date, and check-out date  
Then the system creates the reservation  
And the reservation is saved in the system

### AC2 - Reject reservation if room is not available
Given a guest exists in the system  
And a room exists in the system  
And the room is already reserved for the selected dates  
When the administrator tries to create a reservation  
Then the system rejects the reservation  
And the system shows an availability error message

### AC3 - Reject invalid date range
Given a guest exists in the system  
And a room exists in the system  
When the administrator creates a reservation where the check-out date is earlier than or equal to the check-in date  
Then the system rejects the reservation  
And the system shows a validation error message
