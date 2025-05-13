## Initial Planning & Thought Process

When I first got this assignment, I was honestly a mix of excited and a little unsure. It felt like a great opportunity, but I also knew I'd have to be more methodical than usual—this wasn't a small script, it was more of a full project.

My first move wasn’t to start coding right away. Instead, I tried to picture how everything would fit together. I asked myself simple questions like, “What exactly should this program do?” and “What would the major parts look like?” That led me to think in terms of a basic flow: get input → show a menu → do something → show results.

Pretty early on, I realized that keeping everything in one file would get messy fast. I wanted to keep things clean, even if we’re still beginners. So I started thinking about splitting things up: one file to run the main app, one for handling the menu, another for the number logic, and one more for anything related to user input.

I didn’t dive into details yet. I just outlined a rough “blueprint” to guide me. Having that mental structure gave me more clarity when I finally started coding.

---

## File Structure & Modularity

Once I had a plan, I decided to split the project into multiple files. Technically, I could’ve done it all in one, but I really wanted to practice building something closer to how real-world apps are organized—where each part has its job.

Here’s how I divided things:

- **Program.cs** – the starting point; sets everything up and runs the main loop.
- **Menu.cs** – takes care of the user interface, mainly the menu and user choices.
- **InputHelper.cs** – handles all input and validation logic to keep it out of the way.
- **SeriesFunctions.cs** – holds all the number-related operations (sum, average, sorting, etc.).

This approach made everything easier to work with. It was simpler to test parts on their own, and it made the whole thing feel more manageable. When I had to change or rewrite something later, it was a lot less painful because things were already separated.

---

## Logic & Algorithm Decisions

Since the program revolves around a list of numbers, I knew I’d need to cover things like finding the highest and lowest values, averaging, sorting, and so on.

At first, I thought about using built-in methods like `List.Max()` or `List.Average()`. But then I remembered we were supposed to avoid those, so I ended up writing those functions from scratch.

Here’s what I ended up doing:

- Used basic loops to calculate sums and averages manually.
- Found the min and max using simple comparison logic.
- Wrote a basic Bubble Sort for sorting.
- Reversed the list by manually looping through it backwards.

Even though it took longer, doing everything manually helped me understand what was going on behind the scenes. I felt like I was learning more than if I’d just relied on built-ins.

---

## Mistakes, Changes & Improvements

Not everything went right on the first try—no surprise there. But honestly, the mistakes were where I learned the most.

One of the first problems I ran into was input handling. I tried putting the input logic inside the main loop at first, but it quickly got messy. That’s when I decided to move it into its own class (`InputHelper.cs`), and it made a big difference in readability.

Another challenge was the menu system. Originally, I had all the menu logic jammed into the main method, but that got confusing fast. Breaking it out into `Menu.cs` made it cleaner and way easier to work with.

The biggest change I had to make was rewriting code to remove built-in methods. I’d already written stuff using `.Sum()` and `.Max()`, but once I realized we were supposed to do it manually, I went back and rewrote everything. It took more time, but it actually helped me think more like a developer—not just relying on shortcuts.

I also made small mistakes—off-by-one errors in loops, forgetting edge cases, or not realizing how command-line arguments work. But those mistakes forced me to pause, look things up, and actually understand what was going wrong.

---

## Reflection & Summary

Looking back, this project wasn’t just about getting the program to work—it was about learning how to approach a bigger coding task from start to finish.

I learned that planning up front makes a big difference. Taking the time to sketch out the structure saved me from a lot of chaos later. I also got to see how breaking code into modules makes it easier to work with, especially when going back to make changes.

Manually writing the logic gave me a better sense of how things actually work under the hood. It also gave me more confidence—I proved to myself that I can build algorithms from scratch when I need to.

If I were to do this again, I’d probably start even earlier with outlining the structure. Maybe even write more tests or add validation sooner to catch bugs earlier on.

Overall, I’m proud of how it turned out—but even more proud of what I learned along the way.
