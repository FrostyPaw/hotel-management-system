# H1 baseline run — desktop reservations

[Part I revision `bb53719407724575e6d7e936256a0b268cec13c0`](https://github.com/FrostyPaw/hotel-management-system/commit/bb53719407724575e6d7e936256a0b268cec13c0). This run checks the inherited list, text search, and an existing validation error.

## Build the pinned revision

Run from the repository root in PowerShell 7 on Windows. Use an SDK that can build `net8.0-windows` and the .NET 8 Windows Desktop runtime.

```powershell
$baseline = 'bb53719407724575e6d7e936256a0b268cec13c0'
$lab = Join-Path ([IO.Path]::GetTempPath()) ('hotel-h1-' + [guid]::NewGuid().ToString('N'))
$archive = Join-Path $lab 'source.zip'
$source = Join-Path $lab 'source'
$build = Join-Path $lab 'run'
$data = Join-Path $lab 'data'
New-Item -ItemType Directory -Path $data -Force | Out-Null
git archive --format=zip "--output=$archive" $baseline
if ($LASTEXITCODE -ne 0) { throw 'Could not archive the baseline revision.' }
Expand-Archive -LiteralPath $archive -DestinationPath $source
dotnet --version
dotnet --list-runtimes
dotnet build (Join-Path $source 'Hotel_Management_System_2\Hotel_Management_System_2.csproj') --no-incremental --nologo --output $build
$buildExit = $LASTEXITCODE
"Build exit code: $buildExit"
if ($buildExit -ne 0) { throw 'Baseline build failed.' }
```

## Seed and launch

The guest and reservations below are synthetic. The working directory gives this run its own JSON files.

```powershell
$guestsPath = Join-Path $data 'guests.json'
$reservationsPath = Join-Path $data 'reservations.json'
@'
[
  {
    "GuestID": 701,
    "FirstName": "Sample",
    "LastName": "Guest",
    "CheckInDate": "2027-01-10T09:00:00",
    "CheckOutDate": "2027-01-11T10:00:00",
    "RoomNumber": 101
  }
]
'@ | Set-Content -LiteralPath $guestsPath -Encoding utf8NoBOM
@'
[
  {
    "ReservationID": 8001,
    "GuestID": 701,
    "RoomNumber": 101,
    "CheckInDate": "2027-01-10T09:00:00",
    "CheckOutDate": "2027-01-11T10:00:00",
    "PaymentStatus": 0
  },
  {
    "ReservationID": 8002,
    "GuestID": 701,
    "RoomNumber": 102,
    "CheckInDate": "2027-01-12T18:00:00",
    "CheckOutDate": "2027-01-13T10:00:00",
    "PaymentStatus": 0
  },
  {
    "ReservationID": 8003,
    "GuestID": 701,
    "RoomNumber": 101,
    "CheckInDate": "2027-01-13T09:00:00",
    "CheckOutDate": "2027-01-14T10:00:00",
    "PaymentStatus": 0
  }
]
'@ | Set-Content -LiteralPath $reservationsPath -Encoding utf8NoBOM
$before = Get-FileHash -LiteralPath $guestsPath,$reservationsPath
$app = Start-Process -FilePath (Join-Path $build 'Hotel_Management_System_2.exe') -WorkingDirectory $data -PassThru
```

## Expected and observed

Codex ran the build and operated the desktop app on November 7, 2026, on Windows (build 26300) with PowerShell 7.6.9, SDK 9.0.300, and the .NET 8 Windows Desktop runtime installed. The Git archive, build, and launcher commands completed with exit code `0`. The build reported 13 warnings and 0 errors. The app window opened and closed normally. The app process's own exit code was unavailable in this run.

| Check | Input and steps | Expected | Observed |
| --- | --- | --- | --- |
| Open list | Click **Manage Reservations**. | IDs `8001`, `8002`, and `8003` appear. | All three IDs appeared. |
| Text search | Enter `101` and click **Search**. | Only `8001` and `8003` appear. | Exactly those two IDs appeared. |
| No matches | Enter `9999` and click **Search**. | The grid has no rows. | Zero rows. |
| Reset | Click **Reset**. | The query clears and all three rows return. | The query cleared and all three IDs returned. |
| Reversed stay dates | Click **Add Reservation**. Enter ID `8999`, select guest `701` (displayed as **Guest**), room `101`, and **Pending**. Set check-in to November 7, 2026 and check-out to November 6, 2026. Click **Save**. Dismiss the message and click **Cancel**. | The form displays `Check-out date cannot be earlier than check-in date.` and the grid and files keep the three original reservations. | The exact message appeared. After cancellation the grid still showed only the three original IDs. Both JSON hashes matched their pre-run values. |

After closing the app, compare the hashes in the same PowerShell session:

```powershell
$app.WaitForExit()
"Application exit code: $($app.ExitCode)"
$after = Get-FileHash -LiteralPath $guestsPath,$reservationsPath
Compare-Object $before $after -Property Path,Hash
```

An empty comparison means both files kept the same bytes. The recorded reservation file hash was `6B842B763CD93D400950BD19467852983957FF8B6BA60E4D18994EE059E8426D` before and after. Compare each reproduction against its own starting hashes.

The run covers the observed inherited behavior on these inputs. The arrival-date filter remains an H2 proposal. Independent human reproduction is pending in the [H1 evidence index](H1.md).
