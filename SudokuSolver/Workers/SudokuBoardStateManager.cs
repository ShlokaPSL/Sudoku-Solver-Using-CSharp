using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver.Workers
{
    class SudokuBoardStateManager
    {
        public string GenerateState(int[,] sudokuBoard)
        {
            StringBuilder key = new StringBuilder();

            for (int row = 0; row < sudokuBoard.GetLength(0); row++)        // GetLength(0) -> gets length of rows ie. number of rows. Similarly, GetLength(1) would get the length of cols ie number of columns
            {
                for (int col = 0; col < sudokuBoard.GetLength(1); col++)
                {
                    key.Append(sudokuBoard[row, col]);
                }
            }

            return key.ToString();
        }

        public bool IsSolved(int[,] sudokuBoard)
        {
            for (int row = 0; row < sudokuBoard.GetLength(0); row++)        // GetLength(0) -> gets length of rows ie. number of rows. Similarly, GetLength(1) would get the length of cols ie number of columns
            {
                for (int col = 0; col < sudokuBoard.GetLength(1); col++)
                {
                    if (sudokuBoard[row, col] == 0 || sudokuBoard[row, col].ToString().Length > 1)  // if element is 0 - it is blank ie yet to be solved. If length is >1 - there are several possibilities for that spot - ie it is yet to be solved.
                        return false;
                }
            }

            return true;
        }
    }
}
