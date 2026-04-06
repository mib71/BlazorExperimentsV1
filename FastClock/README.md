# FastClock

A fast clock for railway modelling operations. Runs in the browser — no installation required.

## Features

- Clock speeds: 1:1, 2:1, 3:1, 4:1, 6:1, 12:1 and 24:1
- Set a custom start time
- Toggle seconds display
- Follows your system light/dark theme
- F11 to toggle full screen in Chrome

## Technical notes

The clock loop uses a `Stopwatch`-based drift compensation. This keeps the fast time accurate over long sessions, especially at higher speeds like 12:1 and 24:1.