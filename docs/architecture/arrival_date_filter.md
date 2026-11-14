# H1 decision on filtering reservations by arrival date

**Status:** Proposed for H2, pending team review.

## Need and current boundary

Front-desk staff need to see which reservations are due to arrive in a selected period so they can prepare rooms. On the [Part I baseline `bb53719`](https://github.com/FrostyPaw/hotel-management-system/commit/bb53719407724575e6d7e936256a0b268cec13c0), the desktop form sends a text query to the manager and binds the result to the grid. The manager searches the loaded JSON records by reservation ID, guest ID or room number. Filtering by arrival date is new. `Reservation.CheckInDate` stores a time as well as a date, so a comparison against midnight at the end of the range could omit arrivals later that day. [Form search handler](https://github.com/FrostyPaw/hotel-management-system/blob/bb53719407724575e6d7e936256a0b268cec13c0/Hotel_Management_System_2/Forms/ReservationsForm.cs#L28) · [Manager search](https://github.com/FrostyPaw/hotel-management-system/blob/bb53719407724575e6d7e936256a0b268cec13c0/Hotel_Management_System_2/Services/ReservationManager.cs#L70) · [Reservation model](https://github.com/FrostyPaw/hotel-management-system/blob/bb53719407724575e6d7e936256a0b268cec13c0/Hotel_Management_System_2/Models/Reservation.cs#L18)

## Decision

Add an arrival-date query to `ReservationManager`, alongside its text query. The manager checks the order of the dates and selects rows from the list it already loads. `ReservationsForm` reads the two dates and displays the rows or the error. This follows the existing search boundary and lets the team check calendar edge cases independently of WinForms.

The form could instead filter the list returned by `GetAllReservations()`. That would keep the change local to the form, but the selection rule would then live beside the event and grid handling. Checking date boundaries in isolation would require extracting the rule from that handler.

## Observable contract

- **Input:** Two local calendar dates, From and To. The manager compares the date portion of `CheckInDate` with both endpoints. Each endpoint includes the whole day.
- **Success:** When From is on or before To, the manager returns a successful result with a list in the order held by the manager. An empty list is a valid result and clears the grid. Equal endpoints select a single day. The query includes every payment status, including `Cancelled`, so staff can see, for example, that a room on the arrival list was freed by a cancellation. The grid already displays the status.
- **Reversed range:** When From is after To, the manager returns a validation failure distinct from a successful empty list. The form displays `From date must be on or before To date.` and skips rebinding the grid, preserving the rows currently shown.
- **Repeated use:** Applying the same dates to the same records returns the same rows in the same order. Applying or rejecting the filter leaves the in-memory records and both JSON files unchanged.
- **Search and Reset:** Search uses the text query alone. Applying a valid date filter replaces the grid contents with the date query result. Reset clears the search text, restores the dates set when the form opened, and reloads all reservations.

With the [H1 baseline fixtures](../evidence/H1-baseline.md), January 10–12, 2027 returns `8001` and `8002`, including `8002` at 18:00 on January 12 and excluding `8003` on January 13. January 12–12 returns only `8002`. January 14–14 returns no rows. These are expected H2 results.

Scope covers the desktop reservation list. Checkout dates, overlapping stays, combined search criteria, storage changes and the web demo are outside this scope.

[Fixture comparison and contract review](../evidence/H1-contract-check.md)
