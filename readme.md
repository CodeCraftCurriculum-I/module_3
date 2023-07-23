We're excited to introduce you to our third project, "Hangman". Building on the skills and concepts you've learned and applied in "Guess My Number" and "Rock, Paper, Scissors," this project introduces a greater focus on providing feedback to the player and refining your debugging skills.

**Variables:** In "Hangman," variables play a crucial role, storing the secret word, the player's guesses, the current state of the word as guessed by the player, and the number of incorrect guesses.

**Conditionals:** Conditionals guide the game flow in "Hangman." They are used to check whether a player's guess is in the secret word, whether the secret word has been fully revealed, or whether the maximum number of incorrect guesses has been reached.

**Collections:** Collections come into play when we manage the player's guesses and form the word that gets revealed progressively to the player. You'll get to explore even more ways of using arrays in this project.

**Loops:** Loops drive the gameplay, allowing the game to continue until the player successfully guesses the word or the maximum number of incorrect guesses has been exceeded.

**Functions:** Functions will be utilized extensively to break down the game into manageable tasks, such as checking the player's guess, updating the current state of the word, and determining the game's end condition.

In addition to these core concepts, "Hangman" provides a great opportunity to enhance the player's experience by providing meaningful feedback. It could be informing the player about the incorrect guess, updating them on their current progress, or celebrating their victory.

Moreover, as your projects become more complex, it's likely that you'll encounter more bugs in your code. That's why, in this project, we're placing a bit more emphasis on debugging skills. Debugging isn't just about fixing errors—it's a process that involves understanding your code deeply, identifying the problem, and then thinking critically to solve it.

Just like with our previous projects, it's important to understand your code thoroughly and strive for quality. Good, clean code can make a significant difference in both your debugging process and the overall performance of the game. Do not be affraide of altering the code you are given. 

Through "Hangman," you'll get to build on what you've learned from the previous projects and add new skills to your programming toolbox. This classic game is more than just a coding project—it's a comprehensive lesson in user interaction, debugging, and of course, the fundamental concepts of programming. Let's bring "Hangman" to life with code!

**Project Requirements**:  
-------------------

Before you write any code, you should "sketch" the pseudo code and make a flowchart for how you plan to do the following alterations to the game.

NB! Some of the requierments might require you to write code not explicitly spelled out in the requierments, use your judgment.

**Module Requirements**:

1. **Refactor the Code**: Refactoring is about improving the design of existing code, without changing its external behavior. For this task, you should focus on optimizing for readability, and demonstrate appropriate use of functions. A well-structured and clean code is easier to understand, maintain, and extend.

2. **Multilingual Support**: Extend your program to support multiple languages. 

3. **Prevent Duplicate Letters**: Modify the game so that it doesn't accept the same letter twice. i.e guessing a previously accepted letter should be counted as a mistake. 

4. **Fix the Graphics Glitch**: There's a glitch in the graphics. Find and fix it. This task exposes you to the debugging process and gives you practice in understanding and correcting issues.

5. **Fix the Off-by-One Error**: There's a latent off-by-one error in the code. Such errors are a common type of logical error in programming. Identify and correct this error.

6. **Fix the Final Drawing Bug**: There's a bug that prevents the final drawing from being displayed. Debug and fix this issue.

7. **Extend the Number of Attempts**: The player's number of attempts to guess the word is limited. Extend this number in a meaningfull way.


**Challenge Requirements (Higher Grades)**:

1. **Add a Hint Option**: Implement a feature that reveals a letter in the word when activated. 

2. **Implement a High Score System**: Track the fewest attempts to guess a word. This exposes you file I/O and adds a competitive element to the game.

3. **File-Based Word List**: At startup, your game should retrieve the list of possible words from the file "words.txt". This gives you practice with file I/O operations and managing external resources.


Throughout this module, you should keep in mind that the ultimate goal is not only to build these features but also to learn from the process. You should aim to understand how different parts of a program interact, how to troubleshoot effectively, and how to write clean, effective code.

Evryone: In your README file write about what you learnt from this module.

All your code and related files should be neatly organized in a Zip file, with the following internal structure

    module_3_Hangman
    ├── Hangman.cs
    ├── HangmanUI.cs
    ├── module_3_hangman.csproj
    ├── module_3_hangman.sln
    ├── *.*
    └── readme.md
    

**About assesment:**
-------------------

Assessment for this project will be based not just on feature completion, but also on your attention to detail, the cleanliness and readability of your code, and the thoughtfulness of your README file reflections. This is your opportunity to demonstrate not just what you've learned, but how you can apply it creatively and effectively in a real programming project.
