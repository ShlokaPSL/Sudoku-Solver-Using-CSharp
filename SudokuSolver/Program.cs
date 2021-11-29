using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SudokuSolver.Strategies;
using SudokuSolver.Workers;

namespace SudokuSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SudokuMapper sudokuMapper = new SudokuMapper();
                SudokuBoardStateManager sudokuBoardStateManager = new SudokuBoardStateManager();
                SudokuSolverEngine sudokuSolverEngine = new SudokuSolverEngine(sudokuBoardStateManager, sudokuMapper);
                SudokuFileReader sudokuFileReader = new SudokuFileReader();
                SudokuBoardDisplayer sudokuBoardDisplayer = new SudokuBoardDisplayer();

                Console.WriteLine("Please enter the FileName containing the Sudoku Puzzle : ");
                var fileName = Console.ReadLine();

                var sudokuBoard = sudokuFileReader.ReadFile(fileName);
                sudokuBoardDisplayer.Display("Initial State", sudokuBoard);

                bool isSudokuSolved = sudokuSolverEngine.Solve(sudokuBoard);
                sudokuBoardDisplayer.Display("Final State", sudokuBoard);

                Console.WriteLine(isSudokuSolved ? "Sudoku Puzzle Solved Successfully! :)" : "Unfortunately, current algorithms were not enough to solve the Sudoku Puzzle! :(");
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0} : {1}", "Sudoku Puzzle could not be solved because there was an error : ", ex.Message);
            }
        }
    }
}
