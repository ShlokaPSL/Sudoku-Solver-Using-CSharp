# Sudoku-Solver-Using-CSharp

This application accepts the file name containing a Sudoku Puzzle from the user. [Pre-Loaded Files under SudokuSolver/bin/Debug]


The app first displays the Sudoku Board in the initial state - as read and processed from this file.

It then attempts to solve the given Sudoku Puzzle using 2 strategies - the Simple Markup Strategy which is used to map out the possibilities in each cell of the puzzle, and the Naked Pairs Strategy which is used to eliminate the possibility of a pair of numbers from a particular row, column or block, if that same pair exists as a possibility in two other cells of the same row, column or block.

Finally, the app displays the solved Sudoku Board with a message stating wheteher or not the 2 strategies used were successful in completely solving the puzzle.
