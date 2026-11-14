# H1 working draft for @PavelsSemjonovs

Codex prepared these notes. The participant's decision, review, and verification are pending.

## Contribution

The reservation and guest loaders open JSON files through relative paths. The runbook archives and builds the pinned revision, then launches the executable with `-WorkingDirectory $data` so the app uses the synthetic records. Keeping the launch terminal open lets the operator capture the exit code of that process and compare both hashes. [Reservation loader](https://github.com/FrostyPaw/hotel-management-system/blob/bb53719407724575e6d7e936256a0b268cec13c0/Hotel_Management_System_2/Services/ReservationManager.cs#L10) · [Guest loader](https://github.com/FrostyPaw/hotel-management-system/blob/bb53719407724575e6d7e936256a0b268cec13c0/Hotel_Management_System_2/Services/FileDataStorage.cs#L12)

**Your task.** Verify that the instructions launch with exactly the three fixture IDs. Explain what would happen with the wrong working directory. Decide whether the working-directory explanation or prerequisites in the runbook need an adjustment, and document your reasoning or fix. [README launch](../../README.md#run-the-desktop-app) · [Baseline runbook](H1-baseline.md)

Your observation, decision, and link to the relevant runbook section: Pending.

## Review of @FrostyPaw's issue

Check whether the issue states who needs the filter, why reservation `8002` counts on the last day, and where the scope ends. Report a specific criterion you verified or request a precise edit. [Proposed contract](../architecture/arrival_date_filter.md#observable-contract)

Your finding and disposition: Pending.

## Personal verification

Follow the invalid stay dates step for `8999`. The expected result is `Check-out date cannot be earlier than check-in date.`, the three original rows after Cancel, and no differences in either JSON hash after the app closes. Inspect where the save handler returns and explain what the validation and file comparison establish. [Save handler](https://github.com/FrostyPaw/hotel-management-system/blob/bb53719407724575e6d7e936256a0b268cec13c0/Hotel_Management_System_2/Forms/AddReservationForm.cs#L58) · [Smoke steps](H1-baseline.md#smoke-check)

Your environment, inputs, actual message, IDs, exit codes, hash comparison, and conclusion: Pending.
