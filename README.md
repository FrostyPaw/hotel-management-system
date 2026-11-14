# Hotel Management System

## Project Idea
A desktop application to manage hotel operations such as guests, rooms, and reservations.

## Problem
Manual hotel management with spreadsheets or paper records can lead to errors, duplicated data, and inefficient workflows.

## Users
- Hotel staff
- Hotel administrators

## Core Features
- Manage guests
- Manage rooms
- Handle reservations
- Store data using JSON
- Display simple statistics

## Goal
To provide a simple and efficient hotel management solution for small hotel operations.

## Run the desktop app

On Windows, use a .NET SDK that can build `net8.0-windows` and install the .NET 8 Windows Desktop Runtime if it is missing. From the repository root in PowerShell, build and launch with a fresh data directory:

```powershell
$project = '.\Hotel_Management_System_2\Hotel_Management_System_2.csproj'
dotnet build $project --nologo
if ($LASTEXITCODE -ne 0) { throw 'Desktop build failed.' }
$app = (Resolve-Path '.\Hotel_Management_System_2\bin\Debug\net8.0-windows\Hotel_Management_System_2.exe').Path
$hotelData = Join-Path ([IO.Path]::GetTempPath()) ('hotel-data-' + [guid]::NewGuid().ToString('N'))
New-Item -ItemType Directory -Path $hotelData | Out-Null
Start-Process -FilePath $app -WorkingDirectory $hotelData
```

The app reads and writes `guests.json` and `reservations.json` relative to its working directory. Follow the [H1 baseline runbook](docs/evidence/H1-baseline.md) to check the app in an isolated directory with sample data.

See the [H1 evidence index](docs/evidence/H1.md) for the proposed arrival-date filter and review status.

## Web Demo
A lightweight web demo of the reservation creation feature is available in the `/web` folder.

The web version demonstrates:
- reservation input form
- validation of guest existence
- validation of room existence
- validation of date range
- validation of room availability

This demo is used for cloud deployment in the final assignment.
