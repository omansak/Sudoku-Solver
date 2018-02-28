using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SudokuSolver.Classes;

namespace SudokuSolver
{
    public partial class Form1 : Form
    {

        #region Boards
        private int[,] _orjBoard;
        public static int[,] WorkBoard1;
        public static int[,] WorkBoard2;
        public static int[,] WorkBoard3;
        public static List<HistoryCell> History1;
        public static List<HistoryCell> History2;
        public static List<HistoryCell> History3;
        #endregion
        #region Threads
        private Thread _core1;
        private Thread _core2;
        private Thread _core3;

        #endregion
        #region ThreadTime
        private Stopwatch _core1time = new Stopwatch();
        private Stopwatch _core2time = new Stopwatch();
        private Stopwatch _core3time = new Stopwatch();
        #endregion
        #region Utility
        private static string Path;
        #endregion
        public Form1()
        {
            InitializeComponent();
        }
        public int[,] CopyBoard(int[,] board)
        {
            int[,] result = new int[9, 9];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    result[i, j] = board[i, j];
                }
            }
            return result;
        }
        private void MultiThreadSolver()
        {
            //Sudoku yu threadlara kopyalama
            WorkBoard1 = CopyBoard(_orjBoard);
            WorkBoard2 = CopyBoard(_orjBoard);
            WorkBoard3 = CopyBoard(_orjBoard);
            //Threadler için History yaratma
            History1 = new List<HistoryCell>();
            History2 = new List<HistoryCell>();
            History3 = new List<HistoryCell>();
            //Threadlere işlerini bildirme
            _core1 = new Thread(Work_1);
            _core2 = new Thread(Work_2);
            _core3 = new Thread(Work_3);
            //Threadları başlatma
            //Thread 1 ve Zamanlanyıcı 1 başlatma
            _core1time.Reset();
            _core1time.Start();
            _core1.Start();
            //Thread 2 ve Zamanlanyıcı 2 başlatma
            _core2time.Reset();
            _core2time.Start();
            _core2.Start();
            //Thread 3 ve Zamanlanyıcı 3 başlatma
            _core3time.Reset();
            _core3time.Start();
            _core3.Start();



        }
        private void Work_1()
        {
            new Solver(WorkBoard1, History1).SolveBoard_1();
            StopThread(1);
        }
        private void Work_2()
        {

            new Solver(WorkBoard2, History2).SolveBoard_2();
            StopThread(2);
        }
        private void Work_3()
        {
            new Solver(WorkBoard3, History3).SolveBoard_3();
            StopThread(3);

        }
        private void StopThread(int thread)
        {
            // Zamanlayıcıları durdurma
            _core1time.Stop();
            _core2time.Stop();
            _core3time.Stop();
            //Sudoku yu çözen thread hariç diğer threadları durduma
            switch (thread)
            {
                case 1:
                    _core2.Abort();
                    _core3.Abort();
                    status1.Invoke((MethodInvoker)(() => status1.Text = "Çözüldü...")); // Bir threadın GUI arayüzünü değiştirmek için kullanılan method
                    status2.Invoke((MethodInvoker)(() => status2.Text = "Durduruldu..."));
                    status3.Invoke((MethodInvoker)(() => status3.Text = "Durduruldu..."));
                    break;
                case 2:
                    _core1.Abort();
                    _core3.Abort();
                    status1.Invoke((MethodInvoker)(() => status1.Text = "Durduruldu..."));
                    status2.Invoke((MethodInvoker)(() => status2.Text = "Çözüldü..."));
                    status3.Invoke((MethodInvoker)(() => status3.Text = "Durduruldu..."));
                    break;
                case 3:
                    _core1.Abort();
                    _core2.Abort();
                    status1.Invoke((MethodInvoker)(() => status1.Text = "Durduruldu..."));
                    status2.Invoke((MethodInvoker)(() => status2.Text = "Durduruldu..."));
                    status3.Invoke((MethodInvoker)(() => status3.Text = "Çözüldü..."));
                    break;
            }

            // Zamanlayıcıları ekrana yazma
            time1.Invoke((MethodInvoker)(() => time1.Text = _core1time.Elapsed + " ms"));
            time2.Invoke((MethodInvoker)(() => time2.Text = _core2time.Elapsed + " ms"));
            time3.Invoke((MethodInvoker)(() => time3.Text = _core3time.Elapsed + " ms"));
            // Sudoku ların son halini yazdırma
            PrintBoard();
        }
        private string WriteSudokuFile(int[,] board, string name)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    sb.Append(board[i, j].ToString());
                }
                sb.Append(Environment.NewLine);
            }
            File.WriteAllText(Path + name + ".txt", sb.ToString());
            return sb.ToString();
        }
        private string WriteHistoryFile(List<HistoryCell> history, string name)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in history)
            {
                sb.Append($@"x:{item.X} y:{item.Y} -> {item.Value} " + Environment.NewLine);
            }
            File.WriteAllText(Path + name + ".txt", sb.ToString());
            return sb.ToString();
        }
        private void PrintBoard()
        {
            sudoku1.Invoke((MethodInvoker)(() => sudoku1.Text = WriteSudokuFile(WorkBoard1, "_workBoard1"))); // Bir threadın GUI arayüzünü değiştirmek için kullanılan method
            sudoku2.Invoke((MethodInvoker)(() => sudoku2.Text = WriteSudokuFile(WorkBoard2, "_workBoard2"))); // Bir threadın GUI arayüzünü değiştirmek için kullanılan method
            sudoku3.Invoke((MethodInvoker)(() => sudoku3.Text = WriteSudokuFile(WorkBoard3, "_workBoard3"))); // Bir threadın GUI arayüzünü değiştirmek için kullanılan method
            WriteHistoryFile(History1, "_workBoard1_History"); // Thread Sudoku işlem geçmişi metin belgesine yazdırma
            WriteHistoryFile(History2, "_workBoard2_History");
            WriteHistoryFile(History3, "_workBoard3_History");
        }
        private void sudokuAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Suduko Dosyası |*.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _orjBoard = new Classes.SudokuBoard(dialog.FileName).GetBoard();
                Path = dialog.FileName.Replace(dialog.SafeFileName, "");
            }

        }
        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void sudukoÇözToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_orjBoard != null)
            {

                MultiThreadSolver();
            }
            else
            {
                MessageBox.Show("Suduko bulunamadı.");
            }
        }
        public class HistoryCell
        {
            public int X;
            public int Y;
            public int Value;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (WorkBoard1 != null)
            {
                Form2 form = new Form2(sudoku1.Text, History1);
                form.Show();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (WorkBoard2 != null)
            {
                Form2 form = new Form2(sudoku2.Text, History2);
                form.Show();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (WorkBoard3 != null)
            {
                Form2 form = new Form2(sudoku3.Text, History3);
                form.Show();
            }
        }
    }
}
