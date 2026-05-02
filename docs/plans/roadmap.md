# Project Roadmap (MVP)

## Phase 1: Core Setup

* Create project structure
* Implement basic models (Guest, Room, Reservation)
* Setup JSON storage

## Phase 2: Core Functionality

* Add guest management (CRUD)
* Add room management
* Implement reservation logic

## Phase 3: User Interface

* Build basic UI forms
* Connect UI with backend logic

## Phase 4: Testing & Improvements

* Fix bugs
* Improve validation
* Add basic testing

## MVP Scope

The MVP includes:

* Managing guests, rooms, and reservations
* Basic UI interaction
* Data persistence using JSON

## Future Improvements

* Database integration
* Advanced statistics
* Improved UI/UX
* Multi-user support

## Assignment 4 Update - Complete

The reservation creation feature was implemented as a dedicated module using the Strategy pattern.

### Completed
- Created ReservationCreation module
- Added separate validation strategies
- Added module README documentation
- Updated architecture diagram

### Scope Adjustments
The actual saving of reservations to JSON remains outside this module.
This module focuses only on business validation logic to keep it clean, modular, and easier to test.
