# Improved Mastermind Game

This is a GUI implementation of the game Mastermind, with some enhancements and improvements, such as rewriting the code in a more MVC manner. The game allows the player to guess a secret code within a limited number of attempts.

# Files

## Board.cs

This file contains a class named `Board` that represents the game board form. It displays the game elements, such as the secret code, player guesses, and feedback. The class handles user inputs for making guesses and communicates with the `GameController` to update the game state and display the appropriate information. It also includes methods for displaying messages, such as win or lose conditions, and allows the player to play again or quit the game.

Feel free to modify and enhance the code as needed for your project. These files contain the core components of the Mastermind game, including the game logic, user interface, and controller.

## MastermindGame.cs

This file contains a class named `MastermindGame` that represents the core logic of the Mastermind game. It includes methods for generating a secret code, processing player guesses, and providing feedback on the correctness of the guesses. The game supports various difficulty levels, including different code lengths and the number of guesses allowed. The class also keeps track of the current game state, such as the number of remaining guesses and whether the game has been won or lost.

## GameController.cs

This file contains a class named `GameController` that acts as the controller for the Mastermind game. It handles the interaction between the user interface and the game logic. The class initializes the game, handles user inputs, and updates the user interface based on the game state. It communicates with the `MastermindGame` class to perform game-related operations.

## CircleButtons.cs

This file contains a class named `CircleButtons` that inherits the functionality of a regular button but allows it to be an ellipse. The `OnPaint` method is overridden to create an ellipse shape for the button.

## DifficultyMenu.cs

This file contains a class named `DifficultyMenu` that represents a form for selecting the game difficulty. It has combo boxes for choosing the secret code length and the number of guesses. The `playButton_Click` event handler hides the difficulty menu and creates an instance of the Board form to start the game. The `secretCodeComboBox_SelectedIndexChanged` and `guessComboBox_SelectedIndexChanged` event handlers update the values of `codeLength` and `guessNumber` variables based on the selected values in the combo boxes. The `quitButton_Click` event handler exits the application.

## HelpMenu.cs

This file contains a class named `HelpMenu` that represents a form displaying help information. It has a "Back" button that returns to the main menu when clicked.

## InheritedHelpMenu.cs

This file contains a class named `InheritedHelpMenu` that inherits from the `HelpMenu` class. It overrides the `Back` method and modifies the appearance of the "Back" button. The `backMainMenuButtonClick` event handler calls the overridden `Back` method to hide the inherited help menu.

## MainMenu.cs

This file contains a class named `MainMenu` that represents the main menu form. It has buttons for starting the game, accessing the help menu, and quitting the application. The `startButton_Click` event handler creates an instance of the `DifficultyMenu` form to select the game difficulty. The `helpButton_Click` event handler creates an instance of the `HelpMenu` form to display help information. The `quitButton_Click` event handler exits the application.

## LoseScreen.cs

This file contains a class named `LoseScreen` that represents a form displayed when the player loses the game. It has buttons for playing again and quitting the application. The `playAgainButton_Click` event handler creates an instance of the `MainMenu` form to return to the main menu. The `quitButton_Click` event handler exits the application.

## WinScreen.cs

This file contains a class named `WinScreen` that represents a form displayed when the player wins the game. It has buttons for playing again and quitting the application. The `playAgainButton_Click` event handler creates an instance of the `MainMenu` form to return to the main menu. The `quitButton_Click` event handler exits the application.

Feel free to modify and enhance the code as needed for your project. These files contain the various components of the Mastermind game, including buttons, menus, screens, and their corresponding event handlers.

# Prerequisites

Before getting started, make sure you have the following prerequisites installed on your system:

- .NET Framework or .NET Core (depending on the project requirements)
- Visual Studio

## Installation

1. Clone the repository to your local machine using the following command:

    ```shell
    git clone https://github.com/JackGerry1/ImprovedMastermind
    ```
2. Open Visual Studio.

3. In Visual Studiohttps://github.com/JackGerry1/ImprovedMastermind, go to **File > Open > Project/Solution** and navigate to the cloned repository.

4. Select the project file (usually ending with .csproj extension) and click **Open**.

5. Visual Studio will load the project and its dependencies.

6. Build the project by going to **Build > Build Solution** or pressing **Ctrl + Shift + B**. This will restore the NuGet packages, compile the code, and generate the necessary binaries.

## Running the Program

1. Once the project is built successfully, **Run** the program.

2. The program will start executing, and the output will be a GUI Main Menu Screen. 

3. Now you can play the game.
