using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver.Classes
{
    class Solver
    {
        private int[,] Board;
        private List<Form1.HistoryCell> History;
        public Solver(int[,] board, List<Form1.HistoryCell> history)
        {
            Board = board;
            History = history;
        }
        public bool SolveBoard_1() // 0->8 x 0->8
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (Board[i, j] == 0)
                    {
                        return this.SolveCell(i, j, 1);
                    }
                }
            }
            return true;
        }
        public bool SolveBoard_2() // 8->0 x 8->0
        {
            for (int i = 8; i >= 0; i--)
            {
                for (int j = 8; j >= 0; j--)
                {
                    if (Board[i, j] == 0)
                    {
                        return this.SolveCell(i, j, 2);
                    }
                }
            }
            return true;
        }
        public bool SolveBoard_3() // 0->8 x 8->0
        {
            for (int i = 0; i <= 8; i++)
            {
                for (int j = 8; j >= 0; j--)
                {
                    if (Board[i, j] == 0)
                    {
                        return this.SolveCell(i, j, 3);
                    }
                }
            }
            return true;
        }
        private bool IsUnique(int x, int y, int val)
        {
            bool isUnique = true;
            // Satır için
            for (int i = 0; i < 9; i++)
            {
                if (i != x)
                {
                    if (Board[i, y] == val)
                    {
                        isUnique = false;
                        break;
                    }
                }
            }
            // Sutun için
            for (int i = 0; i < 9; i++)
            {
                if (i != y)
                {
                    if (Board[x, i] == val)
                    {
                        isUnique = false;
                        break;
                    }
                }
            }
            //3x3 lük kare için
            int ix = x - (x % 3);
            int jy = y - (y % 3);
            for (int i = ix; i < ix + 3; i++)
            {
                for (int j = jy; j < jy + 3; j++)
                {
                    if (i != x && j != y)
                    {
                        if (Board[i, j] == val)
                        {
                            isUnique = false;
                            break;
                        }
                    }
                }
            }

            return isUnique;
        }
        private bool SolveCell(int x, int y, int solveMethod)
        {
            for (int i = 1; i <= 9; i++)
            {
                if (IsUnique(x, y, i))
                {
                    Board[x, y] = i;
                    Form1.HistoryCell cell = new Form1.HistoryCell
                    {
                        X = x,
                        Y = y,
                        Value = i
                    };
                    History.Add(cell);
                    switch (solveMethod)
                    {
                        case 1:
                            if (this.SolveBoard_1())
                            {
                                return true;
                            }
                            else
                            {
                                History.Remove(cell);
                            }
                            break;
                        case 2:
                            if (this.SolveBoard_2())
                            {
                                return true;
                            }
                            else
                            {
                                History.Remove(cell);
                            }
                            break;
                        case 3:
                            if (this.SolveBoard_3())
                            {
                                return true;
                            }
                            else
                            {
                                History.Remove(cell);
                            }
                            break;
                    }
                }
            }
            Board[x, y] = 0;
            return false;
        }
    }
}
