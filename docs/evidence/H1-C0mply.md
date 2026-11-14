# H1 working draft for @C0mply

Codex prepared these notes. The participant's decision, review, and verification are pending.

## Contribution

The existing Search handler trims the input, reloads the list for a blank query, and binds the manager's result for a nonblank query. A date query in `ReservationManager` follows that boundary and lets the team test the calendar rule independently of WinForms. Filtering in `ReservationsForm` would keep the change local to the event handler but put the selection rule beside grid updates. [Search handler](https://github.com/FrostyPaw/hotel-management-system/blob/bb53719407724575e6d7e936256a0b268cec13c0/Hotel_Management_System_2/Forms/ReservationsForm.cs#L28) · [Manager](https://github.com/FrostyPaw/hotel-management-system/blob/bb53719407724575e6d7e936256a0b268cec13c0/Hotel_Management_System_2/Services/ReservationManager.cs#L70)

**Your task.** Trace both placements in the actual code. Verify that the proposed result distinguishes a reversed range from a valid range with zero matches, and that the form updates its binding only for successful results. Record your decision and why it fits the current code. [ADR](../architecture/arrival_date_filter.md)

Your decision, rationale, and link to the reviewed ADR section: Pending.

## Review of @Stepigor98's test cases

Check that the reversed-range test first displays a known set of rows. With `8002` displayed, January 13–12 should show the error and retain that row. Check the Reset expectations against the ADR as well. State which case you checked, what you found, and whether you requested a change.

Your finding and disposition: Pending.

## Personal verification

Read reservation `8002` in the fixture and reproduce the date comparison in PowerShell. [Fixture timestamps](H1-baseline.md#seed-and-launch)

```powershell
$arrival = [datetime]'2027-01-12T18:00:00'
$end = [datetime]'2027-01-12'
$arrival -le $end
$arrival.Date -le $end
```

Expected output is `False` then `True`. Explain why the proposed inclusive calendar-date rule includes the evening arrival. This checks the premise behind the H2 contract using a fixture timestamp.

Your actual output, source inspected, and conclusion: Pending.
