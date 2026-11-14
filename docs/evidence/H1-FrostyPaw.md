# H1 working draft for @FrostyPaw

Codex prepared these notes. The participant's decision, review, and verification are pending.

## Contribution

Front-desk staff need a list of arrivals over a selected period so they can prepare rooms. Part I searches by reservation ID, guest ID, or room number. The date filter adds a separate query. With January 10–12 selected, reservation `8002` must appear even though it arrives at 18:00 on January 12. Dates of departure, overlapping stays, combined filters, persistence, and the web demo are outside the scope. [Part I search](https://github.com/FrostyPaw/hotel-management-system/blob/bb53719407724575e6d7e936256a0b268cec13c0/Hotel_Management_System_2/Services/ReservationManager.cs#L70)

**Your task.** Check the proposed treatment of `Cancelled` against your front-desk workflow. The draft keeps those rows visible so staff can see when a room on the arrival list was freed by a cancellation. Confirm this rule or explain which criterion should change. Record the issue link with your finding.

Your decision, rationale, and issue link: Pending.

## Review of @C0mply's architecture

Compare the proposed boundary with the existing Search handler and the manager. Check where input and grid binding happen and where rows are selected. In particular, check that the reversed-range path keeps the grid intact. Cite one source observation and say whether you accept the decision or request a specific change. [Search handler](https://github.com/FrostyPaw/hotel-management-system/blob/bb53719407724575e6d7e936256a0b268cec13c0/Hotel_Management_System_2/Forms/ReservationsForm.cs#L28) · [ADR](../architecture/arrival_date_filter.md)

Your finding and disposition: Pending.

## Personal verification

Launch the pinned baseline. Search for `101`, then click Reset. Expected search IDs are `8001`, `8003`. After Reset the field should be empty and `8001`, `8002`, `8003` should be visible. Explain what this establishes about Part I. [Baseline runbook](H1-baseline.md)

Your environment, actual IDs, query after Reset, and conclusion: Pending.
