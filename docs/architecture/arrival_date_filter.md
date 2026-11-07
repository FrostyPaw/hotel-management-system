# H1 architecture decision - filter reservations by arrival date

Proposed for H2. Team review pending.

## Need and existing boundary

Hotel staff need to see which reservations are due to arrive during a selected period. On [Part I baseline `bb53719`](https://github.com/FrostyPaw/hotel-management-system/commit/bb53719407724575e6d7e936256a0b268cec13c0), `ReservationsForm` reads the text query, calls `ReservationManager.SearchReservations`, and binds the returned rows to the grid. The manager holds the reservations loaded from JSON and searches by reservation ID, guest ID, or room number. `Reservation.CheckInDate` is a `DateTime`, so it can include a time of day.

## Decision

Put the date-range query in `ReservationManager`, alongside the existing text search. The manager owns date comparison and row selection. `ReservationsForm` owns date entry, result binding, reset, and error display. Both queries can use the reservations already loaded by the manager. The date query can be checked with a small set of records and without opening a form.

Filtering in `ReservationsForm` is viable because the form can already read the full list. That keeps the change in one file, but puts the date rule inside the event handler that also updates the grid. Testing the boundary case would then require exercising the form or moving the rule into a separately callable method.

## Observable contract

- The user selects two local calendar dates. The query compares `CheckInDate.Date` with both dates, including the endpoints.
- A valid range returns every matching reservation in its current list order, regardless of payment status. Equal endpoints select one day. An empty match yields an empty grid.
- The manager rejects a reversed range before querying. The form displays `From date must be on or before To date.` and retains the last displayed rows.
- The same dates and reservation data yield the same rows. Filtering leaves in-memory records and both JSON files unchanged.
- Applying the date filter replaces the current grid results. Clicking Search applies only the text query. Reset clears the text, returns the date selectors to their initial values, and reloads the full list.

With the [baseline fixtures](../evidence/H1-baseline.md), selecting January 10–12, 2027 should show `8001` and `8002`. Reservation `8002` arrives at 18:00 on January 12 and must be included. Reservation `8003` arrives on January 13 and must be excluded. This is an H2 acceptance example.

H2 scope covers the desktop reservation list. Checkout dates, overlapping stays, combined search criteria, storage changes, and the web demo are out of scope.
