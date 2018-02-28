using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver.Classes
{
    public class SudokuBoard
    {
        private int[,] Board;
        private string Path;
        public SudokuBoard(string path)
        {
            Path = path;
            SetSudoku();
        }
        public int[,] GetBoard()
        {
            return Board;
        }
        private void SetSudoku()
        {
            Board = new int[9, 9];
            var lines = File.ReadLines(Path);
            int row = 0;
            foreach (var line in lines)
            {
                int column = 0;
                foreach (var ch in line)
                {
                    if (ch != '*')
                    {
                        Board[row, column] = (int)Char.GetNumericValue(ch);
                    }
                    else
                    {
                        Board[row, column] = 0;
                    }
                    column++;
                }
                row++;
            }
        }
    }
}
