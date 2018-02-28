namespace SudokuSolver
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sudokuAçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sudukoÇözToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.time1 = new System.Windows.Forms.Label();
            this.time2 = new System.Windows.Forms.Label();
            this.time3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.status1 = new System.Windows.Forms.Label();
            this.status2 = new System.Windows.Forms.Label();
            this.status3 = new System.Windows.Forms.Label();
            this.sudoku1 = new System.Windows.Forms.Label();
            this.sudoku2 = new System.Windows.Forms.Label();
            this.sudoku3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sudokuAçToolStripMenuItem,
            this.kapatToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            resources.ApplyResources(this.menuToolStripMenuItem, "menuToolStripMenuItem");
            // 
            // sudokuAçToolStripMenuItem
            // 
            this.sudokuAçToolStripMenuItem.Name = "sudokuAçToolStripMenuItem";
            resources.ApplyResources(this.sudokuAçToolStripMenuItem, "sudokuAçToolStripMenuItem");
            this.sudokuAçToolStripMenuItem.Click += new System.EventHandler(this.sudokuAçToolStripMenuItem_Click);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            resources.ApplyResources(this.kapatToolStripMenuItem, "kapatToolStripMenuItem");
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.işlemlerToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sudukoÇözToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            resources.ApplyResources(this.işlemlerToolStripMenuItem, "işlemlerToolStripMenuItem");
            // 
            // sudukoÇözToolStripMenuItem
            // 
            this.sudukoÇözToolStripMenuItem.Name = "sudukoÇözToolStripMenuItem";
            resources.ApplyResources(this.sudukoÇözToolStripMenuItem, "sudukoÇözToolStripMenuItem");
            this.sudukoÇözToolStripMenuItem.Click += new System.EventHandler(this.sudukoÇözToolStripMenuItem_Click);
            // 
            // time1
            // 
            resources.ApplyResources(this.time1, "time1");
            this.time1.Name = "time1";
            // 
            // time2
            // 
            resources.ApplyResources(this.time2, "time2");
            this.time2.Name = "time2";
            // 
            // time3
            // 
            resources.ApplyResources(this.time3, "time3");
            this.time3.Name = "time3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // status1
            // 
            resources.ApplyResources(this.status1, "status1");
            this.status1.Name = "status1";
            // 
            // status2
            // 
            resources.ApplyResources(this.status2, "status2");
            this.status2.Name = "status2";
            // 
            // status3
            // 
            resources.ApplyResources(this.status3, "status3");
            this.status3.Name = "status3";
            // 
            // sudoku1
            // 
            resources.ApplyResources(this.sudoku1, "sudoku1");
            this.sudoku1.Name = "sudoku1";
            // 
            // sudoku2
            // 
            resources.ApplyResources(this.sudoku2, "sudoku2");
            this.sudoku2.Name = "sudoku2";
            // 
            // sudoku3
            // 
            resources.ApplyResources(this.sudoku3, "sudoku3");
            this.sudoku3.Name = "sudoku3";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sudoku3);
            this.Controls.Add(this.sudoku2);
            this.Controls.Add(this.sudoku1);
            this.Controls.Add(this.status3);
            this.Controls.Add(this.status2);
            this.Controls.Add(this.status1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.time3);
            this.Controls.Add(this.time2);
            this.Controls.Add(this.time1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sudokuAçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label time1;
        private System.Windows.Forms.Label time2;
        private System.Windows.Forms.Label time3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label status1;
        private System.Windows.Forms.Label status2;
        private System.Windows.Forms.Label status3;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sudukoÇözToolStripMenuItem;
        private System.Windows.Forms.Label sudoku1;
        private System.Windows.Forms.Label sudoku2;
        private System.Windows.Forms.Label sudoku3;
    }
}

