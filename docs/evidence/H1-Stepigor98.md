# H1 working draft for @Stepigor98

Codex prepared these cases. The participant's Windows run and review are pending.

## Contribution

Check these proposed H2 cases against the ADR and fixture dates. [Proposed contract](../architecture/arrival_date_filter.md#observable-contract) · [Baseline fixtures](H1-baseline.md#seed-and-launch)

| H2 action | Expected result |
| --- | --- |
| Filter January 10–12, 2027. | `8001`, `8002` in order, including the 18:00 arrival on the 12th. |
| Filter January 12 alone. | Only `8002`. |
| Apply January 13–12 with `8002` displayed. | `From date must be on or before To date.` appears and `8002` stays visible. |
| Filter January 14 alone. | Empty grid. |
| Click Reset after filtering. | Search clears, dates return to their starting values, and `8001`, `8002`, `8003` appear. |
| Capture both JSON hashes, apply January 10–12 twice, and compare displayed IDs and hashes after each application. | Both lists contain `8001`, `8002` in order, and both hashes match their initial values. |

**Your task.** Check the repeated-application case against the [PowerShell comparison](H1-contract-check.md#reproduce-the-date-comparison). Explain how the future UI check would catch a change in row order or an unintended write and identify what still needs testing in H2.

Your check and reasoning: Pending.

## Review of @PavelsSemjonovs's runbook

Start from the repository root and follow the runbook with a fresh directory. Check that its archive, build, and launch steps locate the pinned source and use both fixtures. Report a concrete step you confirmed and any adjustment your setup required. [Baseline runbook](H1-baseline.md)

Your finding and disposition: Pending.

## Personal verification

Build `bb53719` and perform the full Windows smoke check. [Smoke steps](H1-baseline.md#smoke-check)

| Part I check | Expected | Actual from your run |
| --- | --- | --- |
| Open reservations | `8001`, `8002`, `8003` | Pending |
| Search `101` | `8001`, `8003` | Pending |
| Search `9999` | Zero rows | Pending |
| Reset | Search cleared and all three IDs restored | Pending |
| Save `8999` with checkout before check-in | Validation message and only the original three IDs after Cancel | Pending |
| Compare SHA-256 for both files | No differences | Pending |

Your Windows and SDK versions, input dates, exact error, build and app exit codes, and conclusion: Pending.
