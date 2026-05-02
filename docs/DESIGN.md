# UI Design Contract

## Framework Choice
The application uses C# Windows Forms as the UI framework.

## Color Palette
- Primary: #2563EB
- Secondary: #64748B
- Background: #F8FAFC
- Surface: #FFFFFF
- Text: #0F172A
- Error: #DC2626
- Success: #16A34A

## Typography and Spacing
- Use Segoe UI as the default font.
- Main headings: 16px, bold.
- Labels and input text: 10px.
- Use consistent spacing of 12px between form elements.
- Forms should use padding of 16px.

## Component Rules
- Buttons must have clear action labels.
- Primary actions should use the primary color.
- Error messages must be clearly visible.
- Do not place two primary buttons next to each other.
- Forms should be simple and not overloaded.

## AI Instructions
When generating UI code:
- Follow this design contract strictly.
- Do not introduce random colors or generic styles.
- Connect UI actions to the existing backend module.
- Do not bypass the ReservationCreation module.
