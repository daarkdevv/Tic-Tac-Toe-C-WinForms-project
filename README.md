# Tic-Tac-Toe (Xo) - C# WinForms Game

A classic Tic-Tac-Toe game implementation built with C# and Windows Forms, featuring a graphical user interface for two-player gameplay.

## Overview

This is a simple yet engaging implementation of the traditional Tic-Tac-Toe game where two players alternate turns on a 3x3 grid. The game features a progress bar to track the number of moves and a label to indicate whose turn it is.

## Features

- **Two-Player Game**: Play against another player on the same computer
- **GUI Interface**: User-friendly Windows Forms interface with visual feedback
- **Move Counter**: Progress bar tracks the game progress (0-9 moves)
- **Player Turn Indicator**: Displays whose turn it is (Player 1 or Player 2)
- **Game Reset**: Reset functionality to start a new game at any time
- **Win Detection**: Automatic detection of winning conditions

## Project Structure

```
.
├── Form1.cs                      # Main game form (logic in XoLogic.cs)
├── Form1.Designer.cs             # Auto-generated UI designer code
├── Form1.resx                    # Form resources
├── XoLogic.cs                    # Core game logic and event handlers
├── Program.cs                    # Application entry point
├── App.config                    # Application configuration
├── WindowsFormsApp2.csproj       # Project file
├── WindowsFormsApp2.sln          # Solution file
├── Properties/                   # Project properties and resources
└── Resources/                    # Game resources directory
```

## Requirements

- .NET Framework 4.x or later
- Windows operating system
- Visual Studio 2015 or later (for development)

## How to Run

### Development:
1. Open `WindowsFormsApp2.sln` in Visual Studio
2. Press `F5` or click "Start" to run the application

### Executable:
- Run `WindowsFormsApp2.exe` from the `bin/Debug/` directory

## Game Rules

- Players take turns placing X and O on a 3x3 grid
- Player 1 is X, Player 2 is O
- First player to get 3 marks in a row (horizontally, vertically, or diagonally) wins
- If all 9 squares are filled with no winner, the game is a draw

## Controls

- **Click on Grid Squares**: Place your mark (X or O)
- **Reset Button**: Start a new game
- **Current Player Label**: Shows whose turn it is
- **Progress Bar**: Visual indication of game progress

## Technical Details

- **Language**: C#
- **Framework**: .NET Windows Forms
- **Namespace**: WindowsFormsApp2
- **Main Classes**: 
  - `Form1`: Contains the game UI and logic

## Key Methods

- `ResetGame()`: Clears the board and resets all game state
- `ClearImages()`: Removes visual marks from the grid
- `CheckWinner()`: Determines if there's a winning condition
- Event Handlers: Process player clicks and game interactions

## Future Enhancements

- AI opponent for single-player mode
- Difficulty levels
- Game statistics and score tracking
- Sound effects
- Different themes and visual styles

## License

Open source - feel free to modify and distribute

---

**Enjoy playing Tic-Tac-Toe!**
