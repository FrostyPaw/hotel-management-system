# Arrival date contract verification

Codex compared the proposed H2 contract with the Part I source and the H1 fixtures on November 14, 2026. The [Windows smoke run](H1-baseline.md#smoke-check) exercises Part I. The PowerShell check below evaluates the proposed date predicate on the same input.

| Area | Comparison and finding | Disposition |
| --- | --- | --- |
| Front desk need | The current query searches three numeric fields. The sample evening arrival shows why a new date query needs a full final day. The current grid already displays `PaymentStatus`. | Keep the query separate from text search. Include all statuses in this arrival list so the status remains visible for cancelled reservations. |
| Architecture | `btnSearch_Click` binds a result from `ReservationManager`. Putting the date rule in the form would tie filtering and error handling to grid updates. | Keep selection and range validation in the manager. The form binds a successful list, including an empty one, and skips binding on validation failure. |
| Test cases | The timestamp comparison drops `8002` on the final day. The calendar comparison includes it in both valid ranges. Repeating January 10–12 preserves order. | Include a single-day test, empty-range test, and a reversed-range test with a row already visible. Compare both file hashes before and after repeated filtering in H2. |
| Runbook | The reservation and guest loaders resolve filenames against the process working directory. With the fixture directory as the working directory, the pinned build showed all three supplied rows. The existing Save handler rejected reversed stay dates and both hashes matched. | Keep the isolated working directory and hash comparison in the reproduction steps. |

[Part I form](https://github.com/FrostyPaw/hotel-management-system/blob/bb53719407724575e6d7e936256a0b268cec13c0/Hotel_Management_System_2/Forms/ReservationsForm.cs#L28) · [Part I manager](https://github.com/FrostyPaw/hotel-management-system/blob/bb53719407724575e6d7e936256a0b268cec13c0/Hotel_Management_System_2/Services/ReservationManager.cs#L70) · [Guest storage](https://github.com/FrostyPaw/hotel-management-system/blob/bb53719407724575e6d7e936256a0b268cec13c0/Hotel_Management_System_2/Services/FileDataStorage.cs#L12)

## Reproduce the date comparison

In the same PowerShell session as the [baseline run](H1-baseline.md), after the application exits:

```powershell
$sample = Get-Content -Raw -LiteralPath $reservationsPath | ConvertFrom-Json
$fixturePaths = $guestsPath, $reservationsPath
$beforeComparison = Get-FileHash -LiteralPath $fixturePaths

function Select-Arrival([datetime]$from, [datetime]$to) {
    if ($from.Date -gt $to.Date) { throw 'From date must be on or before To date.' }
    $sample | Where-Object {
        $arrivalDay = ([datetime]$_.CheckInDate).Date
        $from.Date -le $arrivalDay -and $arrivalDay -le $to.Date
    } | ForEach-Object { $_.ReservationID }
}

$arrival = [datetime]($sample | Where-Object ReservationID -eq 8002).CheckInDate
$end = [datetime]'2027-01-12'
"Against midnight: $($arrival -le $end)"
"Against the calendar date: $($arrival.Date -le $end)"
"Jan 10-12: $((Select-Arrival '2027-01-10' '2027-01-12') -join ', ')"
"Repeated Jan 10-12: $((Select-Arrival '2027-01-10' '2027-01-12') -join ', ')"
$shown = (Select-Arrival '2027-01-12' '2027-01-12') -join ', '
"Jan 12 alone: $shown"
"Jan 14 alone: $(@(Select-Arrival '2027-01-14' '2027-01-14').Count) rows"
try { $shown = (Select-Arrival '2027-01-13' '2027-01-12') -join ', ' }
catch { "Reversed range: $($_.Exception.Message)" }
"Rows retained after invalid range: $shown"
$afterComparison = Get-FileHash -LiteralPath $fixturePaths
"File hash differences: $(@(Compare-Object $beforeComparison $afterComparison -Property Path,Hash).Count)"
```

The script reported `False` against midnight and `True` against the calendar date. January 10–12 returned `8001, 8002` twice in the same order. January 12 returned `8002` and January 14 returned zero rows. The reversed range reported `From date must be on or before To date.` and the sample caller retained `8002`. Both JSON hashes matched. The script exited with code `0`. The H2 grid behavior, persistence effects, and payment-status coverage still need checks in the implemented feature. Team acceptance and independent reproduction are pending.
