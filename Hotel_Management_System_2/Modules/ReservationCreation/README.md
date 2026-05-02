# Reservation Creation Module

## Selected Design Pattern
This module uses the Strategy pattern.

## Why Strategy?
The reservation creation feature contains several business validation rules:
- check if the date range is valid
- check if the guest exists
- check if the room exists
- check if the room is available

Instead of placing all validation logic into one large method, each rule is implemented as a separate strategy through the `IReservationRule` interface.

This improves:
- maintainability
- readability
- extensibility
- testability

## Module Interaction
The module receives:
- guest data
- room data
- reservation data
- a reservation request

The module does not directly modify files, UI, or global state. It validates whether a reservation can be created and returns a `ReservationResult`.

Other parts of the system can use this module before saving a reservation to JSON storage.

## AI Prompt Used
Implement the reservation creation logic for a C# Hotel Management System using the Strategy pattern.

The module must:
- validate guest existence
- validate room existence
- validate date range
- validate room availability
- keep each validation rule in a separate class
- avoid side effects
- return a predictable result object
- follow clean OOP principles
- follow the project AGENTS.md instructions
- refer to the /docs folder for project context
