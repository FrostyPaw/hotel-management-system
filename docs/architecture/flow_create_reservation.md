# Flow: Create Reservation

```mermaid
flowchart TD
    A[Start reservation creation] --> B[Enter guest, room, check-in, check-out]
    B --> C{Are input values valid?}
    C -- No --> D[Return validation error]
    C -- Yes --> E{Does guest exist?}
    E -- No --> F[Return guest not found error]
    E -- Yes --> G{Does room exist?}
    G -- No --> H[Return room not found error]
    G -- Yes --> I{Is check-out after check-in?}
    I -- No --> J[Return invalid date range error]
    I -- Yes --> K{Is room available for selected dates?}
    K -- No --> L[Return availability error]
    K -- Yes --> M[Create reservation object]
    M --> N[Return success result]
