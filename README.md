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

## Run the desktop application

Use Windows and the .NET 8 SDK with the Windows Desktop runtime. Open PowerShell at the repository root and run the commands below.

```powershell
dotnet build .\Hotel_Management_System_2\Hotel_Management_System_2.csproj --nologo
if ($LASTEXITCODE -ne 0) { throw 'Desktop build failed.' }
$app = (Resolve-Path '.\Hotel_Management_System_2\bin\Debug\net8.0-windows\Hotel_Management_System_2.exe').Path
$dataDir = Join-Path ([IO.Path]::GetTempPath()) ('hotel-data-' + [guid]::NewGuid().ToString('N'))
New-Item -ItemType Directory -Path $dataDir | Out-Null
Start-Process -FilePath $app -WorkingDirectory $dataDir
```

The app reads and writes `guests.json` and `reservations.json` in its working directory. The commands above start it with an empty data directory. See the [H1 baseline run](docs/evidence/H1-baseline.md) for the exact Part I revision, sample records, and checks.

## Web Demo
A lightweight web demo of the reservation creation feature is available in the `/web` folder.

The web version demonstrates:
- reservation input form
- validation of guest existence
- validation of room existence
- validation of date range
- validation of room availability

This demo is used for cloud deployment in the final assignment.
