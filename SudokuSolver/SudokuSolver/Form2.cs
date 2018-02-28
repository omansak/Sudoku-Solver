using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuSolver
{
    public partial class Form2 : Form
    {
        private string board;
        private List<Form1.HistoryCell> history;
        public Form2(string board, List<Form1.HistoryCell> history)
        {
            this.board = board;
            this.history = history;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = board;
            foreach (var item in history)
            {
                textBox1.Text += $@"x:{item.X} y:{item.Y} -> {item.Value} " + Environment.NewLine;
            }
        }
    }
}
