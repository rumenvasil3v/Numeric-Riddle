# "Numeric-Riddle" Game
A Simple-Console-Based game called "Numeric-Riddle" which is implemented by C# programming language

<img alt="Guess-a-number pic" src="https://github.com/rumenvasil3v/Numeric-Riddle/assets/133911957/f709d138-7b16-4bf2-bb6d-94833ae57036" width = "400px">

**Numeric Riddle** is a simple guessing game where users needs to guess random number provided by the computer. Users have  **10 tries** to guess the number and if they, they pass that difficulty and passes to the next. This simple game has different difficulties which are based on every guessed number. **For Example:**
 > We need to guess number in range (1 - 100). If we guess the number and our tries haven't burned out we increase the difficulty to (1 - 200), but there is bonus. Our tries are incresead with +5 from 10.

# Project goals
Our main and general project goal is to make fun and simple game which kills bordedom. It is funny and simple and you communicate with your computer.
So we made this simple console game with that purpose.

# Input and Output
Choose number between **1** and **100**, then press **Enter**.

After that the computer will choose random number and you have 10 tries to guess it. If you guess the program gives you chance to continue your journey through the game, **otherwise** the program ends. If you continue ***the difficulty will increase*** and you need to guess number from **1** - **200** and your tries will increase with +5. And until you quit the program will continue increasing difficulties with +100 and your tries will increase +5.

The computer will return you information wheter the number is ***higher or lower***

# Solution
I used simple conditional statements to check if the number is higher or lower and until the player guess it I used simple loop. The Conole game is written on ***C#*** programming language. Also is writtent on .NET 3.1 Framework with additional libraries ***System.Xml.Serialization.***

# Source code
[Source code](Numeric-Riddle.cs)

# Screenshots
<img alt = "Screenshots of numeric-riddle game" src = "https://github.com/rumenvasil3v/Numeric-Riddle/assets/133911957/e70ec307-134d-40f3-9034-3232674eeda2" width = "700px">

<img src = "https://github.com/rumenvasil3v/Numeric-Riddle/assets/133911957/da0fb1fe-5d1c-423b-94ab-5ff59db88795" alt = "Screenshots of numeric-riddle game" width = "700px">

<img src = "https://github.com/rumenvasil3v/Numeric-Riddle/assets/133911957/57d702d8-ca79-4fe1-b29b-f0a55a83a8d1" alt = "Screenshots of numeric-riddle game" width = "700px">

<img src = "https://github.com/rumenvasil3v/Numeric-Riddle/assets/133911957/ff6b1e27-a0b1-41bb-935e-8ffbcbe1cdb9" alt = "Screenshots of numeric-riddle game" width = "700px">

# Live Demo
You can play the game directly in your browser from here:
[Link To Game](https://replit.com/@rumenvasil3v/Numeric-Riddle#Main.cs)
