# GammaDream Coding Challenge: Button-Triggered Confetti

# Overview:

## This challenge tests your understanding of Unity Events, triggers, and best practices for writing code.

Within this repo contains:
- A **Player** object with a CharacterController (WASD and joystick/controller input is already implemented).
- A **Button** object with a ButtonPress script attached.
- A Confetti **Particle System** with an ActivateConfetti script attached.

Your task is to implement the intended behavior so that the confetti pops when the button is pressed!

## Requirements:

1. **Event-driven Confetti**
    - Modify the project so that pressing the button triggers the confetti particle system.
    - Use Unity C# events (Actions or UnityEvent) to connect the button to the confetti system.
    - Ensure that the ActivateConfetti script subscribes and unsubscribes to the button event appropriately.
2. **Fix existing bugs**
    - Once implemented, there may be one or two pre-seeded bugs that appear.
    - You must implement fixes and error handling to resolve the bug(s) that will appear.
3. **Clean, maintainable code**
    - Follow C# conventions and best practices for Unity projects.
    - Use clear naming schemes, comments, and organized structure where appropriate.
4. **Version Control (Git and Github)**
    - Clone this repo and create a new branch for your work.
    - Commit frequently with meaningful commit messages.
    - Submit your changes via a Pull Request (PR) from your branch -> Main.

## Deliverables:

- A Unity project with your changes applied to a **separate branch**.
- A PR with your committed code changes.
- Ensure your code compiles and runs as expected -- your branch will be pulled down and tested!

## Notes:

- This challenge is designed to simulate our project's setup and real-world problems you may encounter. This is **not** intended to be a time-consuming take-home assignment, nor a Leetcode question. If it takes you more than a couple of hours, **you're overthinking it**.
- Focus on correcting the event wiring and bug fixing rather than adding new features and polish.