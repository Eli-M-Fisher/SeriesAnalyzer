# Code Notes – SeriesAnalyzer


## File Overview

- **Program.cs** – The starting point of the app; it runs the main loop and controls program flow.
- **Menu.cs** – Handles the menu interface and connects user choices to the actual actions.
- **InputHelper.cs** – Deals with user input and validation. Moved here to keep `Program.cs` cleaner.
- **SeriesFunctions.cs** – Where all the core logic lives: calculations, sorting, etc.
- **README.md** – General info about the project, how to run it.
- **Documentation_Process.md** – A more reflective write-up with some thoughts on how the project evolved.
- **Code_Structure_Notes.md** – (this file) Just the technical side of things for quick reference.

---

## Function Overview

main functions:

- `Main()` – Sets everything in motion and loops the menu.
- `DisplayMenu()` – Shows options on screen.
- `HandleMenuChoice()` – Figures out what to do based on user selection.
- `GetInitialSeries()` – Asks the user for numbers (or loads them).
- `GetMenuChoice()` – Validates the user’s choice from the menu.
- `PrintSeries()` – Displays numbers as entered.
- `PrintReversed()` – Shows them in reverse.
- `PrintSorted()` – Bubble sort version (I kept it simple).
- `PrintMax()` – Finds the max manually.
- `PrintMin()` – Finds the min manually.
- `PrintAverage()` – Calculates average manually too.
- `PrintCount()` – Counts how many items are in the list.
- `PrintSum()` – Adds them all up using a loop.

---

## Development Changes (Log)

- Rewrote all SeriesFunctions to avoid using built-ins (per the assignment).
- Pulled input-related stuff out of `Program.cs` and into `InputHelper.cs`.
- Moved menu logic to its own file (`Menu.cs`) to clean up the main program.
- Added a `.gitignore` to keep out `bin/` and `obj/` folders.
- Added inline comments and headers in the `add-comments` branch.
- Started a `dev-notes` branch just to keep track of thoughts and structure decisions.

---

## Notes & To-Dos

- The sort function is just Bubble Sort. Works fine here, but slow for big lists.
- Input assumes only positive numbers. Would be better to validate per item.
- Could add better error handling (e.g., retries if the user enters invalid input).
- Might be worth turning the whole logic into a `SeriesAnalyzer` class eventually, just to group things better.

---

